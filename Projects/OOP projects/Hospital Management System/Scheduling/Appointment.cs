using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Patients;
using task_8.Hospital_Management_System.Staff;
using task_8.Shoping;

namespace task_8.Hospital_Management_System.Scheduling
{
    public class Appointment
    {
        public int Id { get; }
        public DateTime Time { get; }
        public Patient Patient { get; }
        public Doctor Doctor { get; }

        public Appointment(int id, Patient patient, Doctor doctor)
        {
            Id = id;
            Time = DateTime.Now;
            Patient = patient;
            Doctor = doctor;
            
        }

        public override string ToString()
            => $"{Time:MM-dd HH:mm} \nAppt#{Id} \nPatient: {Patient.FullName}\nDoctor: {Doctor.Name}\n";
    }
}
