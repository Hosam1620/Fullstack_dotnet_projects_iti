using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace task_8.Shoping
{
    internal class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public override string GetTransactionDetails()
        {
            return $"Transaction Id: {TransactionId}\n";
        }

        public override bool ProcessPayment()
        {
            string checkCardNumber = @"^(?:\d{13,19})$";
            string checkCVV = @"^(?:\d{3,4})$";


            return Regex.IsMatch(CardNumber, checkCardNumber) && Regex.IsMatch(CVV, checkCVV)&&ExpiryDate.Year>DateTime.Now.Year;
        }
    }
}
