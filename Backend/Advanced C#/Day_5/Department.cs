using Day_5;
using System;
using System.Collections.Generic;

public class Department
{
    public int DeptID { get; set; }

    public string? DeptName { get; set; }

    List<Employee> Staff = new List<Employee>();

    public void AddStaff(Employee E)
    {
        Staff.Add(E);

        E.EmployeeLayOff += RemoveStaff!;
    }

    public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
    {
        Employee? emp = sender as Employee;

        if (emp != null)
        {
            Staff.Remove(emp);

            emp.EmployeeLayOff -= RemoveStaff!;

            Console.WriteLine($"Employee {emp.EmployeeID} removed from Department because {e.Cause}");
        }
    }
}