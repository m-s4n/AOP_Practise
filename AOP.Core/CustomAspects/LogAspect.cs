using AOP.Core.Aspects;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Core.CustomAspects
{
    public class LogAspect: MethodAspectBaseAttribute
    {
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("OnAfter Method");
        }

        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("OnBefore Method");
        }
    }
}
