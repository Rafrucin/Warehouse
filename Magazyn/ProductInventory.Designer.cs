namespace Magazyn
{
    partial class ProductInventory
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
            this.DataGridAway = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAway)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAway
            // 
            this.DataGridAway.AllowUserToAddRows = false;
            this.DataGridAway.AllowUserToDeleteRows = false;
            this.DataGridAway.AllowUserToOrderColumns = true;
            this.DataGridAway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAway.Location = new System.Drawing.Point(12, 23);
            this.DataGridAway.Name = "DataGridAway";
            this.DataGridAway.ReadOnly = true;
            this.DataGridAway.Size = new System.Drawing.Size(776, 415);
            this.DataGridAway.TabIndex = 0;
            // 
            // ProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridAway);
            this.Name = "ProductInventory";
            this.Text = "ProductInventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductInventory_FormClosed);
            this.Load += new System.EventHandler(this.ProductInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAway)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAway;
    }
}