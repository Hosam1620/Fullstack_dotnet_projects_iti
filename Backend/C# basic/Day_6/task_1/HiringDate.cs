using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate(DateOnly hireDate)
        {
            this.Day = hireDate.Day;
            this.Month = hireDate.Month;
            this.Year = hireDate.Year;
        }
        public override string ToString() {
            return $"You hired on: {Day} /" +
                $" {Month} / {Year}";
        }
    }
}
