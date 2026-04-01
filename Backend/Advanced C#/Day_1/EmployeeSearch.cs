using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace Day_1
{
    public class EmployeeSearch
    {
        int[] NationalIDs;
        Employee[] Employees;
        public EmployeeSearch(Employee[] employees)
        {
            Employees = employees;
            NationalIDs = new int[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                NationalIDs[i] = employees[i].NationalId;
            }
        }
        /// <summary>
        /// Gets the employee associated with the specified national ID.
        /// </summary>
        /// <param name="nationalId">The national identification number of the employee to retrieve.</param>
        /// <returns>The employee with the specified national ID, or null if no such employee exists.</returns>
        public Employee? this[int nationalId]
        {
            get
            {
                for (int i = 0; i < NationalIDs.Length; i++)
                {
                    if (NationalIDs[i] == nationalId)
                    {
                        return Employees[i];
                    }
                }
                return null;
            }
        }
        /// <summary>
        /// gets a list of employees with the specified name. If no employees have the specified name,
        /// this indexer returns null.
        /// </summary>
        /// <param name="name">name that search with in the employee  </param>
        /// <returns>result will be list of employees who were the same name,or null if no such employee exists.</returns>
        public List<Employee?> this[string name]
        {
            get
            {
                List<Employee?> employeesWithName = new List<Employee?>();
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name == name)
                    {
                        employeesWithName.Add(Employees[i]);

                    }

                }
                if (employeesWithName.Count > 0)
                {
                    return employeesWithName;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets a list of employees who were hired on the specified date.
        /// </summary>
        /// <param name="hiringDate">The hiring date to match. Only employees whose hiring date matches this value will be included in the
        /// result.</param>
        /// <returns>A list of employees hired on the specified date, or null if no employees were hired on that date.</returns>
        public List<Employee?> this[DateHiring hiringDate]
        {

            get
            {
                List<Employee> allEmployeeAtHiringDate = new List<Employee>();
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].HiringDate.Day == hiringDate.Day &&
                        Employees[i].HiringDate.Month == hiringDate.Month &&
                        Employees[i].HiringDate.Year == hiringDate.Year)
                    {
                        allEmployeeAtHiringDate.Add(Employees[i]);
                    }
                }
                if (allEmployeeAtHiringDate.Count > 0)
                {
                    return allEmployeeAtHiringDate;
                }
                return null;
            }
        }

    }
}
