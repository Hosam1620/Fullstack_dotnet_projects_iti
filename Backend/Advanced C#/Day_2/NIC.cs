using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    public class NIC
    {
        public string Manufacture { get; }
        public string MacAddress { get; }

        public TypeOfNIC TypeOf { get; }
        private NIC(string manufacture, string macAddress, TypeOfNIC typeOf)
        {
            Manufacture = manufacture;
            MacAddress = macAddress;
            TypeOf = typeOf;
        }
        private static NIC Nic;
        public static NIC Create(string manufacture, string macAddress, TypeOfNIC typeOf)
        {
            if (Nic == null)
            { 
                 Nic=new NIC(manufacture, macAddress, typeOf);
            }
                return Nic;
            
        }
        public override string ToString()
        {
            return $"Manufacture: {Manufacture}, MacAddress: {MacAddress}, TypeOf: {TypeOf}";
        }
    }
}
