using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    /// <summary>
    /// represents an employee with properties 
    /// such as Id, Salary, SecurityLevel, Hiring date 
    /// and Gender.
    /// implements the IComparable interface 
    /// to allow for sorting based on the hiring date.
    /// </summary>
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NationalId { get; set; }
        public decimal Salary { get; set; }
        /// <summary>
        /// is an enumeration that defines different security privileges for employees.
        /// which allows for multiple privileges to be assigned to a single 
        /// employee by combining the values using bitwise operations.
        /// </summary>
        public SecurityPrivileges SecurityLevel { get; set; }
        public DateHiring? HiringDate { get; set; }
        /// <summary>
        /// is an enumeration that defines different types of gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// this is the implementation of the CompareTo method from the IComparable interface.
        /// to compare the current employee object with another object based on their hiring date.
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>int</returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Employee otherEmployee = obj as Employee;
            if (otherEmployee != null)
            {
                if (this.HiringDate.Year > otherEmployee.HiringDate.Year)
                    return 1;
                else if (this.HiringDate.Year == otherEmployee.HiringDate.Year)
                {
                    if (this.HiringDate.Month > otherEmployee.HiringDate.Month)
                        return 1;
                    else if (this.HiringDate.Month == otherEmployee.HiringDate.Month)
                    {
                        if (this.HiringDate.Day > otherEmployee.HiringDate.Day)
                            return 1;
                        else if (this.HiringDate.Day == otherEmployee.HiringDate.Day)
                            return 0;
                        else
                            return -1;
                    }
                    else
                        return -1;
                }

                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not an Employee");
        }
        /// <summary>
        /// this is an override of the ToString method to provide a string representation of the employee object.
        /// 
        /// </summary>
        /// <returns>string</returns>
        override public string ToString()
        {
            return $" Id: {Id}\n Salary: {Salary:c}\nGender: ${Gender}\n Security Level: {SecurityLevel} \n Hiring Date: {HiringDate.ToString()}\n";


        }
    }
}
