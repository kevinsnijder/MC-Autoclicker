namespace McAutoFish
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.keypressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftbutton = new System.Windows.Forms.RadioButton();
            this.rightbutton = new System.Windows.Forms.RadioButton();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarDelay = new System.Windows.Forms.ProgressBar();
            this.hideBox = new System.Windows.Forms.CheckBox();
            this.donateurl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startButton.Location = new System.Drawing.Point(201, 65);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 78);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBox.Location = new System.Drawing.Point(200, 12);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(187, 20);
            this.statusBox.TabIndex = 1;
            this.statusBox.Text = "Current Status";
            this.statusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stopButton.Location = new System.Drawing.Point(296, 65);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(92, 78);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // keypressBox
            // 
            this.keypressBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.keypressBox.Location = new System.Drawing.Point(201, 39);
            this.keypressBox.Name = "keypressBox";
            this.keypressBox.ReadOnly = true;
            this.keypressBox.Size = new System.Drawing.Size(187, 20);
            this.keypressBox.TabIndex = 3;
            this.keypressBox.Text = "Total keypresses";
            this.keypressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created by Lepeltje";
            // 
            // leftbutton
            // 
            this.leftbutton.AutoSize = true;
            this.leftbutton.Location = new System.Drawing.Point(53, 42);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(78, 17);
            this.leftbutton.TabIndex = 6;
            this.leftbutton.Text = "Left Mouse";
            this.leftbutton.UseVisualStyleBackColor = true;
            // 
            // rightbutton
            // 
            this.rightbutton.AutoSize = true;
            this.rightbutton.Checked = true;
            this.rightbutton.Location = new System.Drawing.Point(53, 65);
            this.rightbutton.Name = "rightbutton";
            this.rightbutton.Size = new System.Drawing.Size(85, 17);
            this.rightbutton.TabIndex = 7;
            this.rightbutton.TabStop = true;
            this.rightbutton.Text = "Right Mouse";
            this.rightbutton.UseVisualStyleBackColor = true;
            // 
            // delay
            // 
            this.delay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delay.Location = new System.Drawing.Point(40, 114);
            this.delay.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(120, 20);
            this.delay.TabIndex = 8;
            this.delay.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delay in milliseconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Settings";
            // 
            // progressBarDelay
            // 
            this.progressBarDelay.BackColor = System.Drawing.Color.SteelBlue;
            this.progressBarDelay.Enabled = false;
            this.progressBarDelay.Location = new System.Drawing.Point(-1, 171);
            this.progressBarDelay.MarqueeAnimationSpeed = 1;
            this.progressBarDelay.Name = "progressBarDelay";
            this.progressBarDelay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarDelay.Size = new System.Drawing.Size(403, 23);
            this.progressBarDelay.Step = 1;
            this.progressBarDelay.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDelay.TabIndex = 11;
            // 
            // hideBox
            // 
            this.hideBox.AutoSize = true;
            this.hideBox.Location = new System.Drawing.Point(41, 140);
            this.hideBox.Name = "hideBox";
            this.hideBox.Size = new System.Drawing.Size(113, 17);
            this.hideBox.TabIndex = 12;
            this.hideBox.Text = "Minimize Minecraft";
            this.hideBox.UseVisualStyleBackColor = true;
            // 
            // donateurl
            // 
            this.donateurl.AutoSize = true;
            this.donateurl.LinkColor = System.Drawing.Color.DimGray;
            this.donateurl.Location = new System.Drawing.Point(294, 155);
            this.donateurl.Name = "donateurl";
            this.donateurl.Size = new System.Drawing.Size(100, 13);
            this.donateurl.TabIndex = 13;
            this.donateurl.TabStop = true;
            this.donateurl.Text = "Consider Donating?";
            this.donateurl.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.donateurl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donateurl_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 175);
            this.Controls.Add(this.donateurl);
            this.Controls.Add(this.hideBox);
            this.Controls.Add(this.progressBarDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.rightbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keypressBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Minecraft ClickBot";
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox keypressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton leftbutton;
        private System.Windows.Forms.RadioButton rightbutton;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarDelay;
        private System.Windows.Forms.CheckBox hideBox;
        private System.Windows.Forms.LinkLabel donateurl;
    }
}

