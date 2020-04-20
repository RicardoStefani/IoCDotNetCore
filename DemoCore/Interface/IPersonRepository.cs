using DemoCore.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Interface
{
    public interface IPersonRepository
    {
        public Person Save(Person person);
    }
}
