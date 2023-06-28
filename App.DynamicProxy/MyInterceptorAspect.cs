using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DynamicProxy
{
    // Interceptor yapmak için IInterceptor implemente edilir
    public class MyInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before Method");
            invocation.Proceed();
            Console.WriteLine("After Method");
        }
    }
}
