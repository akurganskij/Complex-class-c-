using System;
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
        public MyComplex(MyComplex a) { this.Re = a.Re; this.Im = a.Im; }
        public MyComplex(double a) { new MyComplex(a, 0); }
        public MyComplex(string s){ MyComplex t = new MyComplex(); t = FromStr(s); this.Re = t.Re; this.Im = t.Im; }
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
            if (a.abs() <= b.abs()) return true;
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
        private MyComplex FromStr(string s)
        {
            double a = 0, b;
            string s1 = "";
            int i = 0;
            while(s[i] != '+')
            {
                s1 += s[i];
                ++i;
            }
            a = Convert.ToDouble(s1);
            while (s[i] != '*') ++i;
            ++i;
            s1 = "";
            while(i < s.Length)
            {
                s1 += s[i];
                ++i;
            }
            b = Convert.ToDouble(s1);
            return new MyComplex(a, b);
        }
    }
}
