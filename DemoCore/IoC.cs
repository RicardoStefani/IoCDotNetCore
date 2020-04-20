using DemoCore.Application;
using DemoCore.Interface;
using DemoCore.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCore
{
    class IoC
    {
        public static IServiceCollection GetCollection()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<ICalc, Calc>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IMyApplication, MyApplication>();

            return services;

        }
    }
}
