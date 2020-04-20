using DemoCore.Interface;
using DemoCore.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestDemoCore.ServiceMock
{
    class PersonRepositoryMock : IPersonRepository
    {
        public Person Save(Person person)
        {
            return person;
        }
    }
}
