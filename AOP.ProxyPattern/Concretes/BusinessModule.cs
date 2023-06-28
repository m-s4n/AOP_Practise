using AOP.ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.ProxyPattern.Concretes
{
    internal class BusinessModule : IBusinesModule
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
