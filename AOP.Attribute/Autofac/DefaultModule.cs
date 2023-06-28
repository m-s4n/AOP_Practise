using AOP.Core.Aspects;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.AttributeOz.Autofac
{
    internal class DefaultModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var proxyOptions = new ProxyGenerationOptions()
            {
                Selector = new AspectSelector()
            };
            builder
               .RegisterType<Service>()
               .As<IService>()
               .EnableInterfaceInterceptors(proxyOptions) // Dinamic olarak çözülecek
               .InstancePerLifetimeScope();

            builder
                .RegisterType<Business>()
                .As<IBusiness>()
                .EnableInterfaceInterceptors(proxyOptions)
                .InstancePerLifetimeScope();
        }
    }
}
