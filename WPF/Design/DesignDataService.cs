using Demo.DTOLibrary.Methodes;
using Demo.Framework.AccesDonnees;
using System;
using WPF.Model;

namespace WPF.Design
{
    public class DesignDataService : IDataService
    {
        public System.Collections.Generic.IEnumerable<Demo.Framework.AccesDonnees.IBaseDTO> GetItems(IBaseDTO pCritere)
        {
            throw new NotImplementedException();
        }

        public Demo.Framework.AccesDonnees.IBaseDTO GetItem(IBaseDTO pCritere)
        {
            throw new NotImplementedException();
        }

        public Demo.Framework.AccesDonnees.IBaseDTO AddItem(IBaseDTO pEntity)
        {
            throw new NotImplementedException();
        }

        public void AddItems(System.Collections.Generic.IEnumerable<IBaseDTO> pEntities)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(IBaseDTO pEntity)
        {
            throw new NotImplementedException();
        }

        public void UpdateItems(System.Collections.Generic.IEnumerable<IBaseDTO> pEntities)
        {
            throw new NotImplementedException();
        }

        public void RemoveItems(IBaseDTO pCritere)
        {
            throw new NotImplementedException();
        }

        public object ExecuteFunction(MethodDTO pMethod)
        {
            throw new NotImplementedException();
        }

        public void ExecuteVoid(MethodDTO pMethod)
        {
            throw new NotImplementedException();
        }

        public void ValidatedCritere(IBaseDTO pCritere)
        {
            throw new NotImplementedException();
        }

        public void ValidatedDTO(Demo.Framework.AccesDonnees.IBaseDTO pEntity)
        {
            throw new NotImplementedException();
        }
    }
}