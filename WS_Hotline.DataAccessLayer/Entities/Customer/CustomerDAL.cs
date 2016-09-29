using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using WS_Hotline.DTOLibrary.Entities.User;
using WS_Hotline.Framework.AccesDonnees;

namespace WS_Hotline.DataAccessLayer.Entities.Customer
{
    /// <summary>
        /// Classe data acess layer de Name
        /// </summary>
        /// <remarks>[Login] - [DateDuJour] - Généré par snippet v1.0</remarks>
    public class CustomerDAL : Repository<CustomerDTO, EformDbContext>
    {
        #region CSTR

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <remarks>[Login] [DateDuJour] - Création</remarks>
        public CustomerDAL()
            : base(new EformDbContext())
        {
            // [Initiale] - Gestion des liens vers les autres tables
            this.GestionInclude();
        }

        /// <summary>
        /// Constructeur avec paramètre
        /// </summary>
        /// <param name="pContext">Context de base de données</param>
        /// <remarks>[Login] [DateDuJour] - Création</remarks>
        public CustomerDAL(EformDbContext pContext)
            : base(pContext)
        {
            // [Initiale] - Gestion des liens vers les autres tables
            this.GestionInclude();
        }

        #endregion

        #region Include

        /// <summary>
        /// Gestion des liens vers les autres tables
        /// </summary>
        /// <remarks>[Login] [DateDuJour] - Création</remarks>
        private void GestionInclude()
        {
            // Exemple d'include
            //this.Add(p => p.Dossier, this.IncludeDossiers);
        }

        /*/// <summary>
        /// Include des dossiers
        /// </summary>
        /// <param name="pSource">Source</param>
        /// <returns>Include</returns>
        /// <remarks>[Login] [DateDuJour] - Création</remarks>
        private IQueryable<DossierSousCatDTO> IncludeDossiers(IQueryable<DossierSousCatDTO> pSource, Expression<Func<DossierSousCatDTO, object>> arg2, Framework.Domain.Query.SearchCriteria<DossierSousCatDTO> arg3)
        {
            // [Initiale] - Retourne liens
            return pSource.Include(p => p.Dossier);
        }*/

        #endregion

    }
}
