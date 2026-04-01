using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Emergency;
using task_8.Hospital_Management_System.Interfaces;
using task_8.Hospital_Management_System.Patients;
using task_8.Hospital_Management_System.Scheduling;
using task_8.Hospital_Management_System.Staff;
using task_8.Shoping;

namespace task_8.Hospital_Management_System
{
    public class HospitalSystem
    {
        private readonly List<MedicalStaff> staff = new();
        private readonly List<Patient> patients = new();
        private readonly List<Appointment> appointments = new();
        private readonly List<EmergencyCase> emergencies = new();

        //should know that IReadOnlyList aprovide the mehtod to just read list items,
        //but .Any() this method go on all items in list and make check with lambda.
        public IReadOnlyList<MedicalStaff> Staff => staff.AsReadOnly();
        public IReadOnlyList<Patient> Patients => patients.AsReadOnly();
        public IReadOnlyList<Appointment> Appointments => appointments.AsReadOnly();
        public IReadOnlyList<EmergencyCase> Emergencies => emergencies.AsReadOnly();

        public void AddStaff(MedicalStaff staff) => this.staff.Add(staff);
        public void AddPatient(Patient patient) => patients.Add(patient);


        public Appointment CreateAppointment(int id, Patient patient, Doctor doctor)
        {
            var appt = new Appointment(id, patient, doctor);

            // Use interface polymorphism
            ISchedulable schedulableDoctor = doctor;
            schedulableDoctor.ScheduleAppointment(appt);

            appointments.Add(appt);
            return appt;
        }
        public EmergencyCase CreateEmergency(int id, Patient patient, ESeverityCase severity, string description)
        {
            var emergency = new EmergencyCase(id, patient, severity, description);
            emergencies.Add(emergency);

            //// Dispatch responders: Doctors + Nurses implement IEmergencyResponder
            //var responders = staff.OfType<IEmergencyResponder>().ToList();
            //foreach (var responder in responders)
            //    responder.RespondToEmergency(emergency);

            return emergency;
        }
        public decimal CalculateTotalPayroll()
        {
            //from chat Gpt to say that for each member in staff which implement IPayroll call sum method
            //that make you sum all element in list and with lambda make return value is sumation of all salary 
            return staff.OfType<IPayroll>().Sum(p => p.CalculateMonthlyPay());
        }

        public string GenerateReport()
        {
            var doctors = staff.OfType<Doctor>().ToList();
            var nurses = staff.OfType<Nurse>().ToList();
            var techs = staff.OfType<Technician>().ToList();

            var totalPayroll = CalculateTotalPayroll();
            var totalOutstanding = patients.Sum(p => p.Balance);

            return
                 $"""
                                            === Hospital Report ===
                                            
                   Staff: {Staff.Count} (Doctors: {doctors.Count}, Nurses: {nurses.Count}, Techs: {techs.Count})
                   Patients: {Patients.Count}
                   Appointments: {Appointments.Count}
                   Emergencies: {Emergencies.Count}
                   Total Payroll (Monthly): {totalPayroll:C}
                   Total Outstanding Patient Balances: {totalOutstanding:C}
                  """;
        }
    }
}
