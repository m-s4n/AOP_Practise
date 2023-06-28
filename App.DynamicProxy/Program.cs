using Castle.DynamicProxy;

namespace App.DynamicProxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new ProxyGenerator(); // proxy create edildi
            var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect()); // sınıf proxy ile sarmallanır
            aspect.MyMethod(); // proxy üzerinden metot çağrımı yapılır

            Console.ReadLine();
        }
    }
}
