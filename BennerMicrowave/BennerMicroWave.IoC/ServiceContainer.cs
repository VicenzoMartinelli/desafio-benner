using System;
using System.Collections.Generic;

namespace BennerMicroWave.IoC
{
    public class ServiceContainer
    {
        private static readonly Dictionary<Type, Type> _services = new Dictionary<Type, Type>();
        private static readonly Dictionary<Type, Func<object>> _creators = new Dictionary<Type, Func<object>>();

        public static void AddService<TInterface, TImplementation>(Func<TImplementation> createFunction)
            where TInterface : class
            where TImplementation : class, TInterface
        {
            if (!_services.ContainsKey(typeof(TInterface)))
            {
                _services.Add(typeof(TInterface), typeof(TImplementation));
                _creators.Add(typeof(TInterface), createFunction);
            }

        }

        public static TInterface Get<TInterface>()
            where TInterface : class
        {
            if (_services.ContainsKey(typeof(TInterface)) && _creators.TryGetValue(typeof(TInterface), out var func))
            {
                return (TInterface)func.Invoke();
            }
            return null;
        }
    }
}
