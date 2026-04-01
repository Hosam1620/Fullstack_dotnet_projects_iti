using System;
using System.Collections.Generic;
using System.Text;
using task_1.enums;

namespace task_1
{
    class Employee : HiringDate
    {
        public Employee(int id, string name, ESecurtyLevel securtyLevel, decimal salary, DateOnly hiringDate, EGender gender) : base(hiringDate)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Gender = gender;
            this.SecurtyLevel = securtyLevel;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ESecurtyLevel SecurtyLevel { get; set; }
        public Decimal Salary { get; set; }

        public EGender Gender { get; set; }
        public EPermission Permission
        {
            get;
            set
            {
                if (SecurtyLevel == ESecurtyLevel.DBA)
                {
                    field = EPermission.Read | EPermission.Write | EPermission.Execute | EPermission.Delete;
                }
                else if (SecurtyLevel == ESecurtyLevel.Developer)
                {
                    field = EPermission.Read | EPermission.Write | EPermission.Execute;
                }
                else
                {
                    field = EPermission.None;
                }
            }
        }


        public override string ToString()
        {
            return $"Your Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary}\n" +
                $"Gender: {Gender} \n" +
                $"Securty Level: {SecurtyLevel} \n" +
                $"Hiring Date: \n" + base.ToString();
        }
        public string GrantPermission(EPermission permission)
        {


            if (permission == EPermission.None)
            {
                if (Permission != EPermission.None)
                    return $"You can do : {Permission}";

                return $"You don't have any access here.";
            }
            else
            {
                if (Permission != EPermission.None) { Permission = Permission | permission; }
                else if ((permission & Permission) == permission)
                {
                    return $"You have this a permission already: {permission}";
                }


                Permission = Permission | permission;
                return $"You can access:{Permission} right now.";

            }


        }
    }
}
