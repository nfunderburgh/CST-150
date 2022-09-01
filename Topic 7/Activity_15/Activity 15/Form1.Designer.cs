namespace Activity_15
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
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.birthYearComboBox = new System.Windows.Forms.ComboBox();
            this.birthMonthComboBox = new System.Windows.Forms.ComboBox();
            this.birthMonthLabel = new System.Windows.Forms.Label();
            this.birthDayComboBox = new System.Windows.Forms.ComboBox();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.favColorComboBox = new System.Windows.Forms.ComboBox();
            this.favColorLabel = new System.Windows.Forms.Label();
            this.getLuckyNumButton = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.GroupBox();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.AutoSize = true;
            this.birthYearLabel.BackColor = System.Drawing.SystemColors.Control;
            this.birthYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthYearLabel.Location = new System.Drawing.Point(23, 63);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(125, 16);
            this.birthYearLabel.TabIndex = 0;
            this.birthYearLabel.Text = "Enter your birth year";
            // 
            // birthYearComboBox
            // 
            this.birthYearComboBox.FormattingEnabled = true;
            this.birthYearComboBox.Location = new System.Drawing.Point(212, 103);
            this.birthYearComboBox.Name = "birthYearComboBox";
            this.birthYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthYearComboBox.TabIndex = 2;
            this.birthYearComboBox.SelectedIndexChanged += new System.EventHandler(this.birthYearComboBox_SelectedIndexChanged);
            // 
            // birthMonthComboBox
            // 
            this.birthMonthComboBox.FormattingEnabled = true;
            this.birthMonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthMonthComboBox.Location = new System.Drawing.Point(212, 141);
            this.birthMonthComboBox.Name = "birthMonthComboBox";
            this.birthMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthMonthComboBox.TabIndex = 4;
            this.birthMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.birthMonthComboBox_SelectedIndexChanged);
            // 
            // birthMonthLabel
            // 
            this.birthMonthLabel.AutoSize = true;
            this.birthMonthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.birthMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthMonthLabel.Location = new System.Drawing.Point(23, 101);
            this.birthMonthLabel.Name = "birthMonthLabel";
            this.birthMonthLabel.Size = new System.Drawing.Size(134, 16);
            this.birthMonthLabel.TabIndex = 3;
            this.birthMonthLabel.Text = "Enter your birth month";
            // 
            // birthDayComboBox
            // 
            this.birthDayComboBox.FormattingEnabled = true;
            this.birthDayComboBox.Location = new System.Drawing.Point(212, 178);
            this.birthDayComboBox.Name = "birthDayComboBox";
            this.birthDayComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthDayComboBox.TabIndex = 6;
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.birthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDayLabel.Location = new System.Drawing.Point(23, 138);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(114, 16);
            this.birthDayLabel.TabIndex = 5;
            this.birthDayLabel.Text = "Enter you birthday";
            // 
            // favColorComboBox
            // 
            this.favColorComboBox.FormattingEnabled = true;
            this.favColorComboBox.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Purple",
            "Red",
            "Orange",
            "Yellow",
            "Pink"});
            this.favColorComboBox.Location = new System.Drawing.Point(212, 216);
            this.favColorComboBox.Name = "favColorComboBox";
            this.favColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.favColorComboBox.TabIndex = 8;
            // 
            // favColorLabel
            // 
            this.favColorLabel.AutoSize = true;
            this.favColorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.favColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favColorLabel.Location = new System.Drawing.Point(23, 176);
            this.favColorLabel.Name = "favColorLabel";
            this.favColorLabel.Size = new System.Drawing.Size(143, 16);
            this.favColorLabel.TabIndex = 7;
            this.favColorLabel.Text = "Enter you favorite color";
            // 
            // getLuckyNumButton
            // 
            this.getLuckyNumButton.BackColor = System.Drawing.SystemColors.Control;
            this.getLuckyNumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLuckyNumButton.ForeColor = System.Drawing.Color.Black;
            this.getLuckyNumButton.Location = new System.Drawing.Point(26, 229);
            this.getLuckyNumButton.Name = "getLuckyNumButton";
            this.getLuckyNumButton.Size = new System.Drawing.Size(266, 42);
            this.getLuckyNumButton.TabIndex = 9;
            this.getLuckyNumButton.Text = "Get Your Lucky Number";
            this.getLuckyNumButton.UseVisualStyleBackColor = false;
            this.getLuckyNumButton.Click += new System.EventHandler(this.getLuckyNumButton_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.SystemColors.Control;
            this.group.Controls.Add(this.getLuckyNumButton);
            this.group.Controls.Add(this.birthYearLabel);
            this.group.Controls.Add(this.birthMonthLabel);
            this.group.Controls.Add(this.favColorLabel);
            this.group.Controls.Add(this.birthDayLabel);
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(41, 41);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(324, 313);
            this.group.TabIndex = 10;
            this.group.TabStop = false;
            this.group.Text = "group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(421, 410);
            this.Controls.Add(this.favColorComboBox);
            this.Controls.Add(this.birthDayComboBox);
            this.Controls.Add(this.birthMonthComboBox);
            this.Controls.Add(this.birthYearComboBox);
            this.Controls.Add(this.group);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.ComboBox birthYearComboBox;
        private System.Windows.Forms.ComboBox birthMonthComboBox;
        private System.Windows.Forms.Label birthMonthLabel;
        private System.Windows.Forms.ComboBox birthDayComboBox;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.ComboBox favColorComboBox;
        private System.Windows.Forms.Label favColorLabel;
        private System.Windows.Forms.Button getLuckyNumButton;
        private System.Windows.Forms.GroupBox group;
    }
}

