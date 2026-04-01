using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Hospital_Management_System.Patients
{
    public partial class Patient
    {
        public int PatientId { get; }
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public Patient(int patientId, string fullName, int age, string phone, string address)
        {
            PatientId = patientId;
            FullName = fullName;
            Age = age;
            Phone = phone;
            Address = address;
        }

        public void UpdateBasicInfo(string name,int age) { FullName = name; Age = age; }
        public void UpdateContact(string phone, string address)
        {
            Phone = phone;
            Address = address;
        }
    }
}
