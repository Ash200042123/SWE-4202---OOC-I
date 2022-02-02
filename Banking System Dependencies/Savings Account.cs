using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class Savings_Account: Account
    {
        public Savings_Account(double Amount)
        {
            this.amount = Amount;
        }
        public override void withdrawAmount(double Amount,string date)
        {
            Amount = amount - Amount-15;
            trans_his = Amount + "\t Withdrawn on \t" + date + "\n";
        }
    }
}
