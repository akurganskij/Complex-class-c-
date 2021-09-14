using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    internal struct Complex
    {
        public double Real;
        public double Imag;
        public Complex(double a, double b) { Real = a; Imag = b; }
    };
    class MyComplex
    {
        public Complex num;
        public MyComplex() { num = new Complex(0.0, 0.0); }
        protected MyComplex(Complex a) {num = a;}
        public MyComplex(double a) { num = new Complex(a, 0.0); }
        public MyComplex(double a, double b) { num = new Complex(a, b); }
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            Complex c = new Complex(a.num.Real + b.num.Real , a.num.Imag + b.num.Imag);                        
            return new MyComplex(c);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            Complex c = new Complex(a.num.Real - b.num.Real, a.num.Imag - b.num.Imag);
            return new MyComplex(c);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            Complex c = new Complex(a.num.Real * b.num.Real - a.num.Imag * b.num.Imag, a.num.Imag * b.num.Real + a.num.Real * b.num.Imag);
            return new MyComplex(c);
        }
        public string print()
        {
            string s = num.Real.ToString() + " + " + num.Imag.ToString() + "i";
            return s;
        }
        public double abs()
        {
            return Math.Sqrt(Math.Pow(num.Real, 2) + Math.Pow(num.Imag, 2));
        }
        public static bool operator <(MyComplex a, MyComplex b)
        {
            if( a.abs() < b.abs()) return true;
            return false;
        }
        public static bool operator >(MyComplex a, MyComplex b)
        {
            if (a.abs() > b.abs()) return true;
            return false;
        }
        public static bool operator ==(MyComplex a, MyComplex b)
        {
            if (a.abs() == b.abs()) return true;
            return false;
        }
    }
}
