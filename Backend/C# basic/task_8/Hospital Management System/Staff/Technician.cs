using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Interfaces;

namespace task_8.Hospital_Management_System.Staff
{
    public class Technician : MedicalStaff, IPayroll
    {

        public decimal MonthlySalary { get; }

        public Technician(int staffId, string name, string department, decimal monthlySalary)
            : base(staffId, name, department)
        {
            MonthlySalary = monthlySalary;
        }

        public override string JobTitle => "Technician";

        public decimal CalculateMonthlyPay()
        {
            return MonthlySalary;
        }
    }
}
