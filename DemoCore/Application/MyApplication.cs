using DemoCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Application
{
    class MyApplication : IMyApplication
    {
        private IMyService myService;

        public MyApplication(IMyService myService)
        {
            this.myService = myService;
        }

        public string Call()
        {
            return this.myService.Run();
        }
    }
}
