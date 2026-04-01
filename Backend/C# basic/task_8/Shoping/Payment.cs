using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Shoping
{
    internal abstract class Payment
    {
        public decimal Amount { get; set; }
        public string? TransactionId {  get; set; }
        public DateTime DateTime { get; set; }

        public abstract bool ProcessPayment();
        public abstract string GetTransactionDetails();
        public void GenerateReceipt() { Console.WriteLine($"you should pay: {this.Amount}\nTransaction Id: {this.TransactionId}\nDate: {this.DateTime}"); }
    }
}
