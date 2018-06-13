using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace McAutoFish
{
    public partial class MainForm : Form
    {
        //If you want to send mouseclicks
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        //Hide window
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private bool running = false;
        //Counter for keypresses
        private int keypresses = 0;

        //Left mouse
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;

        //Right mouse
        const int WM_RBUTTONDOWN = 0x0204;
        const int WM_RBUTTONUP = 0x0205;

        //Process finder vars
        IntPtr hWnd;
        string processName = "javaw";

        //Timer
        Stopwatch runtimer = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();

            //Replace pauseOnLostFocus
            bool replace = false;
            foreach (string line in File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\options.txt"))
            {
                if (line.Contains("pauseOnLostFocus:true"))
                {
                    replace = true;
                    MessageBox.Show("Your Minecraft options file is not configured correctly,\n" +
                        "I'm changing pauseOnLostFocus to false.\n" +
                        "This way you can tab out of your game without toggling the pause menu.\n\n" +
                        "Please restart your Minecraft.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (line.Contains("key_key.chat:"))
                {
                    //throw new NotImplementedException();
                }
            }
            if (replace)
            {
                string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\options.txt");
                text = text.Replace("pauseOnLostFocus:true", "pauseOnLostFocus:false");
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\options.txt", text);
            }
        }

        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            if (running == false)
            {
                running = true;
                statusBox.Text = "Started running";
                statusBox.BackColor = Color.Green;

                Thread t = new Thread(keypressloop);
                t.IsBackground = true;
                t.Start();

            }
            else
            {
                statusBox.Text = "Already Running";
            }
        }
        //Stop
        private void button2_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                running = false;
                statusBox.Text = "Stopped running";
                statusBox.BackColor = Color.Red;
            }
            else
            {
                statusBox.Text = "Currently not running";
            }
        }

        private void keypressloop()
        {
            runtimer.Start();
            while (running)
            {
                //Resize Progress bar
                MethodInvoker max = new MethodInvoker(() => progressBarDelay.Maximum = Convert.ToInt32(delay.Value));
                progressBarDelay.Invoke(max);

                //Start timer
                Stopwatch timer = new Stopwatch();
                timer.Start();
                //Set bar
                while (Convert.ToInt32(timer.ElapsedMilliseconds) < Convert.ToInt32(delay.Value))
                {
                    int elapsed = Convert.ToInt32(timer.ElapsedMilliseconds);

                    if (elapsed <= progressBarDelay.Maximum)
                    {
                        MethodInvoker m = new MethodInvoker(() => progressBarDelay.Value = progressBarDelay.Maximum - Convert.ToInt32(elapsed));
                        progressBarDelay.Invoke(m);
                    }

                }
                timer.Reset();
                DoMouseClick();
                keypresses++;
                AppendTextBox2(keypresses.ToString());

                //Set Time
                TimeSpan ts = runtimer.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                AppendTitle(elapsedTime);
            }
            runtimer.Reset();
        }

        public void DoMouseClick()
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process P in processList)
            {
                if (P.ProcessName.Equals(processName))
                {
                    hWnd = P.MainWindowHandle;
                    if (hideBox.Checked) { ShowWindow(hWnd, 2); }

                    if (leftbutton.Checked)
                    {
                        //LEFT MOUSE
                        PostMessage(hWnd, WM_LBUTTONDOWN, 1, MakeLParam(70, 20));
                        PostMessage(hWnd, WM_LBUTTONUP, 0, MakeLParam(71, 21));
                    }
                    else if (rightbutton.Checked)
                    {
                        //RIGHT MOUSE
                        PostMessage(hWnd, WM_RBUTTONDOWN, 1, MakeLParam(70, 20));
                        PostMessage(hWnd, WM_RBUTTONUP, 0, MakeLParam(71, 21));
                    }
                }
            }
        }
        public int MakeLParam(int LoWord, int HiWord)
        {
            return (int)((HiWord << 16) | (LoWord & 0xFFFF));
        }
        public void AppendTitle(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTitle), new object[] { value });
                return;
            }
            this.Text = value;
        }
        public void AppendTextBox2(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox2), new object[] { value });
                return;
            }
            keypressBox.Text = value;
        }
        public void AppendTextBox1(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox1), new object[] { value });
                return;
            }
            keypressBox.Text = value;
        }

        private void donateurl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/KevinSnijder");
        }
    }

}
