using System;
using System.Collections.Generic;
using System.Text;
using task_8.Shoping;

namespace task_8.Hospital_Management_System.Patients
{
    public partial class Patient
    {
        private readonly List<Charges> charges = new();
        private readonly List<Payments> payments = new();

        public decimal TotalCharges => charges.Sum(c => c.Amount);
        public decimal TotalPayments => payments.Sum(p => p.Amount);
        public decimal Balance => TotalCharges - TotalPayments;

        public void AddCharges(int id, string description, decimal amount)
        {
            Charges charge = new Charges(id, description, amount);
            charges.Add(charge);
        }
        public bool RemoveCharge(Charges charge)
        {
            if (charge == null) return false;
            else if (charges.Any(p => p.Id == charge.Id))
            {
                charges.Remove(charge);
                return true;
            }
            return false;
        }
    }
}
