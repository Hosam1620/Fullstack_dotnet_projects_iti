using Day_1;

Employee[] employees = new Employee[3];

for (int i = 0; i < employees.Length; i++)
{
    Employee employee = new();
    Console.WriteLine($"enter the datails about employee number: {i + 1}");
    Console.WriteLine("enter id");
    employee.Id = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter your name");
    employee.Name = Console.ReadLine()!;
    Console.WriteLine("enter your National ID");
    int nationalId;
    if (int.TryParse(Console.ReadLine()!, out nationalId))
    {
        employee.NationalId = nationalId;
    }
    else
    {
        employee.NationalId = 0; 
    }
    Console.WriteLine("enter salary");
    employee.Salary = decimal.Parse(Console.ReadLine()!);
    Console.WriteLine("enter your Gender");

    Enum.TryParse(Console.ReadLine(), true, out Gender gender);
    employee.Gender = gender;
    Console.WriteLine("choice your securty level as number:");
    Console.WriteLine("1 - Guest");
    Console.WriteLine("2 - Developer");
    Console.WriteLine("4 - Secretary");
    Console.WriteLine("8 - DBA");
    Console.WriteLine("15 - Full Permissions");
    byte securityLevel = byte.Parse(Console.ReadLine()!);
    employee.SecurityLevel = (SecurityPrivileges)securityLevel;

    DateHiring hiringDate = new();
    Console.WriteLine("enter hiring date day");
    hiringDate.Day = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter hiring date month");
    hiringDate.Month = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter hiring date year");
    hiringDate.Year = int.Parse(Console.ReadLine()!);

    employee.HiringDate = hiringDate;

    employees[i] = employee;

}
