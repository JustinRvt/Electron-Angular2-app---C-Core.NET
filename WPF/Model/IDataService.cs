using Demo.DTOLibrary.Info;
using Demo.DTOLibrary.Methodes;
using Demo.Framework.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF.Model
{
    public interface IDataService
    {
        /// <summary>
        /// Recuperer une liste de DTO selon les critere passer en paramettre
        /// </summary>
        /// <param name="pCritere">Critere de recherche du DTO</param>
        /// <returns>List de DTO</returns>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        IEnumerable<IBaseDTO> GetItems(IBaseDTO pCritere);

        /// <summary>
        /// Recuperer un DTO selon les critere passer en paramettre
        /// </summary>
        /// <param name="pCritere">Critere de recherche du DTO</param>
        /// <returns>DTO</returns>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        IBaseDTO GetItem(IBaseDTO pCritere);

        /// <summary>
        /// Ajouter un DTO 
        /// </summary>
        /// <param name="pEntity">DTO</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        IBaseDTO AddItem(IBaseDTO pEntity);

        /// <summary>
        /// Ajouter d'une liste de DTO 
        /// </summary>
        /// <param name="pEntities">Liste de DTO</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        void AddItems(IEnumerable<IBaseDTO> pEntities);

        /// <summary>
        /// Update un DTO
        /// </summary>
        /// <param name="pEntity">DTO a mettre a jour</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        void UpdateItem(IBaseDTO pEntity);

        /// <summary>
        /// Update une liste de DTO
        /// </summary>
        /// <param name="pEntities">liste de DTO a mettre a jour</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        void UpdateItems(IEnumerable<IBaseDTO> pEntities);

        /// <summary>
        /// Supprimer des elment
        /// </summary>
        /// <param name="pCritere">Critere des element a suppruimer</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        void RemoveItems(IBaseDTO pCritere);

        /// <summary>
        /// Execution Fonction metier avec retour
        /// </summary>
        /// <param name="pMethod">Methode</param>
        /// <returns>retour</returns>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        object ExecuteFunction(MethodDTO pMethod);

        /// <summary>
        /// Execution sans retour
        /// </summary>
        /// <param name="pMethod">Methode</param>
        /// <remarks>LOUIS YOANN 24/06/2015</remarks>
        void ExecuteVoid(MethodDTO pMethod);

        /// <summary>
        /// Valide le Critere de recherche
        /// </summary>
        /// <param name="pCritere">Critere de recherche du DTO</param>
        /// <remarks>LOUIS Yoann 11/02/2016</remarks>
        void ValidatedCritere(IBaseDTO pCritere);

        /// <summary>
        /// Valide le DTO 
        /// </summary>
        /// <param name="pEntity">Entité a valider</param>
        /// <remarks>LOUIS Yoann 11/02/2016</remarks>
        void ValidatedDTO(IBaseDTO pEntity);

    }
}
