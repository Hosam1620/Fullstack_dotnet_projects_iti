using Day_5;
using System;
using System.Collections.Generic;

public class Club
{
    public int ClubID { get; set; }

    public string? ClubName { get; set; }

    List<Employee> Members = new List<Employee>();

    public void AddMember(Employee E)
    {
        Members.Add(E);

        E.EmployeeLayOff += RemoveMember!;
    }

    public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
    {
        Employee? emp = sender as Employee;

        if (emp != null && e.Cause == LayOffCause.VacationStockNegative)
        {
            Members.Remove(emp);

            emp.EmployeeLayOff -= RemoveMember!;

            Console.WriteLine($"Employee {emp.EmployeeID} removed from Club");
        }
    }
}