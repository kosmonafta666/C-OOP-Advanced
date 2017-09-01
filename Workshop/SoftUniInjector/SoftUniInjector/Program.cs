using SoftUniInjector.Core;
using SoftUniInjector.Core.RegisteringModules;
using SoftUniInjector.Repository;
using SoftUniInjector.Services;
using System.Reflection;

namespace SoftUniInjector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container(new SingleImplementationModule(Assembly.GetEntryAssembly()));

            container.Register<ISoftUniRepository, DefaultSoftUniRepository>();

            var userService = container.Get<IUserService>();

            userService.Rename();
        }
    }
}
