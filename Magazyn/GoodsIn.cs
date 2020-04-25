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
    public partial class GoodsIn : Form
    {
                
        public GoodsIn()
        {
            InitializeComponent();            
        }

        
        private void GoodsIn_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (HelperMethods.InputValidator(NameTextBox.Text, QuantityTextBox.Text, LocationTextBox.Text))
            {
                List<ProductModel> listOfProd = DataAccess.CovertStringList2ProductList(DataAccess.LoodFromFile());
                ProductModel model = new ProductModel();
                model.ProductName = NameTextBox.Text;
                model.Quantity = int.Parse(QuantityTextBox.Text);
                model.Location = LocationTextBox.Text;
                model.GoodsInDate = DateTime.Now.ToString("MM/dd/yyyy");
                
                listOfProd.Add(model);
                                
                DataAccess.SaveToFile(model);

                MessageBox.Show("Item has been saved","Success", MessageBoxButtons.OK);

                NameTextBox.Text = "";
                LocationTextBox.Text = "";
                QuantityTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Please provide valid data -" +
                    " all 3 boxes mustn't be empty and quantity must be a whole positive number",
                    "Invalid Data",
                    MessageBoxButtons.OK);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
