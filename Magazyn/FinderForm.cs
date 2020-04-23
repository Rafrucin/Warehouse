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

        //var bindingList = new BindingList<ProductModel>(listOfProd);
        //var source = new BindingSource(bindingList, null);
        //DataGrid.DataSource = source;"
        //var reduceList = listOfProd.Select(o => new { o.ProductName, o.Quantity, o.Location }).ToList();
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
    }
}
