using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Dependencies
{
    public class User
    {
        public string ID;
        public int balance;

        public void addBalance(int n, int price)
        {
            int increase = n * price;
            balance = balance + increase;
        }
        public string getBalance()
        {
            return Convert.ToString(balance);
        }
    }
}
