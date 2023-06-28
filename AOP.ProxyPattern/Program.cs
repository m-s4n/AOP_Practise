using AOP.ProxyPattern.Interfaces;
using AOP.ProxyPattern.Proxy;

namespace AOP.ProxyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBusinesModule businesModule = new BusinessModuleProxy();
            businesModule.Method();
        }
    }
}