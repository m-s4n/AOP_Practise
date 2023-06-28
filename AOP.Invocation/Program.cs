
using Castle.DynamicProxy;
using Entities;

namespace AOP.Invocation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<Employee>(new MyInterceptorAspect(), new ValidationAspect());

            var employee = new Employee
            {
                Id = 1,
                FirstName = "Mustafa",
               
            };

            aspect.Update(lastName: employee.LastName, id: employee.Id, firstName: employee.FirstName);

            Console.ReadLine();
        }
    }
}
