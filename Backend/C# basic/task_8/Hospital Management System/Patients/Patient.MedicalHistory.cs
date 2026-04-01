using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Records;

namespace task_8.Hospital_Management_System.Patients
{
    public partial class Patient
    {
        private readonly List<MedicalRecord> records = new();

        public void AddMedicalRecord(MedicalRecord record)
        {
            //to handl the exception in other please or want to make sure that you handl every case
            if (record.RecordId != PatientId)
                throw new InvalidOperationException("Record patientId mismatch.");

            records.Add(record);
        }
    }
}
