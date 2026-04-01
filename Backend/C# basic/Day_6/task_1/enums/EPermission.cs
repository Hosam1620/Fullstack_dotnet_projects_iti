using System;
using System.Collections.Generic;
using System.Text;

namespace task_1.enums
{
      [Flags]
    enum EPermission : byte
    {
        None = 0b0000_0000,//0
        Read = 0b0000_0001,//1
        Write = 0b0000_0010,//2
        Execute = 0b0000_0100,//4
        Delete = 0b0000_1000,//8
    }

}
