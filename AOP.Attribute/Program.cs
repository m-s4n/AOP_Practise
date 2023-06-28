
using AOP.AttributeOz.Autofac;
using Autofac;

namespace AOP.AttributeOz
{
    public class Program
    {
        public static void Main()
        {
            // Container inşasına başlıyoruz
            var builder = new ContainerBuilder(); //IoC Container

            //builder.RegisterModule<DefaultModule>();
            builder.RegisterModule(new DefaultModule());
            

            var container = builder.Build();

            var businessNesnesi = container.Resolve<IService>();

            businessNesnesi.Ekle();

        }
    }
}
