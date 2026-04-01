using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace task_8.Shoping
{
    internal class PayPalPayment : Payment
    {
        public string Email {  get; set; }
        public string PaypalTransactionId { get; set; }
        public override string GetTransactionDetails()
        {
            return $"Transaction Id: {PaypalTransactionId}\n";
        }

        public override bool ProcessPayment()
        {
            string checkEmail = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            
            return Regex.IsMatch(Email,checkEmail) ;
        }
    }
}
