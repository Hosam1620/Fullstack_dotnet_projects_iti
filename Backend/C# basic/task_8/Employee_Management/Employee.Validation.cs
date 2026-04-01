using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace task_8.Employee_Management
{
    internal partial class Employee
    {
        private bool ValidateOnEmail()
        {

            if (this.Email == null)
                return false;

            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            return Regex.IsMatch(this.Email, pattern);
        }

        public bool IsValidEmployee()
        {
            return FirstName != null && LastName != null && Salary > 0&& ValidateOnEmail()==true&&Department!=null;
        }
        public void LogActivity(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}\n");
        }
    }
}