using DemoCore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Application
{
    public class MyApplication : IMyApplication
    {
        private IPersonRepository personRepository;

        public MyApplication(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public string Call()
        {
            return "";
        }
    }
}
