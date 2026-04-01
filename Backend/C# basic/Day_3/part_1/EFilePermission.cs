using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3_task_1
{
    //flags make an operation like bitwise operations is avilabe  
    [Flags]
    enum EFilePermission :byte
    {
        None = 0b0000_0000,//0
        Read= 0b0000_0001,//1
        Write= 0b0000_0010,//2
        Execute= 0b0000_0100,//4
        Delete= 0b0000_1000,//8
    }
}
