using Castle.DynamicProxy;

namespace AOP.Invocation
{
    public class MyInterceptorAspect : IInterceptor // aspect olabilmesi için
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before Method");
            var parameters = invocation.Arguments;
            Console.WriteLine("TargetName: {0}", invocation.TargetType); // işlem yapılan tip
            Console.WriteLine("InvocationTarget: {0}", invocation.InvocationTarget); // proxy adı
            foreach (var parameter in parameters)
            {
                Console.WriteLine(parameter);
            }
            invocation.Proceed(); // Metot çağrımı yapıldı.
            Console.WriteLine("After Method");
        }
    }
}
