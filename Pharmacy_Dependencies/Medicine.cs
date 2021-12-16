using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Dependencies
{
    public class Medicine
    {
        public string name, ID;
        public int quantity, price;

        public void sellMedicine( int n)
        {
            quantity = quantity - n;
        }
        public string getInfo()
        {
            string info = ID + "    " + name + "    " + Convert.ToString(quantity);
            return info;
        }
    }
}
