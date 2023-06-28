using AOP.Core.Aspects;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Core.CustomAspects
{
    public class ValidationAspect: MethodAspectBaseAttribute
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Validation Checked");
        }
    }
}
