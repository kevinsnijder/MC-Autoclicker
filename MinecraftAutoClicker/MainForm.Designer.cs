using MinecraftAutoClicker.Minecraft;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MinecraftAutoClicker
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      internal Button startButton;
      internal TextBox statusBox;
      internal Button stopButton;
      internal TextBox keypressBox;
      internal Label creatorLabel;
      internal RadioButton leftbutton;
      internal RadioButton rightbutton;
      internal NumericUpDown delayValueLabel;
      internal Label delayLabel;
      internal Label settingsLabel;
      internal ProgressBar progressBarDelay;
      internal CheckBox hideBox;
      internal LinkLabel donateUrlLink;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      /// <summary>
      /// Initializes the form
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.startButton = new System.Windows.Forms.Button();
         this.statusBox = new System.Windows.Forms.TextBox();
         this.stopButton = new System.Windows.Forms.Button();
         this.keypressBox = new System.Windows.Forms.TextBox();
         this.creatorLabel = new System.Windows.Forms.Label();
         this.leftbutton = new System.Windows.Forms.RadioButton();
         this.rightbutton = new System.Windows.Forms.RadioButton();
         this.delayValueLabel = new System.Windows.Forms.NumericUpDown();
         this.delayLabel = new System.Windows.Forms.Label();
         this.settingsLabel = new System.Windows.Forms.Label();
         this.progressBarDelay = new System.Windows.Forms.ProgressBar();
         this.hideBox = new System.Windows.Forms.CheckBox();
         this.donateUrlLink = new System.Windows.Forms.LinkLabel();
         ((System.ComponentModel.ISupportInitialize)(this.delayValueLabel)).BeginInit();
         this.SuspendLayout();
         // 
         // startButton
         // 
         this.startButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.startButton.Location = new System.Drawing.Point(234, 75);
         this.startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.startButton.Name = "startButton";
         this.startButton.Size = new System.Drawing.Size(103, 90);
         this.startButton.TabIndex = 0;
         this.startButton.Text = "Start";
         this.startButton.UseVisualStyleBackColor = false;
         this.startButton.Click += new System.EventHandler(this.StartAutoClicker);
         // 
         // statusBox
         // 
         this.statusBox.BackColor = System.Drawing.Color.WhiteSmoke;
         this.statusBox.Location = new System.Drawing.Point(233, 14);
         this.statusBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.statusBox.Name = "statusBox";
         this.statusBox.ReadOnly = true;
         this.statusBox.Size = new System.Drawing.Size(218, 23);
         this.statusBox.TabIndex = 1;
         this.statusBox.Text = "Current Status";
         this.statusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // stopButton
         // 
         this.stopButton.BackColor = System.Drawing.Color.WhiteSmoke;
         this.stopButton.Location = new System.Drawing.Point(345, 75);
         this.stopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.stopButton.Name = "stopButton";
         this.stopButton.Size = new System.Drawing.Size(107, 90);
         this.stopButton.TabIndex = 2;
         this.stopButton.Text = "Stop";
         this.stopButton.UseVisualStyleBackColor = false;
         this.stopButton.Click += new System.EventHandler(this.StopAutoClicker);
         // 
         // keypressBox
         // 
         this.keypressBox.BackColor = System.Drawing.Color.WhiteSmoke;
         this.keypressBox.Location = new System.Drawing.Point(234, 45);
         this.keypressBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.keypressBox.Name = "keypressBox";
         this.keypressBox.ReadOnly = true;
         this.keypressBox.Size = new System.Drawing.Size(218, 23);
         this.keypressBox.TabIndex = 3;
         this.keypressBox.Text = "Total keypresses";
         this.keypressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // creatorLabel
         // 
         this.creatorLabel.AutoSize = true;
         this.creatorLabel.Location = new System.Drawing.Point(338, 164);
         this.creatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.creatorLabel.Name = "creatorLabel";
         this.creatorLabel.Size = new System.Drawing.Size(128, 15);
         this.creatorLabel.TabIndex = 5;
         this.creatorLabel.Text = "Created by Gehaktman";
         // 
         // leftbutton
         // 
         this.leftbutton.AutoSize = true;
         this.leftbutton.Location = new System.Drawing.Point(62, 48);
         this.leftbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.leftbutton.Name = "leftbutton";
         this.leftbutton.Size = new System.Drawing.Size(84, 19);
         this.leftbutton.TabIndex = 6;
         this.leftbutton.Text = "Left Mouse";
         this.leftbutton.UseVisualStyleBackColor = true;
         // 
         // rightbutton
         // 
         this.rightbutton.AutoSize = true;
         this.rightbutton.Checked = true;
         this.rightbutton.Location = new System.Drawing.Point(62, 75);
         this.rightbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.rightbutton.Name = "rightbutton";
         this.rightbutton.Size = new System.Drawing.Size(92, 19);
         this.rightbutton.TabIndex = 7;
         this.rightbutton.TabStop = true;
         this.rightbutton.Text = "Right Mouse";
         this.rightbutton.UseVisualStyleBackColor = true;
         // 
         // delayValueLabel
         // 
         this.delayValueLabel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.delayValueLabel.Location = new System.Drawing.Point(47, 132);
         this.delayValueLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.delayValueLabel.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
         this.delayValueLabel.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
         this.delayValueLabel.Name = "delayValueLabel";
         this.delayValueLabel.Size = new System.Drawing.Size(140, 23);
         this.delayValueLabel.TabIndex = 8;
         this.delayValueLabel.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
         // 
         // delayLabel
         // 
         this.delayLabel.AutoSize = true;
         this.delayLabel.Location = new System.Drawing.Point(58, 113);
         this.delayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.delayLabel.Name = "delayLabel";
         this.delayLabel.Size = new System.Drawing.Size(118, 15);
         this.delayLabel.TabIndex = 9;
         this.delayLabel.Text = "Delay in milliseconds";
         // 
         // settingsLabel
         // 
         this.settingsLabel.AutoSize = true;
         this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.settingsLabel.Location = new System.Drawing.Point(56, 7);
         this.settingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.settingsLabel.Name = "settingsLabel";
         this.settingsLabel.Size = new System.Drawing.Size(90, 25);
         this.settingsLabel.TabIndex = 10;
         this.settingsLabel.Text = "Settings";
         // 
         // progressBarDelay
         // 
         this.progressBarDelay.BackColor = System.Drawing.Color.SteelBlue;
         this.progressBarDelay.Enabled = false;
         this.progressBarDelay.Location = new System.Drawing.Point(-1, 197);
         this.progressBarDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.progressBarDelay.MarqueeAnimationSpeed = 1;
         this.progressBarDelay.Name = "progressBarDelay";
         this.progressBarDelay.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.progressBarDelay.Size = new System.Drawing.Size(470, 27);
         this.progressBarDelay.Step = 1;
         this.progressBarDelay.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.progressBarDelay.TabIndex = 11;
         // 
         // hideBox
         // 
         this.hideBox.AutoSize = true;
         this.hideBox.Location = new System.Drawing.Point(48, 162);
         this.hideBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.hideBox.Name = "hideBox";
         this.hideBox.Size = new System.Drawing.Size(129, 19);
         this.hideBox.TabIndex = 12;
         this.hideBox.Text = "Minimize Minecraft";
         this.hideBox.UseVisualStyleBackColor = true;
         this.hideBox.CheckedChanged += new System.EventHandler(this.MinimizeMaximizeChange);
         // 
         // donateUrlLink
         // 
         this.donateUrlLink.AutoSize = true;
         this.donateUrlLink.LinkColor = System.Drawing.Color.DimGray;
         this.donateUrlLink.Location = new System.Drawing.Point(338, 179);
         this.donateUrlLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.donateUrlLink.Name = "donateUrlLink";
         this.donateUrlLink.Size = new System.Drawing.Size(117, 15);
         this.donateUrlLink.TabIndex = 13;
         this.donateUrlLink.TabStop = true;
         this.donateUrlLink.Text = "Give me your money";
         this.donateUrlLink.VisitedLinkColor = System.Drawing.Color.DimGray;
         this.donateUrlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenDonatorLink);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(467, 202);
         this.Controls.Add(this.donateUrlLink);
         this.Controls.Add(this.hideBox);
         this.Controls.Add(this.progressBarDelay);
         this.Controls.Add(this.settingsLabel);
         this.Controls.Add(this.delayLabel);
         this.Controls.Add(this.delayValueLabel);
         this.Controls.Add(this.rightbutton);
         this.Controls.Add(this.leftbutton);
         this.Controls.Add(this.creatorLabel);
         this.Controls.Add(this.keypressBox);
         this.Controls.Add(this.stopButton);
         this.Controls.Add(this.statusBox);
         this.Controls.Add(this.startButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.Text = "Minecraft ClickBot";
         ((System.ComponentModel.ISupportInitialize)(this.delayValueLabel)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      /// <summary>
      /// Changes the value of the form title
      /// </summary>
      public void ChangeFormTitle(string value)
      {
         if (InvokeRequired)
         {
            this.Invoke(new Action<string>(ChangeFormTitle), new object[] { value });
            return;
         }
         this.Text = value;
      }

      /// <summary>
      /// Changes the value of the keypressbox
      /// </summary>
      public void ChangeKeyPressValue(string value)
      {
         if (InvokeRequired)
         {
            this.Invoke(new Action<string>(ChangeKeyPressValue), new object[] { value });
            return;
         }
         keypressBox.Text = value;
      }
   }
}