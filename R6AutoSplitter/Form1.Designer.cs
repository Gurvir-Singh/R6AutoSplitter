
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
            this.TerroristHuntButton = new System.Windows.Forms.RadioButton();
            this.SituationsButton = new System.Windows.Forms.RadioButton();
            this.AllSituationsButton = new System.Windows.Forms.RadioButton();
            this.AllTerroristHuntsButton = new System.Windows.Forms.RadioButton();
            this.runningText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.debugButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(221, 65);
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
            this.Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.Location = new System.Drawing.Point(235, 140);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(98, 108);
            this.Countdown.TabIndex = 1;
            this.Countdown.Text = "5";
            // 
            // TerroristHuntButton
            // 
            this.TerroristHuntButton.AutoSize = true;
            this.TerroristHuntButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerroristHuntButton.Location = new System.Drawing.Point(23, 140);
            this.TerroristHuntButton.Name = "TerroristHuntButton";
            this.TerroristHuntButton.Size = new System.Drawing.Size(161, 30);
            this.TerroristHuntButton.TabIndex = 2;
            this.TerroristHuntButton.Text = "Terrorist Hunt";
            this.TerroristHuntButton.UseVisualStyleBackColor = true;
            this.TerroristHuntButton.CheckedChanged += new System.EventHandler(this.TerroristHuntButton_CheckedChanged);
            // 
            // SituationsButton
            // 
            this.SituationsButton.AutoSize = true;
            this.SituationsButton.Checked = true;
            this.SituationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituationsButton.Location = new System.Drawing.Point(23, 65);
            this.SituationsButton.Name = "SituationsButton";
            this.SituationsButton.Size = new System.Drawing.Size(126, 30);
            this.SituationsButton.TabIndex = 3;
            this.SituationsButton.TabStop = true;
            this.SituationsButton.Text = "Situations";
            this.SituationsButton.UseVisualStyleBackColor = true;
            this.SituationsButton.CheckedChanged += new System.EventHandler(this.SituationsButton_CheckedChanged);
            // 
            // AllSituationsButton
            // 
            this.AllSituationsButton.AutoSize = true;
            this.AllSituationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSituationsButton.Location = new System.Drawing.Point(23, 101);
            this.AllSituationsButton.Name = "AllSituationsButton";
            this.AllSituationsButton.Size = new System.Drawing.Size(157, 30);
            this.AllSituationsButton.TabIndex = 4;
            this.AllSituationsButton.Text = "All Situations";
            this.AllSituationsButton.UseVisualStyleBackColor = true;
            this.AllSituationsButton.CheckedChanged += new System.EventHandler(this.AllSituationsButton_CheckedChanged);
            // 
            // AllTerroristHuntsButton
            // 
            this.AllTerroristHuntsButton.AutoSize = true;
            this.AllTerroristHuntsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTerroristHuntsButton.Location = new System.Drawing.Point(23, 176);
            this.AllTerroristHuntsButton.Name = "AllTerroristHuntsButton";
            this.AllTerroristHuntsButton.Size = new System.Drawing.Size(203, 30);
            this.AllTerroristHuntsButton.TabIndex = 5;
            this.AllTerroristHuntsButton.Text = "All Terrorist Hunts";
            this.AllTerroristHuntsButton.UseVisualStyleBackColor = true;
            this.AllTerroristHuntsButton.CheckedChanged += new System.EventHandler(this.AllTerroristHuntsButton_CheckedChanged);
            // 
            // runningText
            // 
            this.runningText.AutoSize = true;
            this.runningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningText.Location = new System.Drawing.Point(192, 248);
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
            // debugButton
            // 
            this.debugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugButton.Location = new System.Drawing.Point(466, 323);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(87, 35);
            this.debugButton.TabIndex = 7;
            this.debugButton.Text = "debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(221, 65);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 39);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 370);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.runningText);
            this.Controls.Add(this.AllTerroristHuntsButton);
            this.Controls.Add(this.AllSituationsButton);
            this.Controls.Add(this.SituationsButton);
            this.Controls.Add(this.TerroristHuntButton);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "R6 AutoSplitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.RadioButton TerroristHuntButton;
        private System.Windows.Forms.RadioButton SituationsButton;
        private System.Windows.Forms.RadioButton AllSituationsButton;
        private System.Windows.Forms.RadioButton AllTerroristHuntsButton;
        private System.Windows.Forms.Label runningText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button StopButton;
    }
}

