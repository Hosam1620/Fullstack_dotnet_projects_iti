using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Complex
    {
        int real;
        int imaginary;
        public Complex(int real, int imaginary) { this.real = real; this.imaginary = imaginary; }

        public static Complex operator +(Complex a, Complex b) { return new Complex(a.real + b.real, a.imaginary + b.imaginary); }
        public static Complex operator -(Complex a, Complex b) { return new Complex(a.real - b.real, a.imaginary - b.imaginary); }

        public static Complex operator -(int a, Complex b) { return new Complex(b.real, b.imaginary - a); }

        public static Complex operator -(Complex a, int b) { return new Complex(a.real - b, a.imaginary); }
        
        public static Complex operator -(Complex a) { return new Complex(-a.real,-a.imaginary); }
        public static bool operator ==(Complex a, Complex b) {
            if (a.real == b.real&&a.imaginary == b.imaginary) return true;
            return false;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            if (a.real != b.real || a.imaginary != b.imaginary) return true;
            return false;
        }
        public static bool operator <(Complex a, Complex b)
        {
            if (a.real < b.real && a.imaginary < b.imaginary) return true;
            return false;
        }
        public static bool operator >(Complex a, Complex b)
        {
            if (a.real > b.real && a.imaginary > b.imaginary) return true;
            return false;
        }
        public static bool operator <=(Complex a, Complex b)
        {
            if (a.real <= b.real && a.imaginary <= b.imaginary) return true;
            return false;
        }
        public static bool operator >=(Complex a, Complex b)
        {
            if (a.real >= b.real && a.imaginary >= b.imaginary) return true;
            return false;
        }
        //public static implicit operator int(Complex a)
        //{
        //    return a.real;
        //}
        public static explicit operator string(Complex a)
        {
            return $"{a.real}+{a.imaginary}i";
        }
        //public static implicit operator bool(Complex a)
        //{
        //    if(a.imaginary==0) return false;
        //    return true;
        //}

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return $"{real}+{imaginary}i";
        }
    }

}
