using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Service.Model
{
    public struct Person
    {
        public int id;
        public string name;
        public int age;
        public string address;

        public static Person Build()
        {
            Person person = new Person
            {
                id = -1,
                name = String.Empty,
                age = -1,
                address = String.Empty
            };

            return person;
        }
    }
}