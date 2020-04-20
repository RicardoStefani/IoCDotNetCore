using DemoCore.Interface;
using DemoCore.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Service
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> people = new List<Person>();

        public Person Save(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
