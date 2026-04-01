using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace task_8.Employee_Management
{
    internal class EmployeeManager
    {

        private List<Employee> hiredEmployee = new List<Employee>();
        private List<Employee> Employees;
        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public EmployeeManager(List<Employee> employees)
        {
            Employees = employees;
        }

        public void HireEmployee(Employee employee)
        {
            hiredEmployee.Add(employee);
        }
        public void FireEmployee(int employeeId)
        {
            foreach (var employee in Employees)
            {
                if (employee.Id == employeeId)
                { hiredEmployee.Remove(employee); }
            }
        }

        public void DisplayAllEmployees() { foreach (var emp in Employees) { Console.WriteLine(emp); } }

        public void DisplayAllHiredEmployees()
        {
            if (hiredEmployee.Count != 0)
            { 
                foreach (var emp in hiredEmployee) { Console.WriteLine(emp); }
            }
            else { Console.WriteLine("there are no hired employees"); }
        }
        public void GetDepartmentEmployees(String department)
        {
            foreach (var emp in hiredEmployee)
            {
                if (emp.Department == department)
                    Console.WriteLine(emp);
            }
        }
        public double TotalSalary()
        {
            int sum = 0;
            foreach (var emp in hiredEmployee) { sum +=(int) emp.Salary; }
            return (double)sum;
        }
    }
}
