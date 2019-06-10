using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ContainerConfig 
    {
        public static IContainer Configuer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();


            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                    .Where(x=>x.Namespace.Contains("Utilities"))
                    .As(t=>t.GetInterfaces().FirstOrDefault(i=>i.Name == "I"+t.Name));






            //builder.RegisterType<Application>().AsSelf();

            return builder.Build();
        }
    }
}
