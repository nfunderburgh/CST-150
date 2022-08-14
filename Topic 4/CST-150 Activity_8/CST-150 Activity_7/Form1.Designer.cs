namespace CST_150_Activity_7
{
    partial class CalorieConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalorieConverter));
            this.FatGramTextbox = new System.Windows.Forms.TextBox();
            this.CarbGramTextbox = new System.Windows.Forms.TextBox();
            this.FatGramsLabel = new System.Windows.Forms.Label();
            this.FatGramLabel = new System.Windows.Forms.Label();
            this.CarbGramLabel = new System.Windows.Forms.Label();
            this.CarbGramsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaloriesFromFatLabel = new System.Windows.Forms.Label();
            this.CaloriesFromCarbsLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FatGramTextbox
            // 
            resources.ApplyResources(this.FatGramTextbox, "FatGramTextbox");
            this.FatGramTextbox.Name = "FatGramTextbox";
            this.FatGramTextbox.TextChanged += new System.EventHandler(this.FatGramTextbox_TextChanged);
            // 
            // CarbGramTextbox
            // 
            resources.ApplyResources(this.CarbGramTextbox, "CarbGramTextbox");
            this.CarbGramTextbox.Name = "CarbGramTextbox";
            this.CarbGramTextbox.TextChanged += new System.EventHandler(this.CarbGramTextbox_TextChanged);
            // 
            // FatGramsLabel
            // 
            resources.ApplyResources(this.FatGramsLabel, "FatGramsLabel");
            this.FatGramsLabel.Name = "FatGramsLabel";
            // 
            // FatGramLabel
            // 
            resources.ApplyResources(this.FatGramLabel, "FatGramLabel");
            this.FatGramLabel.Name = "FatGramLabel";
            // 
            // CarbGramLabel
            // 
            resources.ApplyResources(this.CarbGramLabel, "CarbGramLabel");
            this.CarbGramLabel.Name = "CarbGramLabel";
            // 
            // CarbGramsLabel
            // 
            resources.ApplyResources(this.CarbGramsLabel, "CarbGramsLabel");
            this.CarbGramsLabel.Name = "CarbGramsLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Name = "label2";
            // 
            // CaloriesFromFatLabel
            // 
            resources.ApplyResources(this.CaloriesFromFatLabel, "CaloriesFromFatLabel");
            this.CaloriesFromFatLabel.Name = "CaloriesFromFatLabel";
            // 
            // CaloriesFromCarbsLabel
            // 
            resources.ApplyResources(this.CaloriesFromCarbsLabel, "CaloriesFromCarbsLabel");
            this.CaloriesFromCarbsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaloriesFromCarbsLabel.Name = "CaloriesFromCarbsLabel";
            // 
            // ExitBtn
            // 
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CalorieConverter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CaloriesFromCarbsLabel);
            this.Controls.Add(this.CaloriesFromFatLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarbGramsLabel);
            this.Controls.Add(this.CarbGramLabel);
            this.Controls.Add(this.FatGramLabel);
            this.Controls.Add(this.FatGramsLabel);
            this.Controls.Add(this.CarbGramTextbox);
            this.Controls.Add(this.FatGramTextbox);
            this.Name = "CalorieConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FatGramTextbox;
        private System.Windows.Forms.TextBox CarbGramTextbox;
        private System.Windows.Forms.Label FatGramsLabel;
        private System.Windows.Forms.Label FatGramLabel;
        private System.Windows.Forms.Label CarbGramLabel;
        private System.Windows.Forms.Label CarbGramsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CaloriesFromFatLabel;
        private System.Windows.Forms.Label CaloriesFromCarbsLabel;
        private System.Windows.Forms.Button ExitBtn;
    }
}

