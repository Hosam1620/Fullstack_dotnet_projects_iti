using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Emergency;
using task_8.Hospital_Management_System.Interfaces;

namespace task_8.Hospital_Management_System.Staff
{
    public class Nurse:MedicalStaff,IPayroll,IEmergencyResponder
    {
        public decimal HourlyRate { get; }
        public int MonthlyHours { get; private set; } // can be set by system

        public Nurse(int staffId, string name, string department, decimal hourlyRate, int monthlyHours)
            : base(staffId, name, department)
        {
            HourlyRate = hourlyRate;
            MonthlyHours = monthlyHours;
        }

        public override string JobTitle => "Nurse";

        public void RespondToEmergency(EmergencyCase emergency)
        {
            Console.WriteLine($"Nurse: {Name} stabilizing patient {emergency.Patient.FullName} \nSeverity: {emergency.SeverityCase})");
        }

        public decimal CalculateMonthlyPay()
        {
            return HourlyRate * MonthlyHours;
        }
    }
}
