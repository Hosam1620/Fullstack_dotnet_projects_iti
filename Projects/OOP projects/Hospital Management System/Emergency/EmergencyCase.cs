using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Patients;
using task_8.Shoping;

namespace task_8.Hospital_Management_System.Emergency
{
    public class EmergencyCase
    {
        public int Id { get; }
        public Patient Patient { get; }
        public ESeverityCase SeverityCase { get; }
        public string Description { get; }
        public DateTime ReceptioDate { get; }

        public EmergencyCase(int id, Patient pertient, ESeverityCase severityCase, string description)
        {
            Id = id;
            this.Patient = pertient;
            SeverityCase = severityCase;
            Description = description;
            ReceptioDate = DateTime.Now;
        }
        public override string ToString()=> $"Emergency#{Id} \n {SeverityCase} \n Patient: {this.Patient.FullName} \n {Description} \n {ReceptioDate:HH:mm:ss}";

    }
}
