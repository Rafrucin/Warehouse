using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public static class Logger
    {
        private static string fileName = "Logger.txt";
        private static string filePath = AppDomain.CurrentDomain.BaseDirectory;


        private static List<string> LoodLogsFromFile()
        {
            List<string> output = new List<string>();

            if (!File.Exists(FullPath()))
            {
                return output;
            }
            return File.ReadAllLines(FullPath()).ToList();

        }

        private static string FullPath()
        {
            string output = $"{filePath}\\{fileName}";
            return output;
        }

        public static void LogReceiver (ProductModel model, string action)
        {
            string log = $"{ model.StockNumber }, { action }, { DateTime.Now.ToShortDateString() }";
            var logs = LoodLogsFromFile();
            logs.Add(log);
            File.WriteAllLines(FullPath(), logs);
        }
    }
}
