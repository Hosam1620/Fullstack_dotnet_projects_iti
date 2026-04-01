using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Scheduling;

namespace task_8.Hospital_Management_System.Interfaces
{
    public interface ISchedulable
    {
        //تحديد موعد
       public void ScheduleAppointment(Appointment appointment);
    }
}
