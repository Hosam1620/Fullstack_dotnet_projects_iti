using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    public class DateHiring
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        
        
        override public string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
