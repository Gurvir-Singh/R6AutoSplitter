
namespace R6AutoSplitter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Label();
            this.runningText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.pauseAfterSplitCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(72, 110);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 39);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.Location = new System.Drawing.Point(90, 152);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(75, 82);
            this.Countdown.TabIndex = 1;
            this.Countdown.Text = "5";
            // 
            // runningText
            // 
            this.runningText.AutoSize = true;
            this.runningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningText.Location = new System.Drawing.Point(39, 234);
            this.runningText.Name = "runningText";
            this.runningText.Size = new System.Drawing.Size(178, 26);
            this.runningText.TabIndex = 6;
            this.runningText.Text = "Currently running";
            this.runningText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runningText.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(74, 320);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(108, 35);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(72, 110);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 39);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // pauseAfterSplitCheckbox
            // 
            this.pauseAfterSplitCheckbox.AutoSize = true;
            this.pauseAfterSplitCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseAfterSplitCheckbox.Location = new System.Drawing.Point(34, 263);
            this.pauseAfterSplitCheckbox.Name = "pauseAfterSplitCheckbox";
            this.pauseAfterSplitCheckbox.Size = new System.Drawing.Size(187, 30);
            this.pauseAfterSplitCheckbox.TabIndex = 9;
            this.pauseAfterSplitCheckbox.Text = "Pause after split";
            this.pauseAfterSplitCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(Useful for All thunts and All situations categories)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseAfterSplitCheckbox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.runningText);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "R6 AutoSplitter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label runningText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckBox pauseAfterSplitCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

