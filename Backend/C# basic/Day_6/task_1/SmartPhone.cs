using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    internal class SmartPhone : Device
    {
        public String? OSVersion { get; set; }
        public SmartPhone(string? osVersion, string serailNumber, string? brand = null) : base(serailNumber, brand)
        {
            OSVersion = osVersion;
        }
        public override string ToString()
        {
            return base.ToString()+$"\nos version : {OSVersion}";
        }
    }
}
