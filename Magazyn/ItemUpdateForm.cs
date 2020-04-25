using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class ItemUpdateForm : Form
    {
        ProductModel model = new ProductModel();

        public ItemUpdateForm(int stockNumber)
        {
            InitializeComponent();
            model = DataAccess.GetModelByStockNumber(stockNumber);
            NameTextBox.Text = model.ProductName;
            LocationTextBox.Text = model.Location;
            QuantityTextBox.Text = model.Quantity.ToString();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (HelperMethods.InputValidator(NameTextBox.Text, QuantityTextBox.Text, LocationTextBox.Text))
            {

                model.ProductName = NameTextBox.Text;
                model.Quantity = int.Parse(QuantityTextBox.Text);
                model.Location = LocationTextBox.Text;

                DataAccess.UpdateItem(model);

                MessageBox.Show("Item has been updated", "Success", MessageBoxButtons.OK);

                this.Close();

            }
            else
            {
                MessageBox.Show("Please provide valid data -" +
                    " all 3 boxes mustn't be empty and quantity must be a whole positive number",
                    "Invalid Data",
                    MessageBoxButtons.OK);
            }
        }
    }
}
