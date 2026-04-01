using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Employee_Management
{
    internal partial class Employee
    {
        public decimal CalculateBonus(double percentage) {
            double p=percentage/100;
            return Salary*(decimal)p;
        }
        public void GiveSalaryRaise(double amount)
        {
            Salary += (decimal)amount;
        }

        public override string? ToString()
        {
            return $"Id: {this.Id }\nFull_Name: {this.FullName}\nEmail: {this.Email}\nSalary: {this.Salary}$\n";
            ;
        }
        public string SendEamil(string? subject,string? body,string? reciever) { 
            
            return
                $"""
                            sender: {this.Email}           reciever: {reciever}

                                            
                                            subject: {subject}
                                
                                body:
                                     {body}
                """; }
    }
}
