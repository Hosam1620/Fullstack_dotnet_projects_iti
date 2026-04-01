using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
