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
            this.NumberItemsLabel = new System.Windows.Forms.Label();
            this.NumberItemsTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApproxValueOfPi = new System.Windows.Forms.Label();
            this.PIValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberItemsLabel
            // 
            this.NumberItemsLabel.AutoSize = true;
            this.NumberItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberItemsLabel.Location = new System.Drawing.Point(69, 62);
            this.NumberItemsLabel.Name = "NumberItemsLabel";
            this.NumberItemsLabel.Size = new System.Drawing.Size(148, 20);
            this.NumberItemsLabel.TabIndex = 0;
            this.NumberItemsLabel.Text = "Enter # of Terms:";
            // 
            // NumberItemsTextbox
            // 
            this.NumberItemsTextbox.Location = new System.Drawing.Point(236, 62);
            this.NumberItemsTextbox.Name = "NumberItemsTextbox";
            this.NumberItemsTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumberItemsTextbox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(73, 100);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(81, 42);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
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
            this.PIValue.Size = new System.Drawing.Size(79, 20);
            this.PIValue.TabIndex = 4;
            this.PIValue.Text = "= 3.1415";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 277);
            this.Controls.Add(this.PIValue);
            this.Controls.Add(this.ApproxValueOfPi);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.NumberItemsTextbox);
            this.Controls.Add(this.NumberItemsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberItemsLabel;
        private System.Windows.Forms.TextBox NumberItemsTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ApproxValueOfPi;
        private System.Windows.Forms.Label PIValue;
    }
}

