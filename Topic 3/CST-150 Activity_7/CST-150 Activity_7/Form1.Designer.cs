namespace CST_150_Activity_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumberTermsLabel = new System.Windows.Forms.Label();
            this.NumberTermsTextbox = new System.Windows.Forms.TextBox();
            this.ApproxValueOfPi = new System.Windows.Forms.Label();
            this.PIValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberTermsLabel
            // 
            this.NumberTermsLabel.AutoSize = true;
            this.NumberTermsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTermsLabel.Location = new System.Drawing.Point(69, 62);
            this.NumberTermsLabel.Name = "NumberTermsLabel";
            this.NumberTermsLabel.Size = new System.Drawing.Size(148, 20);
            this.NumberTermsLabel.TabIndex = 0;
            this.NumberTermsLabel.Text = "Enter # of Terms:";
            // 
            // NumberTermsTextbox
            // 
            this.NumberTermsTextbox.Location = new System.Drawing.Point(236, 62);
            this.NumberTermsTextbox.Name = "NumberTermsTextbox";
            this.NumberTermsTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumberTermsTextbox.TabIndex = 1;
            this.NumberTermsTextbox.TextChanged += new System.EventHandler(this.NumberTermsTextbox_TextChanged);
            // 
            // ApproxValueOfPi
            // 
            this.ApproxValueOfPi.AutoSize = true;
            this.ApproxValueOfPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproxValueOfPi.Location = new System.Drawing.Point(69, 166);
            this.ApproxValueOfPi.Name = "ApproxValueOfPi";
            this.ApproxValueOfPi.Size = new System.Drawing.Size(302, 20);
            this.ApproxValueOfPi.TabIndex = 3;
            this.ApproxValueOfPi.Text = "Approximate value of pi after x terms";
            // 
            // PIValue
            // 
            this.PIValue.AutoSize = true;
            this.PIValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIValue.Location = new System.Drawing.Point(73, 214);
            this.PIValue.Name = "PIValue";
            this.PIValue.Size = new System.Drawing.Size(19, 20);
            this.PIValue.TabIndex = 4;
            this.PIValue.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 277);
            this.Controls.Add(this.PIValue);
            this.Controls.Add(this.ApproxValueOfPi);
            this.Controls.Add(this.NumberTermsTextbox);
            this.Controls.Add(this.NumberTermsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberTermsLabel;
        private System.Windows.Forms.TextBox NumberTermsTextbox;
        private System.Windows.Forms.Label ApproxValueOfPi;
        private System.Windows.Forms.Label PIValue;
    }
}

