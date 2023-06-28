using AOP.Core.Interceptors;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Core.Aspects
{
    // Attributeların çözülmesini sağlayacak IoC içinde
    public class AspectSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptorBaseAttribute>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name)?
                .GetCustomAttributes<MethodInterceptorBaseAttribute>(true).ToList();

            if(methodAttributes != null)
            {
                classAttributes.AddRange(methodAttributes);
            }

            return classAttributes.OrderBy(x => x.Priority).ToArray();
            //Proxy Option'a parametre olarak geçilecek

        }
    }
}
