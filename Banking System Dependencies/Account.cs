using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class Account
    {
        public string Acc_name, Acc_no, trans_his;
        public double amount;

        public virtual void depositAmount(double Amount, string date)
        {
            amount = Amount + amount;
            trans_his = trans_his + Amount + " Depositted on " + date;
        }
        public virtual void withdrawAmount(double Amount, string date)
        {
            amount = amount - Amount;
            trans_his = trans_his + Amount + " Withdrawn on " + date;
        }
        public virtual string getAccountDetails()
        {
            return Acc_name +"\t" + Convert.ToString(amount);
        }
        public string transHis()
        {
            return trans_his;
        }
    }
}
