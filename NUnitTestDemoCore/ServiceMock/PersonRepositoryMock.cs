using DemoCore.Interface;
using DemoCore.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestDemoCore.ServiceMock
{
    class PersonRepositoryMock : IPersonRepository
    {
        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Person Save(Person person)
        {
            person.id = 1;
            return person;
        }
    }
}
