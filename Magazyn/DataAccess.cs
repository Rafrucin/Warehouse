using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public static class DataAccess
    {

        private static string fileName = "inventory.txt";
        private static string filePath = AppDomain.CurrentDomain.BaseDirectory;       


        public static List<string> LoodFromFile()
        {
            List<string> output = new List<string>();

            if (!File.Exists(FullPath()))
            {
                return output;
            }
            return File.ReadAllLines(FullPath()).ToList();
        }

        public static List<ProductModel> CovertStringList2ProductList (List<string> lines)
        {
            List<ProductModel> output = new List<ProductModel>();

            foreach (var line in lines)
            {
                output.Add(line.ConvertToModel());
            }
            return output;
        }

        public static void  SaveToFile(ProductModel model)
        {
            // load - convert - add - conver - save
            List<ProductModel> models = new List<ProductModel>();
            models = CovertStringList2ProductList(LoodFromFile());
            if (models.Count == 0)
            {
                model.StockNumber = 1;
            }
            else
            {
                model.StockNumber = models.OrderByDescending(x => x.StockNumber).First().StockNumber+1;
            }                
            
            models.Add(model);
            List<string> output = ConvertProductList2StringList(models);
            File.WriteAllLines(FullPath(), output);
            Logger.LogReceiver(model, "Item created");
        }

        public static List<ProductModel> GetModelsFromFile()
        {
            List<ProductModel> output = new List<ProductModel>();
            output = CovertStringList2ProductList(LoodFromFile());
            return output;
        }

        public static List<string> ConvertProductList2StringList(List<ProductModel> models)
        {
            List<string> output = new List<string>();
            foreach (var model in models)
            {
                output.Add(ConvertToString(model));
            }
            return output;
        }

        private static string FullPath ()
        {
            string output = $"{filePath}\\{fileName}";
            return output;
        }

        public static string ConvertToString(ProductModel model)
        {
            string output = "";
            output = $"{model.StockNumber},{model.ProductName},{model.Quantity},{model.Location},{model.GoodsInDate}";
            return output;

        }

        public static ProductModel ConvertToModel(this string str)
        {
            ProductModel model = new ProductModel();
            string[] cols = str.Split(',');
            if (cols.Length == 0)
            {
                return model;
            }
            model.StockNumber = int.Parse(cols[0]);
            model.ProductName = cols[1];
            model.Quantity = int.Parse(cols[2]);
            model.Location = cols[3];
            model.GoodsInDate = cols[4];
            return model;
        }

        public static void DeleteItem(int stockNumber)
        {
            List<ProductModel> models = GetModelsFromFile();
            ProductModel toBeRemoved = models.Where(x => x.StockNumber == stockNumber).First();
            models.Remove(toBeRemoved);
            List<string> output = ConvertProductList2StringList(models);
            File.WriteAllLines(FullPath(), output);
            Logger.LogReceiver(toBeRemoved, "Item deleted");
        }

        public static void UpdateItem(ProductModel model)
        {
            List<ProductModel> models = GetModelsFromFile();
            ProductModel toBeRemoved = models.Where(x => x.StockNumber == model.StockNumber).First();
            models.Remove(toBeRemoved);
            models.Add(model);
            List<string> output = ConvertProductList2StringList(models);
            File.WriteAllLines(FullPath(), output);
            Logger.LogReceiver(model, "Item updated");
        }

        public static ProductModel GetModelByStockNumber (int stocknumber)
        {
            List<ProductModel> models = GetModelsFromFile();
            ProductModel output = models.Where(x => x.StockNumber == stocknumber).First();
            return output;
        }
    
    }
}
