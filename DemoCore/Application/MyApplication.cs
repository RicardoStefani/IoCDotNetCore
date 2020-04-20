using DemoCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Application
{
    public class MyApplication : IMyApplication
    {
        private ICalc myService;

        public MyApplication(ICalc myService)
        {
            this.myService = myService;
        }

        public string Call()
        {
            return "";
        }
    }
}
