namespace CST_150_Activity_2
{
    partial class Title
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
            this.SecondsTextbox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EarthLabel = new System.Windows.Forms.Label();
            this.TimeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondsTextbox
            // 
            this.SecondsTextbox.Location = new System.Drawing.Point(238, 64);
            this.SecondsTextbox.Name = "SecondsTextbox";
            this.SecondsTextbox.Size = new System.Drawing.Size(100, 20);
            this.SecondsTextbox.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(257, 175);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(81, 29);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // EarthLabel
            // 
            this.EarthLabel.AutoSize = true;
            this.EarthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarthLabel.Location = new System.Drawing.Point(8, 62);
            this.EarthLabel.Name = "EarthLabel";
            this.EarthLabel.Size = new System.Drawing.Size(211, 20);
            this.EarthLabel.TabIndex = 4;
            this.EarthLabel.Text = "Enter amount of seconds";
            // 
            // TimeOutput
            // 
            this.TimeOutput.AutoSize = true;
            this.TimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutput.Location = new System.Drawing.Point(8, 122);
            this.TimeOutput.Name = "TimeOutput";
            this.TimeOutput.Size = new System.Drawing.Size(305, 20);
            this.TimeOutput.TabIndex = 6;
            this.TimeOutput.Text = "0 Days 0 Hours 0 Minutes 0 Seconds";
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.TimeOutput);
            this.Controls.Add(this.EarthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.SecondsTextbox);
            this.Name = "Title";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecondsTextbox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EarthLabel;
        private System.Windows.Forms.Label TimeOutput;
    }
}

