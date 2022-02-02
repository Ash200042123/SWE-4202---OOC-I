using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class Loan_Account: Account
    {
        public Loan_Account(double Amount)
        {
            this.amount = Amount*0.9;
        }
        public override void depositAmount(double Amount, string date)
        {
            amount = amount-Amount;
            trans_his = trans_his + Amount + " Depositted on " + date;

        }
        public override void withdrawAmount(double Amount, string date)
        {

            amount = amount + (Amount*0.9);
            trans_his = trans_his + Amount + " Borrowed on " + date;

        }
        
    }
}
