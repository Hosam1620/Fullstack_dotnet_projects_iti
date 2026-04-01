using task_8.Employee_Management;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
          

            #region task 2 Employee management system

            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "hossam", "mohemd", "hosam@giaml.com", "backend", 10000m));
            list.Add(new Employee(2, "hoss", "mohemd", "hosam@giaml.com", "backend", 14000m));
            list.Add(new Employee(3, "hossa", "mohemd", "hosam@giaml.com", "os", 13000m));
            list.Add(new Employee(4, "hema", "mohemd", "hosam@giaml.com", "frontend", 12000m));
            EmployeeManager manager = new EmployeeManager(list);
            manager.HireEmployee(list[0]);
            manager.HireEmployee(list[1]);
            manager.HireEmployee(list[2]);
            manager.HireEmployee(list[3]);
            //manager.DisplayAllEmployees();
            //manager.DisplayAllHiredEmployees();
            manager.GetDepartmentEmployees("os"); 
            #endregion
        }
    }
}
