
namespace R6AutoSplitter
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aspectRatioLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // aspectRatioLabel
            // 
            this.aspectRatioLabel.AutoSize = true;
            this.aspectRatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectRatioLabel.Location = new System.Drawing.Point(12, 45);
            this.aspectRatioLabel.Name = "aspectRatioLabel";
            this.aspectRatioLabel.Size = new System.Drawing.Size(105, 20);
            this.aspectRatioLabel.TabIndex = 1;
            this.aspectRatioLabel.Text = "Aspect Ratio:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(82, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(91, 26);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Settings";
            // 
            // debugButton
            // 
            this.debugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.debugButton.Location = new System.Drawing.Point(41, 304);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(184, 45);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "Debug Viewer";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 361);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.aspectRatioLabel);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsWindow_FormClosed);
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label aspectRatioLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button debugButton;
    }
}