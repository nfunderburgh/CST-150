namespace Activity_11
{
    partial class RollingDice
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
            this.RollDice = new System.Windows.Forms.Button();
            this.DiceNum1 = new System.Windows.Forms.RichTextBox();
            this.DiceNum2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RollDice
            // 
            this.RollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollDice.Location = new System.Drawing.Point(49, 50);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(162, 138);
            this.RollDice.TabIndex = 0;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // DiceNum1
            // 
            this.DiceNum1.BackColor = System.Drawing.SystemColors.Window;
            this.DiceNum1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNum1.Location = new System.Drawing.Point(282, 69);
            this.DiceNum1.Name = "DiceNum1";
            this.DiceNum1.Size = new System.Drawing.Size(100, 96);
            this.DiceNum1.TabIndex = 1;
            this.DiceNum1.Text = "";
            // 
            // DiceNum2
            // 
            this.DiceNum2.BackColor = System.Drawing.SystemColors.Window;
            this.DiceNum2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNum2.Location = new System.Drawing.Point(440, 69);
            this.DiceNum2.Name = "DiceNum2";
            this.DiceNum2.Size = new System.Drawing.Size(100, 96);
            this.DiceNum2.TabIndex = 2;
            this.DiceNum2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(591, 247);
            this.Controls.Add(this.DiceNum2);
            this.Controls.Add(this.DiceNum1);
            this.Controls.Add(this.RollDice);
            this.Name = "Form1";
            this.Text = "Dice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.RichTextBox DiceNum1;
        private System.Windows.Forms.RichTextBox DiceNum2;
    }
}

