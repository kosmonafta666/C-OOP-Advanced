
using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftUniInjector.Core.RegisteringModules
{
    public interface IRegisteringModule
    {
        void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects);
    }
}
