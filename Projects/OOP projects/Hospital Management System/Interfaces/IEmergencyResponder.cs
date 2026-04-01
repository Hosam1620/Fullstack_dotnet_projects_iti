using System;
using System.Collections.Generic;
using System.Text;
using task_8.Hospital_Management_System.Emergency;

namespace task_8.Hospital_Management_System.Interfaces
{
    public interface IEmergencyResponder
    {
        public void RespondToEmergency(EmergencyCase emergency);

    }
}
