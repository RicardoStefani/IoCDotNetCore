using DemoCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Service
{
    public class Calc : ICalc
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
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
