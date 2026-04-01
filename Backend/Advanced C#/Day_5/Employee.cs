using Day_5;
using System;
using System.Collections.Generic;
using System.Text;



    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; set; }

        public int VacationStock { get; set; }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int days = (To - From).Days;

            VacationStock -= days;

            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.VacationStockNegative
                });

                return false;
            }

            return true;
        }

        public virtual void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.AgeGreaterThan60
                });
            }
        }
    }

