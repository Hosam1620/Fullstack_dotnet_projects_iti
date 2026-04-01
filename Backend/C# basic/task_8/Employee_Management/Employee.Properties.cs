using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Employee_Management
{
    internal partial class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Department {  get; set; }
        public decimal Salary { get; private set; }
        public string? FullName { get {  return FirstName+" "+LastName; }  }

        public Employee(int id, string? firstName, string? lastName, string? email, string? department, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            Salary = salary;
        }
    }
}
