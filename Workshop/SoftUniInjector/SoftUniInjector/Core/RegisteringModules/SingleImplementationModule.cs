
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoftUniInjector.Core.RegisteringModules
{
    public class SingleImplementationModule : IRegisteringModule
    {
        private Assembly Assembly { get; }

        public SingleImplementationModule(Assembly assembly)
        {
            this.Assembly = assembly;
        }

        public void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
            Type[] alltypes = this.Assembly.GetTypes();

            Type[] abstractions = alltypes
                .Where(x => x.GetTypeInfo().IsInterface)
                .Where(x => x.GetTypeInfo().IsAbstract)
                .ToArray();

            Type[] concreteTypes = alltypes.Except(abstractions).ToArray();

            foreach (var abstraction in abstractions)
            {
                Type[] implementations = concreteTypes
                    .Where(x => x.GetInterfaces().Contains(abstraction))
                    .ToArray();

                if (implementations.Length != 1)
                {
                    continue;
                }

                Type singleImplementation = implementations[0];

                types[abstraction] = singleImplementation;
            }
        }
    }
}
