using Autofac;

namespace DataBaseSeeder
{
    public class Ioc_Register
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbSeeder>().As<IDbSeeder>();
            builder.RegisterType<ReadJsonFromFile>().As<IReadJsonFromFile>();
        }
    }
}