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
    public partial class FinderForm : Form
    {
        List<ProductModel> models = new List<ProductModel>();


        public FinderForm()
        {
            InitializeComponent();
            models = DataAccess.GetModelsFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            GridBoxUpdate(SearchLogic());
        }


        private void GridBoxUpdate(List<ProductModel> models)
        {
            var resultList = models.Select(o => new { o.StockNumber, o.ProductName, o.Quantity, o.Location, o.GoodsInDate }).ToList();
            var binds = new BindingSource(resultList, null);
            ResulDataGridView.DataSource = binds;
        }

        private List<ProductModel> SearchLogic ()
        {
            bool AndRadio = AndRadioButton.Checked;
            int ProdVal = ProductNameTextBox.Text.Length;
            int LocVal = LocationTextBox.Text.Length;
            List<ProductModel> output = new List<ProductModel>();

            if (ProdVal == 0 && LocVal == 0)
            {
                return output;
            }
            else if (ProdVal > 0 && LocVal == 0)
            {
                return FindByProduct(models);
            }
            else if (ProdVal == 0 && LocVal > 0)
            {
                return FindByLocation(models);
            }
            else
            {
                if (AndRadio == true)
                {
                    return FindByLocation(FindByProduct(models));
                }
                else
                {
                    //total = loc + prods - commons
                    output = FindByLocation(models);
                    var prods = FindByProduct(models);
                    var commons = FindByProduct(FindByLocation(models));
                    foreach (var item in prods)
                    {
                        output.Add(item);
                    }

                    foreach (var item in commons)
                    {
                        output.Remove(item);                        
                    }

                    return output;
                }
            }

        }



        private List<ProductModel> FindByProduct(List<ProductModel> models)
        {
            List<ProductModel> output = new List<ProductModel>();
            if (ProductNameTextBox.Text!=null)
            {
                output = models.Where(x => x.ProductName == ProductNameTextBox.Text).ToList();
                return output;
            }
            return output;

        }

        private List<ProductModel> FindByLocation(List<ProductModel> models)
        {
            List<ProductModel> output = new List<ProductModel>();
            if (LocationTextBox.Text != null)
            {
                output = models.Where(x => x.Location == LocationTextBox.Text).ToList();
                return output;
            }
            return output;

        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (ResulDataGridView.Rows.Count==0)
            {
                return;
            }

            int stockNumber =(int)ResulDataGridView.SelectedRows[0].Cells[0].Value;
            
            if (stockNumber!=0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to remove selected item permanently?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.DeleteItem(stockNumber);
                    models = DataAccess.GetModelsFromFile();
                    GridBoxUpdate(SearchLogic());

                }
                
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            GoodsIn frm = new GoodsIn();
            frm.ShowDialog(this);
                       
            models = DataAccess.GetModelsFromFile();
            GridBoxUpdate(SearchLogic());
        }

        private void UpdateSelectedbutton_Click(object sender, EventArgs e)
        {
            if (ResulDataGridView.Rows.Count == 0)
            {
                return;
            }

            int stockNumber = (int)ResulDataGridView.SelectedRows[0].Cells[0].Value;
            
            ItemUpdateForm frm = new ItemUpdateForm(stockNumber);
            frm.ShowDialog(this);
                        
            models = DataAccess.GetModelsFromFile();
            GridBoxUpdate(SearchLogic());
        }

        private void ShowInventorybutton_Click(object sender, EventArgs e)
        {
            ProductInventory frm = new ProductInventory();
            frm.ShowDialog(this);
        }
    }
}
