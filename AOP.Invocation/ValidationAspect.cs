using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Invocation
{
    public class ValidationAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var parameters = invocation.Arguments;

            foreach (var parameter in parameters)
            {
                if(parameter is null)
                {
                    throw new ArgumentNullException();
                }
            }

            invocation.Proceed();
        }
    }
}
