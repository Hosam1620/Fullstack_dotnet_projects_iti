namespace Day_1
{
    class Program
    {
        static void Main()
        {
            MyLinkedList list = new ();

            list.InsertLast(new Employee(1, 25, 5000, "IT"));
            list.InsertLast(new Employee(2, 30, 7000, "HR"));
            list.InsertLast(new Employee(3, 28, 6500, "Finance"));

            Console.WriteLine("Employees:");
            list.Display();

            Console.WriteLine("\nSearching for employee ID 2:");
            var emp = list.Search(2);
            if (emp != null)
                Console.WriteLine(emp.Data);

            Console.WriteLine("\nDeleting employee ID 2");
            list.Delete(2);

            Console.WriteLine("\nAfter deletion:");
            list.Display();
        }
    }
}
