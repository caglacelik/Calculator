using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double Add(double a,double b)
        {
            return a + b;
        }

        public static double Subs(double a, double b)
        {
            return a - b;
        }

        public static double Div(double a, double b)
        {
            if(b==0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public static double Multip(double a, double b)
        {
            return a * b;
        }

        public static bool Validate(string a,string b)
        {
            return (!string.IsNullOrWhiteSpace(a) && !string.IsNullOrWhiteSpace(b));
        }

    }
}
