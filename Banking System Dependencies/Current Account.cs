using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class Current_Account: Account
    {
        public Current_Account(double Amount)
        {
            this.amount = Amount;
        }
    }
}
