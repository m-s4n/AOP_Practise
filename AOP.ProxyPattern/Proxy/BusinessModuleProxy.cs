using AOP.ProxyPattern.Concretes;
using AOP.ProxyPattern.Interfaces;

namespace AOP.ProxyPattern.Proxy
{
    internal class BusinessModuleProxy : IBusinesModule
    {
        private readonly IBusinesModule _module;

        public BusinessModuleProxy()
        {
            _module = new BusinessModule();
        }

        // Araya girmemiz sağlandı
        public void Method()
        {
            Console.WriteLine("Before Method");
            _module.Method();
            Console.WriteLine("After Method");
        }
    }
}
