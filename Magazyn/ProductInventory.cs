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
    public partial class ProductInventory : Form
    {
        private List<ProductModel> listOfProd = DataAccess.GetModelsFromFile(); 

        public ProductInventory()
        {
            InitializeComponent();
            InitGrid();

        }

        private void InitGrid()
        {
            var reduceList = listOfProd.Select(o => new { o.StockNumber, o.ProductName, o.Quantity, o.Location, o.GoodsInDate }).ToList();
            DataGridAway.DataSource = reduceList;
        }

        private void ProductInventory_Load(object sender, EventArgs e)
        {

        }

        private void ProductInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
