using AOP.Core.Interceptors;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Core.Aspects
{
    public class MethodAspectBaseAttribute: MethodInterceptorBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool successFlag = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                successFlag = false;
                OnException(invocation, ex);
                throw;
            }
            finally
            {
                if (successFlag)
                {
                    OnSuccess(invocation);
                }

                OnAfter(invocation);
            }
            
        }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnSuccess(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }
        public virtual void OnAfter(IInvocation invocation) { }
        
    }
}
