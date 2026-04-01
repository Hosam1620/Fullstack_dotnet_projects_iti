using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class BankAccount
    {
        public string? AccountNumber
        {
            get;
            private set
            {
                if (value!.Length == 10)
                {
                    field = value;
                }


            }
        }
        private double balance;
        protected double Balance
        {
            set { balance = value; }
            get { return balance; }
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
