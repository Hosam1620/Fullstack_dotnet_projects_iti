using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    public class Point : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        //public Point(int x)
        //{
        //    X = x;
        //}

        //public Point(int x, int y) : this(x)
        //{
        //    Y = y;
        //}
        public Point(int x, int y, int z)// : this(x, y)
        {
            X = x;
            Y = y;
            Z = z;
        }
        override public string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        override public bool Equals(object obj)
        {
            if (obj == null)
             {
                return false;
            }

            if (obj is Point p)
            {
                return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
        }

        public int CompareTo(object? obj)
        {

            /// <summary>
            /// compare to that i make an implementation of it for reference types and 
            /// that i called it's for compare value type.
            /// and i will compare the x property of the point class
            /// </summary>
            if (obj is Point p)
            {
              //this compare the value types it self.  
                int result = X.CompareTo(p.X);
                if (result == 0)
                {
                    result = Y.CompareTo(p.Y);
                    if (result == 0)
                    {
                        result = Z.CompareTo(p.Z);
                    }
                }
                return result;
            }
            throw new ArgumentException("Object is not a Point");
        }

        public object Clone()
        {
            return new Point(X, Y, Z);
        }
    }
}
