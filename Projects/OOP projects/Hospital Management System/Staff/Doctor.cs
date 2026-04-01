using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Emergency;
using task_8.Hospital_Management_System.Interfaces;
using task_8.Hospital_Management_System.Scheduling;

namespace task_8.Hospital_Management_System.Staff
{
    public class Doctor : MedicalStaff, IPayroll, IEmergencyResponder, ISchedulable
    {

        private readonly List<Appointment> appointments = new List<Appointment>();


        public string Specialist { get; }
        public decimal BaseSalary { get; }
        //bonus
        public decimal OnCallAllownce { get; }
        public Doctor(int id, string name, string department, string specialist, decimal baseSalary, decimal onCallAllownce) : base(id, name, department)
        {
            Specialist = specialist;
            BaseSalary = baseSalary;
            OnCallAllownce = onCallAllownce;
        }

        public override string JobTitle => "Doctor";

        decimal IPayroll.CalculateMonthlyPay()
        {
            decimal salary = BaseSalary + OnCallAllownce;
            return salary;
        }

        public void RespondToEmergency(EmergencyCase emergency)
        {
            Console.WriteLine($"Doctor: {Name} \nresponding to {emergency.SeverityCase} emergency \nfor {emergency.Patient.FullName}\n");

        }

        public void ScheduleAppointment(Appointment appointment)
        {
            if (appointments.Any(appoint => appoint.Time == appointment.Time))
            {
                throw new InvalidOperationException($"Doctor: {Name} hsa already an appointment at: {appointment.Time}");
            }
            else { appointments.Add(appointment); }
        }
        //to read all memeber in list 
        public IReadOnlyList<Appointment> GetAppointments() => appointments.AsReadOnly();

    }
}
