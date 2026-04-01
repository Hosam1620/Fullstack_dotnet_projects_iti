using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Device
    {
       
        public string? SerialNumber { get; set; }
        public string? Brand { get; set; }
        public Device(string serialNumber, string? brand = null)
        {
            this.SerialNumber = serialNumber;
            this.Brand = brand;
        }
        public override string ToString()
        {
            return $"Yuor Device Serial Number is: {SerialNumber}\n" +
                $"and from Brand Called: {Brand}";
        } 
    }
}
