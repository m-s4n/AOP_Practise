using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DynamicProxy
{
    public class MyClass: IMyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Method Body");
        }
    }
}
