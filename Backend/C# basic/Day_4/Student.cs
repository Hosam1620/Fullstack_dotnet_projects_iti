using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    struct Student
    {
        public Student(int id, string name, double grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }
        public int Id { get; }
        public string Name { get; set; }
        public double Grade
        {
            get; 
            set
            {
                if (value > 0 && value <= 100)
                    field = value;
            }
        }
        public bool IsPassed()
        {
            if(Grade>=60)
            return true;
            else return false;
        }



    }
}
