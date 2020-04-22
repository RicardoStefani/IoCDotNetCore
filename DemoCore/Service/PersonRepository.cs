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
            person.id = this.people.Count;
            people.Add(person);
            return person;
        }

        public Person Get(int id) 
        {
            Person person = this.people.Find(personX => personX.id == id);

            return person;
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
