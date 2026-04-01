using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class SavingAccount : BankAccount
    {
        public double GetBalance { get { return base.Balance; }  }

    }
}
