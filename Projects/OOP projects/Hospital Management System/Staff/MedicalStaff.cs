using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Hospital_Management_System.Staff
{
    public abstract class MedicalStaff
    {
        public int StaffId { get;  }
        public String Name { get;  }
        public String Department { get;  }

        protected MedicalStaff(int staffId, string name, string department)
        {
            StaffId = staffId;
            //here we check about null values
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }
        //jobTitle
        public abstract string JobTitle { get; }

        public override string? ToString()
        {
            //we can use the abstract varailbe cause of override should is continouse
            //the virual operation which mean absract also;
            return $"Job Title: {JobTitle}\nName: {Name}\nId: {StaffId}\nDepartment: {Department}\n";
        }
    }
}
