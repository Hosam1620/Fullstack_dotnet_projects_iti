using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    internal class Person
    {
         public int Id { get; set; }
        public string? Name { get; set; }
        public int YearOfBirth { get; set; }
        public Person(int id, string name, int yearOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.YearOfBirth = yearOfBirth;
        }
    }
}
