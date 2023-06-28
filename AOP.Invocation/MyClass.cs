using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Invocation
{
    public class MyClass : IMyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod Body");
        }
    }
}
