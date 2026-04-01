using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3part_2
{
    struct CircleStruct
    {
        //const double PI= 3.14;
        //old way 
        //private double radius;

        //newest way
        //property 
        //this called auto property
        //public double Radius { get; set; }
        
        //called fully property cause of i make a condition on set or make business on the field
        public double Redius
        {
            get;
            set
            {
                if (value > 0)
                    //don't have to declar a field to save into this world field make a field an assign the vaule into it.
                    field = value;
                else field = 0;
            }
        }

        public double GetArea()
        {
            return Math.PI*Math.Pow(Redius,2);
        }

        public double GetCircumference()
        {
            return Math.PI*Redius*2;
        }
    }
}
