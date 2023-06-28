using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Core.Interceptors
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptorBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } = 1;
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
