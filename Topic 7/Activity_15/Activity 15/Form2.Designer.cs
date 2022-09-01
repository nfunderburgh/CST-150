namespace Activity_15
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.luckyNumFinalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luckyNumFinalLabel
            // 
            this.luckyNumFinalLabel.AutoSize = true;
            this.luckyNumFinalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.luckyNumFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumFinalLabel.ForeColor = System.Drawing.Color.White;
            this.luckyNumFinalLabel.Image = ((System.Drawing.Image)(resources.GetObject("luckyNumFinalLabel.Image")));
            this.luckyNumFinalLabel.Location = new System.Drawing.Point(-186, -31);
            this.luckyNumFinalLabel.Name = "luckyNumFinalLabel";
            this.luckyNumFinalLabel.Padding = new System.Windows.Forms.Padding(200);
            this.luckyNumFinalLabel.Size = new System.Drawing.Size(708, 431);
            this.luckyNumFinalLabel.TabIndex = 0;
            this.luckyNumFinalLabel.Text = "Your Lucky Number is ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 367);
            this.Controls.Add(this.luckyNumFinalLabel);
            this.Name = "Form2";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNumFinalLabel;
    }
}