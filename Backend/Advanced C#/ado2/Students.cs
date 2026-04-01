using System;
using System.Collections.Generic;
using System.Text;

namespace ado2
{
    public class Students
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public int DeptId { get; set; }
        public Students( string? name = default, int age = default, string? address = default, int deptId = default)
        {
            
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.DeptId = deptId;
        }
        public override string ToString()
        {
            return $"Student Name: {Name} ,Student Age: {Age} ,Address:{Address} ,Department_Id: {DeptId}\n";
        }
    }
}
