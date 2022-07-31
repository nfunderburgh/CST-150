namespace HelloWorld
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
            this.ClickThisButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickThisButton
            // 
            this.ClickThisButton.Location = new System.Drawing.Point(331, 247);
            this.ClickThisButton.Name = "ClickThisButton";
            this.ClickThisButton.Size = new System.Drawing.Size(100, 23);
            this.ClickThisButton.TabIndex = 0;
            this.ClickThisButton.Text = "Click this";
            this.ClickThisButton.UseVisualStyleBackColor = true;
            this.ClickThisButton.Click += new System.EventHandler(this.buttonToTextBoxOutput);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(284, 200);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(206, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(457, 251);
            this.checkBox.Name = "checkBox1";
            this.checkBox.Size = new System.Drawing.Size(74, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "checkBox";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBoxToTextBoxOutput);
            // 
            // radioButton1
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(218, 253);
            this.radioButton.Name = "radioButton1";
            this.radioButton.Size = new System.Drawing.Size(79, 17);
            this.radioButton.TabIndex = 3;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "radioButton";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButtonToTextBoxOutput);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(554, 250);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimeToTextBoxOutput);
            // 
            // label1
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(155, 255);
            this.label.Name = "label1";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 5;
            this.label.Text = "label";
            this.label.Click += new System.EventHandler(this.labelToTextBoxOutput);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.ClickThisButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickThisButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label;
    }
}

