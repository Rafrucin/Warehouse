using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Magazyn
{
    public class HelperMethods
    {
        

        public static bool InputValidator(string name, string quantity, string location)
        {
            int q = 0;
            bool acceptableQuantity = int.TryParse(quantity, out q);
            if (!acceptableQuantity)
            {
                return false;
            }
            if (int.Parse(quantity)<=0 || name==null || location==null)
            {
                return false;
            }

            return true;
        }

       

    }
}
