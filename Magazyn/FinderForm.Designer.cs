namespace Magazyn
{
    partial class FinderForm
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
            this.ResulDataGridView = new System.Windows.Forms.DataGridView();
            this.AndRadioButton = new System.Windows.Forms.RadioButton();
            this.OrRadioButton = new System.Windows.Forms.RadioButton();
            this.Namelabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateSelectedbutton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ShowInventorybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResulDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResulDataGridView
            // 
            this.ResulDataGridView.AllowUserToAddRows = false;
            this.ResulDataGridView.AllowUserToDeleteRows = false;
            this.ResulDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResulDataGridView.Location = new System.Drawing.Point(190, 30);
            this.ResulDataGridView.MultiSelect = false;
            this.ResulDataGridView.Name = "ResulDataGridView";
            this.ResulDataGridView.ReadOnly = true;
            this.ResulDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResulDataGridView.Size = new System.Drawing.Size(578, 392);
            this.ResulDataGridView.TabIndex = 0;
            // 
            // AndRadioButton
            // 
            this.AndRadioButton.AutoSize = true;
            this.AndRadioButton.Checked = true;
            this.AndRadioButton.Location = new System.Drawing.Point(30, 93);
            this.AndRadioButton.Name = "AndRadioButton";
            this.AndRadioButton.Size = new System.Drawing.Size(43, 17);
            this.AndRadioButton.TabIndex = 1;
            this.AndRadioButton.TabStop = true;
            this.AndRadioButton.Text = "and";
            this.AndRadioButton.UseVisualStyleBackColor = true;
            // 
            // OrRadioButton
            // 
            this.OrRadioButton.AutoSize = true;
            this.OrRadioButton.Location = new System.Drawing.Point(30, 116);
            this.OrRadioButton.Name = "OrRadioButton";
            this.OrRadioButton.Size = new System.Drawing.Size(34, 17);
            this.OrRadioButton.TabIndex = 2;
            this.OrRadioButton.Text = "or";
            this.OrRadioButton.UseVisualStyleBackColor = true;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(27, 43);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(104, 18);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "Product Name";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(27, 142);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(65, 18);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Location";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(30, 64);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(127, 23);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(30, 163);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(127, 23);
            this.LocationTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(30, 192);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateSelectedbutton
            // 
            this.UpdateSelectedbutton.Location = new System.Drawing.Point(30, 246);
            this.UpdateSelectedbutton.Name = "UpdateSelectedbutton";
            this.UpdateSelectedbutton.Size = new System.Drawing.Size(127, 23);
            this.UpdateSelectedbutton.TabIndex = 9;
            this.UpdateSelectedbutton.Text = "Update Selected";
            this.UpdateSelectedbutton.UseVisualStyleBackColor = true;
            this.UpdateSelectedbutton.Click += new System.EventHandler(this.UpdateSelectedbutton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Location = new System.Drawing.Point(30, 275);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteSelectedButton.TabIndex = 10;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(30, 319);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(127, 23);
            this.AddItemButton.TabIndex = 11;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ShowInventorybutton
            // 
            this.ShowInventorybutton.Location = new System.Drawing.Point(30, 348);
            this.ShowInventorybutton.Name = "ShowInventorybutton";
            this.ShowInventorybutton.Size = new System.Drawing.Size(127, 25);
            this.ShowInventorybutton.TabIndex = 12;
            this.ShowInventorybutton.Text = "Show Inventory";
            this.ShowInventorybutton.UseVisualStyleBackColor = true;
            this.ShowInventorybutton.Click += new System.EventHandler(this.ShowInventorybutton_Click);
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowInventorybutton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.UpdateSelectedbutton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OrRadioButton);
            this.Controls.Add(this.AndRadioButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.ResulDataGridView);
            this.Name = "FinderForm";
            this.Text = "FinderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResulDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResulDataGridView;
        private System.Windows.Forms.RadioButton AndRadioButton;
        private System.Windows.Forms.RadioButton OrRadioButton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateSelectedbutton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button ShowInventorybutton;
    }
}