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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResulDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResulDataGridView
            // 
            this.ResulDataGridView.AllowUserToAddRows = false;
            this.ResulDataGridView.AllowUserToDeleteRows = false;
            this.ResulDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResulDataGridView.Location = new System.Drawing.Point(229, 67);
            this.ResulDataGridView.Name = "ResulDataGridView";
            this.ResulDataGridView.ReadOnly = true;
            this.ResulDataGridView.Size = new System.Drawing.Size(487, 310);
            this.ResulDataGridView.TabIndex = 0;
            // 
            // AndRadioButton
            // 
            this.AndRadioButton.AutoSize = true;
            this.AndRadioButton.Checked = true;
            this.AndRadioButton.Location = new System.Drawing.Point(61, 128);
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
            this.OrRadioButton.Location = new System.Drawing.Point(61, 151);
            this.OrRadioButton.Name = "OrRadioButton";
            this.OrRadioButton.Size = new System.Drawing.Size(34, 17);
            this.OrRadioButton.TabIndex = 2;
            this.OrRadioButton.TabStop = true;
            this.OrRadioButton.Text = "or";
            this.OrRadioButton.UseVisualStyleBackColor = true;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(57, 65);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(131, 24);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "Product Name";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(57, 171);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(81, 24);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Location";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(61, 99);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(127, 23);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(61, 198);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(127, 23);
            this.LocationTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}