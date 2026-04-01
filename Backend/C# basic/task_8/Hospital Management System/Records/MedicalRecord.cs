using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Hospital_Management_System.Records
{
    public sealed class MedicalRecord
    {
        public int RecordId { get; }
        public string PatientId { get; }
        public DateTime CreatedAt { get; }
        public string Diagnosis { get; private set; }
        public string TreatmentPlan { get; private set; }

        public MedicalRecord(int recordId, string patientId, string diagnosis, string treatmentPlan)
        {
            RecordId = recordId;
            PatientId = patientId;
            CreatedAt = DateTime.Now;
            Diagnosis = diagnosis;
            TreatmentPlan = treatmentPlan;
        }

        public void UpdateDiagnosis(string newDiagnosis) => Diagnosis = newDiagnosis;
        public void UpdateTreatment(string newPlan) => TreatmentPlan = newPlan;

        public override string ToString()
            => $"Record:{RecordId}\nPatientId: {PatientId}\nCreated At:{CreatedAt:yyyy-MM-dd}\nDiagnosis: {Diagnosis}\nPlan: {TreatmentPlan}\n";
    }
}
