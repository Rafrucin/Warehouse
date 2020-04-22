using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public class ProductModel : IProductModel
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public string GoodsInDate { get; set; }
        public int StockNumber { get; set; }
       

    }
}
