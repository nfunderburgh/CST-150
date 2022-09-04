namespace Milestone_3
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
            this.addNewButton = new MaterialSkin.Controls.MaterialButton();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.resetButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.itemManagerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemStockLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemIDTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.itemNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.itemPriceTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.itemStockTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.IDs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.listViewCopy = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.AutoSize = false;
            this.addNewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addNewButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addNewButton.Depth = 0;
            this.addNewButton.HighEmphasis = true;
            this.addNewButton.Icon = null;
            this.addNewButton.Location = new System.Drawing.Point(44, 81);
            this.addNewButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addNewButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addNewButton.Size = new System.Drawing.Size(139, 39);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New";
            this.addNewButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addNewButton.UseAccentColor = false;
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = false;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(44, 132);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(139, 39);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = false;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetButton.Depth = 0;
            this.resetButton.HighEmphasis = true;
            this.resetButton.Icon = null;
            this.resetButton.Location = new System.Drawing.Point(44, 183);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetButton.Name = "resetButton";
            this.resetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetButton.Size = new System.Drawing.Size(139, 39);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetButton.UseAccentColor = false;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(44, 234);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(139, 39);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(44, 285);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(139, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // itemManagerLabel
            // 
            this.itemManagerLabel.AutoSize = true;
            this.itemManagerLabel.Depth = 0;
            this.itemManagerLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.itemManagerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.itemManagerLabel.Location = new System.Drawing.Point(213, 81);
            this.itemManagerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemManagerLabel.Name = "itemManagerLabel";
            this.itemManagerLabel.Size = new System.Drawing.Size(213, 41);
            this.itemManagerLabel.TabIndex = 6;
            this.itemManagerLabel.Text = "Item Manager";
            // 
            // itemIDLabel
            // 
            this.itemIDLabel.AutoSize = true;
            this.itemIDLabel.Depth = 0;
            this.itemIDLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.itemIDLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.itemIDLabel.Location = new System.Drawing.Point(215, 142);
            this.itemIDLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemIDLabel.Name = "itemIDLabel";
            this.itemIDLabel.Size = new System.Drawing.Size(85, 29);
            this.itemIDLabel.TabIndex = 7;
            this.itemIDLabel.Text = "Item ID:";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Depth = 0;
            this.itemNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.itemNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.itemNameLabel.Location = new System.Drawing.Point(215, 193);
            this.itemNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(126, 29);
            this.itemNameLabel.TabIndex = 8;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Depth = 0;
            this.itemPriceLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.itemPriceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.itemPriceLabel.Location = new System.Drawing.Point(215, 244);
            this.itemPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(111, 29);
            this.itemPriceLabel.TabIndex = 9;
            this.itemPriceLabel.Text = "Item Price";
            // 
            // itemStockLabel
            // 
            this.itemStockLabel.AutoSize = true;
            this.itemStockLabel.Depth = 0;
            this.itemStockLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.itemStockLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.itemStockLabel.Location = new System.Drawing.Point(215, 295);
            this.itemStockLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemStockLabel.Name = "itemStockLabel";
            this.itemStockLabel.Size = new System.Drawing.Size(123, 29);
            this.itemStockLabel.TabIndex = 10;
            this.itemStockLabel.Text = "Item Stock:";
            // 
            // itemIDTextbox
            // 
            this.itemIDTextbox.AcceptsTab = true;
            this.itemIDTextbox.AnimateReadOnly = false;
            this.itemIDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemIDTextbox.Depth = 0;
            this.itemIDTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemIDTextbox.LeadingIcon = null;
            this.itemIDTextbox.Location = new System.Drawing.Point(401, 142);
            this.itemIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemIDTextbox.MaxLength = 50;
            this.itemIDTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemIDTextbox.Multiline = false;
            this.itemIDTextbox.Name = "itemIDTextbox";
            this.itemIDTextbox.Size = new System.Drawing.Size(139, 36);
            this.itemIDTextbox.TabIndex = 11;
            this.itemIDTextbox.Text = "";
            this.itemIDTextbox.TrailingIcon = null;
            this.itemIDTextbox.UseTallSize = false;
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.AcceptsTab = true;
            this.itemNameTextbox.AnimateReadOnly = false;
            this.itemNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemNameTextbox.Depth = 0;
            this.itemNameTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemNameTextbox.LeadingIcon = null;
            this.itemNameTextbox.Location = new System.Drawing.Point(401, 193);
            this.itemNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameTextbox.MaxLength = 50;
            this.itemNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemNameTextbox.Multiline = false;
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(139, 36);
            this.itemNameTextbox.TabIndex = 12;
            this.itemNameTextbox.Text = "";
            this.itemNameTextbox.TrailingIcon = null;
            this.itemNameTextbox.UseTallSize = false;
            // 
            // itemPriceTextbox
            // 
            this.itemPriceTextbox.AcceptsTab = true;
            this.itemPriceTextbox.AnimateReadOnly = false;
            this.itemPriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemPriceTextbox.Depth = 0;
            this.itemPriceTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemPriceTextbox.LeadingIcon = null;
            this.itemPriceTextbox.Location = new System.Drawing.Point(401, 244);
            this.itemPriceTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemPriceTextbox.MaxLength = 50;
            this.itemPriceTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemPriceTextbox.Multiline = false;
            this.itemPriceTextbox.Name = "itemPriceTextbox";
            this.itemPriceTextbox.Size = new System.Drawing.Size(139, 36);
            this.itemPriceTextbox.TabIndex = 13;
            this.itemPriceTextbox.Text = "";
            this.itemPriceTextbox.TrailingIcon = null;
            this.itemPriceTextbox.UseTallSize = false;
            // 
            // itemStockTextbox
            // 
            this.itemStockTextbox.AcceptsTab = true;
            this.itemStockTextbox.AnimateReadOnly = false;
            this.itemStockTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemStockTextbox.Depth = 0;
            this.itemStockTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemStockTextbox.LeadingIcon = null;
            this.itemStockTextbox.Location = new System.Drawing.Point(401, 295);
            this.itemStockTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemStockTextbox.MaxLength = 50;
            this.itemStockTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemStockTextbox.Multiline = false;
            this.itemStockTextbox.Name = "itemStockTextbox";
            this.itemStockTextbox.Size = new System.Drawing.Size(139, 36);
            this.itemStockTextbox.TabIndex = 14;
            this.itemStockTextbox.Text = "";
            this.itemStockTextbox.TrailingIcon = null;
            this.itemStockTextbox.UseTallSize = false;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDs,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(44, 423);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(544, 177);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // IDs
            // 
            this.IDs.Text = "ID";
            this.IDs.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.Width = 90;
            // 
            // searchTextbox
            // 
            this.searchTextbox.AcceptsTab = true;
            this.searchTextbox.AnimateReadOnly = false;
            this.searchTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextbox.Depth = 0;
            this.searchTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextbox.Hint = "Search...";
            this.searchTextbox.LeadingIcon = null;
            this.searchTextbox.Location = new System.Drawing.Point(44, 372);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextbox.MaxLength = 50;
            this.searchTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(201, 36);
            this.searchTextbox.TabIndex = 17;
            this.searchTextbox.Text = "";
            this.searchTextbox.TrailingIcon = null;
            this.searchTextbox.UseTallSize = false;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // listViewCopy
            // 
            this.listViewCopy.BackColor = System.Drawing.Color.White;
            this.listViewCopy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCopy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewCopy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewCopy.FullRowSelect = true;
            this.listViewCopy.GridLines = true;
            this.listViewCopy.HideSelection = false;
            this.listViewCopy.Location = new System.Drawing.Point(44, 423);
            this.listViewCopy.MultiSelect = false;
            this.listViewCopy.Name = "listViewCopy";
            this.listViewCopy.Size = new System.Drawing.Size(544, 177);
            this.listViewCopy.TabIndex = 18;
            this.listViewCopy.UseCompatibleStateImageBehavior = false;
            this.listViewCopy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Stock";
            this.columnHeader7.Width = 90;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 673);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.itemStockTextbox);
            this.Controls.Add(this.itemPriceTextbox);
            this.Controls.Add(this.itemNameTextbox);
            this.Controls.Add(this.itemIDTextbox);
            this.Controls.Add(this.itemStockLabel);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemIDLabel);
            this.Controls.Add(this.itemManagerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.listViewCopy);
            this.Name = "Form2";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton addNewButton;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton resetButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialLabel itemManagerLabel;
        private MaterialSkin.Controls.MaterialLabel itemIDLabel;
        private MaterialSkin.Controls.MaterialLabel itemNameLabel;
        private MaterialSkin.Controls.MaterialLabel itemPriceLabel;
        private MaterialSkin.Controls.MaterialLabel itemStockLabel;
        private MaterialSkin.Controls.MaterialTextBox itemIDTextbox;
        private MaterialSkin.Controls.MaterialTextBox itemNameTextbox;
        private MaterialSkin.Controls.MaterialTextBox itemPriceTextbox;
        private MaterialSkin.Controls.MaterialTextBox itemStockTextbox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader IDs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTextBox searchTextbox;
        private System.Windows.Forms.ListView listViewCopy;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}