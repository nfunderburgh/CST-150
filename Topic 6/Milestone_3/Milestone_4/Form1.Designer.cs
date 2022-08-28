namespace Milestone_3
{
    partial class LoginScreen
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
            this.usernameTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.AnimateReadOnly = false;
            this.usernameTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTextbox.Depth = 0;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextbox.HideSelection = true;
            this.usernameTextbox.Hint = "Username";
            this.usernameTextbox.LeadingIcon = null;
            this.usernameTextbox.Location = new System.Drawing.Point(58, 154);
            this.usernameTextbox.MaxLength = 32767;
            this.usernameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PrefixSuffixText = null;
            this.usernameTextbox.ReadOnly = false;
            this.usernameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.SelectionLength = 0;
            this.usernameTextbox.SelectionStart = 0;
            this.usernameTextbox.ShortcutsEnabled = true;
            this.usernameTextbox.Size = new System.Drawing.Size(250, 48);
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.TabStop = false;
            this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextbox.TrailingIcon = null;
            this.usernameTextbox.UseSystemPasswordChar = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.AnimateReadOnly = false;
            this.passwordTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextbox.Depth = 0;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextbox.HideSelection = true;
            this.passwordTextbox.Hint = "Password";
            this.passwordTextbox.LeadingIcon = null;
            this.passwordTextbox.Location = new System.Drawing.Point(58, 248);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '\0';
            this.passwordTextbox.PrefixSuffixText = null;
            this.passwordTextbox.ReadOnly = false;
            this.passwordTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(250, 48);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.TabStop = false;
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.TrailingIcon = null;
            this.passwordTextbox.UseSystemPasswordChar = false;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = false;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(58, 335);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(250, 48);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 usernameTextbox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextbox;
        private MaterialSkin.Controls.MaterialButton submitButton;
    }
}

