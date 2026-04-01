namespace task_8.Hospital_Management_System.Patients
{
    public class Payments
    {
        public decimal Amount {  get; }
        public DateTime CreadedDate { get; }
        public Payments(decimal amount) {
            this.Amount = amount;
            CreadedDate = DateTime.Now;
        }
    }
}