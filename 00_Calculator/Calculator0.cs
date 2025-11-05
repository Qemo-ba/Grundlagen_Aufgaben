using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Calculator
{
    public class Calculator0 : ICalculator
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
