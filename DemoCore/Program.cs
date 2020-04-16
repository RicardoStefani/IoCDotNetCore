using DemoCore.Application;
using DemoCore.Interface;
using DemoCore.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoCore
{
    class Program
    {

        static void Main(string[] args)
        {
            var services = IoC.GetCollection();

            var serviceProvider = services.BuildServiceProvider();

            IMyApplication myApplication = serviceProvider.GetService<IMyApplication>();


            Console.WriteLine(myApplication.Call());
        }
    }
}