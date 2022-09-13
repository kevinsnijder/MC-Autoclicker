using MinecraftAutoClicker.Minecraft;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MinecraftAutoClicker
{
   public partial class MainForm : Form
   {
      private const string _processName = "javaw";
      private ProcessClicker _processClicker;
      private Stopwatch _autoClickStopwatch;
      private bool _isAutoClicking;

      /// <summary>
      /// Initializes the form
      /// </summary>
      public MainForm()
      {
         InitializeComponent();
         UpdateMinecraftConfig();

         _processClicker = new ProcessClicker();
         _autoClickStopwatch = new Stopwatch();
      }

      /// <summary>
      /// Updates the minecraft config to prevent showing the menu when alt-tabbing the game
      /// </summary>
      public bool UpdateMinecraftConfig()
      {
         var configChecker = new MinecraftConfigChecker();
         if (configChecker.RequireFocusLostReplacement)
         {
            ShowIncorrectConfigurationMessageBox();
            return configChecker.ReplacePauseOnFocusLost();
         }
         return false;
      }

      /// <summary>
      /// Starts running the autoclicker on the minecraft window
      /// </summary>
      private void StartAutoClicker(object sender, EventArgs e)
      {
         if (_isAutoClicking == false)
         {
            statusBox.Text = "Started running";
            statusBox.BackColor = Color.Green;

            var javawProcesses = ProcessManager.GetProcessPointersByName(_processName);
            _processClicker.AttachToProcesses(javawProcesses);
            _isAutoClicking = true;
            StartAutoClickThread();
         }
         else
         {
            statusBox.Text = "Already Running";
         }
      }

      /// <summary>
      /// Starts the thread that clicks the minecraft window
      /// </summary>
      private Thread StartAutoClickThread()
      {
         Thread t = new Thread(AutoClickLoop);
         t.IsBackground = true;
         t.Start();
         return t;
      }

      /// <summary>
      /// Stops running the autoclicker on the minecraft window
      /// </summary>
      private void StopAutoClicker(object sender, EventArgs e)
      {
         if (_isAutoClicking == true)
         {
            _isAutoClicking = false;
            statusBox.Text = "Stopped running";
            statusBox.BackColor = Color.Red;
         }
         else
         {
            statusBox.Text = "Currently not running";
         }
      }

      /// <summary>
      /// The loop which performs the correct clicks and UI updates
      /// </summary>
      private void AutoClickLoop()
      {
         _autoClickStopwatch.Start();
         while (_isAutoClicking)
         {
            //Resize Progress bar
            MethodInvoker max = new MethodInvoker(() => progressBarDelay.Maximum = Convert.ToInt32(delayValueLabel.Value));
            progressBarDelay.Invoke(max);

            //Start timer
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //Set bar
            while (Convert.ToInt32(timer.ElapsedMilliseconds) < Convert.ToInt32(delayValueLabel.Value))
            {
               int elapsed = Convert.ToInt32(timer.ElapsedMilliseconds);

               if (elapsed <= progressBarDelay.Maximum)
               {
                  MethodInvoker m = new MethodInvoker(() => progressBarDelay.Value = progressBarDelay.Maximum - Convert.ToInt32(elapsed));
                  progressBarDelay.Invoke(m);
               }
            }
            timer.Reset();
            ExecuteGameClick();
            ChangeKeyPressValue(_processClicker.TotalKeyPresses.ToString());

            //Set Time
            TimeSpan ts = _autoClickStopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            ChangeFormTitle(elapsedTime);
         }
         _autoClickStopwatch.Reset();
      }

      /// <summary>
      /// Performs a click in the game window(s)
      /// </summary>
      public void ExecuteGameClick()
      {
         if (leftbutton.Checked)
            _processClicker.LeftClick();
         else if (rightbutton.Checked)
            _processClicker.RightClick();
      }

      /// <summary>
      /// Opens browser
      /// </summary>
      private void OpenDonatorLink(object sender, LinkLabelLinkClickedEventArgs e)
      {
         ProcessStartInfo psInfo = new ProcessStartInfo
         {
            FileName = "https://www.paypal.me/KevinSnijder",
            UseShellExecute = true
         };
         Process.Start(psInfo);
      }

      /// <summary>
      /// Shows a textbox
      /// </summary>
      private void ShowIncorrectConfigurationMessageBox()
      {
         MessageBox.Show("Your Minecraft options file is not configured correctly,\n" +
             "Changing pauseOnLostFocus to false.\n" +
             "This way you can tab out of your game without toggling the pause menu.\n\n" +
             "Please restart your Minecraft for the changes to take effect..", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
      }

      /// <summary>
      /// On change of the minimize maximize checkbox
      /// </summary>
      private void MinimizeMaximizeChange(object sender, EventArgs e)
      {
         if (_processClicker.AttachedProcesses == null)
            return;

         foreach (var process in _processClicker.AttachedProcesses) 
         { 
            if(hideBox.Checked)
               WindowManager.MinimizeWindow(process);
            else
               WindowManager.MaximizeWindow(process);
         }
      }
   }
}
