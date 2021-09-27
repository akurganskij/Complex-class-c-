﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{

    class MyComplex
    {
        public double Re, Im;
        public MyComplex(double a, double b) { Re = a; Im = b; }
        public MyComplex() { new MyComplex(0, 0); }
        protected MyComplex(MyComplex a) { new MyComplex(a.Re, a.Im); }
        public MyComplex(double a) { new MyComplex(a, 0); }
        
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {                       
            return new MyComplex(a.Re + b.Re, a.Im + b.Im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re - b.Re, a.Im - b.Im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re * b.Re - a.Im * b.Im, a.Im * b.Re + a.Re * b.Im);
        }
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            double n = Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2);
            return new MyComplex((a.Re*b.Re + a.Im*b.Im)/n, (a.Im*b.Re - a.Re*b.Im)/n);
        }
        public override string ToString()
        {
            string s = Re.ToString() + " + " + Im.ToString() + "i";
            return s;
        }
        public double abs()
        {
            return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2));
        }
        public static bool operator <(MyComplex a, MyComplex b)
        {
            if( a.abs() < b.abs()) return true;
            return false;
        }
        public static bool operator <=(MyComplex a, MyComplex b)
        {
            if (a.abs() < b.abs()) return true;
            return false;
        }
        public static bool operator >(MyComplex a, MyComplex b)
        {
            if (a.abs() > b.abs()) return true;
            return false;
        }
        public static bool operator >=(MyComplex a, MyComplex b)
        {
            if (a.abs() >= b.abs()) return true;
            return false;
        }
        public static bool operator ==(MyComplex a, MyComplex b)
        {
            if (a.abs() == b.abs()) return true;
            return false;
        }
        public static bool operator !=(MyComplex a, MyComplex b)
        {
            if (a.abs() != b.abs()) return true;
            return false;
        }
        
    }
}
