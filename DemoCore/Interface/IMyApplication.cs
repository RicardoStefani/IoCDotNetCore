﻿using DemoCore.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore.Interface
{
    public interface IMyApplication
    {
        public Person Register(String name, int age, String address);
    }
}
