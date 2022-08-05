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
            this.FatGramTextbox = new System.Windows.Forms.TextBox();
            this.CarbGramTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FatGramLabel = new System.Windows.Forms.Label();
            this.CarbGramLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FatGramTextbox
            // 
            this.FatGramTextbox.Location = new System.Drawing.Point(195, 71);
            this.FatGramTextbox.Name = "FatGramTextbox";
            this.FatGramTextbox.Size = new System.Drawing.Size(100, 20);
            this.FatGramTextbox.TabIndex = 0;
            this.FatGramTextbox.TextChanged += new System.EventHandler(this.FatGramTextbox_TextChanged);
            // 
            // CarbGramTextbox
            // 
            this.CarbGramTextbox.Location = new System.Drawing.Point(195, 108);
            this.CarbGramTextbox.Name = "CarbGramTextbox";
            this.CarbGramTextbox.Size = new System.Drawing.Size(100, 20);
            this.CarbGramTextbox.TabIndex = 1;
            this.CarbGramTextbox.TextChanged += new System.EventHandler(this.CarbGramTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fat grams";
            // 
            // FatGramLabel
            // 
            this.FatGramLabel.AutoSize = true;
            this.FatGramLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatGramLabel.Location = new System.Drawing.Point(196, 142);
            this.FatGramLabel.Name = "FatGramLabel";
            this.FatGramLabel.Size = new System.Drawing.Size(0, 18);
            this.FatGramLabel.TabIndex = 3;
            // 
            // CarbGramLabel
            // 
            this.CarbGramLabel.AutoSize = true;
            this.CarbGramLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbGramLabel.Location = new System.Drawing.Point(196, 176);
            this.CarbGramLabel.Name = "CarbGramLabel";
            this.CarbGramLabel.Size = new System.Drawing.Size(0, 18);
            this.CarbGramLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carb Grams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calories from Fat and Carbs Converter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calories from Fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calories from Carbs:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(151, 224);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 293);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarbGramLabel);
            this.Controls.Add(this.FatGramLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarbGramTextbox);
            this.Controls.Add(this.FatGramTextbox);
            this.Name = "Form1";
            this.Text = "Calorie Cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FatGramTextbox;
        private System.Windows.Forms.TextBox CarbGramTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FatGramLabel;
        private System.Windows.Forms.Label CarbGramLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitBtn;
    }
}

