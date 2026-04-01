using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    struct BankAccount
    {
        public string AccountNumber
        {
            get; set
            {
                if (value.Length == 10)
                {
                    field = value;
                }


            }
        }
        public double Balance
        {
            set;
            get;
        }
        public string Deposit(double amount)
        {
            if (amount > 0) Balance += amount;
            return $"your balance is: {Balance}";
        }
        public string WithDrow(double amount)
        {
            if (amount > 0 && Balance > 0)
            {
                Balance = Balance - amount;
                return $" you withdraw:{amount}\n your Balace is: {Balance}";
            }
            return $"can't be withdraw cause you balace is:{Balance}";
        }
    }
}
