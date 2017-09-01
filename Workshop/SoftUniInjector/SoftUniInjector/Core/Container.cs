
using SoftUniInjector.Core.RegisteringModules;
using SoftUniInjector.Repository;
using SoftUniInjector.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoftUniInjector.Core
{
    public class Container
    {
        private Dictionary<Type, Type> dependencies;

        private Dictionary<Type, object> cache;

        public Container(params IRegisteringModule[] modules)
        {
            this.dependencies = new Dictionary<Type, Type>();
            this.cache = new Dictionary<Type, object>();
            this.InvokeModules(modules);
        }

        private void InvokeModules(IRegisteringModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Register(this.dependencies, this.cache);
            }
        }

        public T Get<T>()
        {

            var interfaceType = typeof(T);

            if (!interfaceType.GetTypeInfo().IsInterface &&
                !interfaceType.GetTypeInfo().IsAbstract)
            {
                throw new Exception("We can only make DI with interfaces.");
            }

            return (T)this.Get(interfaceType);          
        }

        public void Register<TAbst, TImpl>()
            where TImpl : TAbst
        {
            dependencies[typeof(TAbst)] = typeof(TImpl);
        }

        private object Get(Type interfaceType) 
        {
            if (this.cache.ContainsKey(interfaceType))
            {
                return this.cache[interfaceType];
            }

            Type concreteType = this.dependencies[interfaceType];

            ConstructorInfo ctorInfo = concreteType.GetConstructors().FirstOrDefault();

            ParameterInfo[] args = ctorInfo.GetParameters();

            List<object> argList = new List<object>();

            foreach (var arg in args)
            {
                Type argType = arg.ParameterType;

                var obj = this.Get(argType);

                argList.Add(obj);
            }

            object objToCache = ctorInfo.Invoke(argList.ToArray());

            this.cache[interfaceType] = objToCache;

            return objToCache;
        }
    }
}
