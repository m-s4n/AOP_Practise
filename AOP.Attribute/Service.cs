using AOP.Core.CustomAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.AttributeOz
{
    public class Service : IService
    {
        [LogAspect(Priority = 1)]
        [ValidationAspect(Priority = 2)]
        public void Ekle()
        {
            Console.WriteLine("Service Eklendi");
        }

        [LogAspect(Priority = 1)]
        [ValidationAspect(Priority = 2)]
        public void Sil()
        {
            Console.WriteLine("Service Silindi");
        }
    }
}
