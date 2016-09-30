using System;
using Demo.Framework.Domain.Command;
using UnityConfiguration;

namespace Demo.Framework.InversionOfControl
{
    public class ExoCommandConvention : IAssemblyScannerConvention
    {
        public void Process(Type pType, IUnityRegistry pRegistry)
        {
            if (pType.BaseType != null && pType.BaseType.IsAssignableFrom(typeof(ExoCommand)))
            {
                pRegistry.Register(pType, pType).AsSingleton();
            }
        }
    }
}