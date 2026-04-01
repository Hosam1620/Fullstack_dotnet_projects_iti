using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    [Flags]
    public enum SecurityPrivileges
    {
        DBA=8, Guest=1, Developer=2, Secretary=4, FullPermissions= 15
    }
}
