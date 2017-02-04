using System;
using System.Collections.Generic;
using System.Reflection;
using SimpleFactory.Autos;

namespace SimpleFactory
{
    /// <summary>
    /// A simple auto factory that creates various types of automobiles
    /// based on key for Type lookup
    /// </summary>
    public class AutoFactory
    {
        private Dictionary<string, Type> _autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            _autos = new Dictionary<string, Type>();

            Type[] typesInThisAssimbly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssimbly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    _autos.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if ( t == null)
                return new NullAuto();

            return  Activator.CreateInstance(t) as IAuto;

        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in _autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return _autos[auto.Key];
                }
            }
            return null;
        }
    }
}