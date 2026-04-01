using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace task_8.Shoping
{
    internal class CashOnDelivery : Payment
    {
        public string DeliveryAddress { get; set; }
        public string ContactNumber { get; set; }
        public override string GetTransactionDetails()
        {
            return $"Transaction Id: {base.TransactionId}\n";
        }

        public override bool ProcessPayment()
        {
            string checkphone = @"^(?:\+20|0)?1[0125]\d{8}$";
            string checkAddress = @"^[A-Za-z0-9\s,.-/#]{5,100}$";
            return Regex.IsMatch(ContactNumber,checkphone)&&Regex.IsMatch(DeliveryAddress,checkAddress);
        }
    }
}
