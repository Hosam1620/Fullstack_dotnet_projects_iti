using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Hospital_Management_System.Patients
{
    public class Charges
    {
        public int Id {  get; }
        public string? Description { get; }
        public decimal Amount { get; }
        public DateTime? CreatedDate { get; }
        public Charges(int id,string? description, decimal amount)
        {
            Id = id;
            Description = description;
            Amount = amount;
            CreatedDate = DateTime.Now;
        }
    }
}
