using DemoCore.Interface;
using DemoCore.Service.Model;
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

        public Person Register(string name, int age, string address)
        {
            Person person = new Person
            {
                name = name,
                age = age,
                address = address
            };
            person = this.personRepository.Save(person);
            return person;
        }
    }
}
