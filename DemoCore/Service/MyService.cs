using DemoCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Service
{
    class MyService : IMyService
    {
        public string Run()
        {
            return "Runnn!!!!";
        }
    }
}
