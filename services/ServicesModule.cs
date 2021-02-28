using Autofac;
using entities.config;
using entities.entities;
using entities.repository;
using System;

namespace services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            //containerBuilder.Register<IRepository<Employee>, EFRepository<Employee>>();

        }
    }
}
