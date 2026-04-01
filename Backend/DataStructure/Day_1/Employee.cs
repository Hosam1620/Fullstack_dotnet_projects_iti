using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Employee
    {
        public int ID;
        public int Age;
        public decimal Salary;
        public string DepartmentName;

        public Employee(int id, int age, decimal salary, string department)
        {
            ID = id;
            Age = age;
            Salary = salary;
            DepartmentName = department;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Age: {Age}, Salary: {Salary}, Department: {DepartmentName}";
        }
    }
}
