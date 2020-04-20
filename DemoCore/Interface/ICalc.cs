using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Interface
{
    public interface ICalc
    {
        public int Sum(int a, int b);
        public int Sub(int a, int b);
        public int Mult(int a, int b);
        public int Div(int a, int b);
    }
}
