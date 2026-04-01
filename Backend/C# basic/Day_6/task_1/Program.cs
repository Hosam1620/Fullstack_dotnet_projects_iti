namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region from 1 to 5 lab 6
            ////Employee employee = new Employee(1, "hossam", ESecurtyLevel.Developer, 12000m, DateOnly.FromDateTime(DateTime.Now), EGender.Male);
            ////Console.WriteLine(employee.ToString());
            //#endregion
            //#region Bank Account

            //#endregion
            //#region Smart phone

            SmartPhone smart = new SmartPhone("maoh","3v8l43FDS");
            Console.WriteLine(smart.ToString());
            //#endregion
            #region part two override 
            Complex a=new Complex(1, 2);
            Complex b=new Complex(3, 4);
            Complex c=new Complex(5, 0);
            Console.WriteLine(a+b);
            #endregion
        }
    }
}