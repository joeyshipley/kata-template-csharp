using StructureMap;

namespace Kata.App.Infastructure
{
    public class IoCConfiguration
    {
        public static IContainer Build()
        {
            var container = configureDependencies();
            return container;
        }

        private static IContainer configureDependencies()
        {
            ObjectFactory.Configure(x =>
            {
                x.Scan(scan =>
                {
                    scan.LookForRegistries();
                    scan.Assembly("Kata.App");
                    scan.WithDefaultConventions();
                });
                // x.For<IClassB>().Use<ClassB>();
            });

            return new Container(x =>
            {
                x.Scan(scan =>
                {
                    scan.LookForRegistries();
                    scan.Assembly("Kata.App");
                    scan.WithDefaultConventions();
                });
                // x.For<IClassB>().Use<ClassB>();
            });
        }
    }
}