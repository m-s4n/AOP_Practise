using AOP.Core.CustomAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.AttributeOz
{
    public class Business: IBusiness
    {
        [LogAspect(Priority = 1)]
        [ValidationAspect(Priority = 2)]
        public virtual void Add()
        {
            Console.WriteLine("Business Added");
        }

        public void Remove()
        {
            Console.WriteLine("Business Removed");
        }
    }
}
