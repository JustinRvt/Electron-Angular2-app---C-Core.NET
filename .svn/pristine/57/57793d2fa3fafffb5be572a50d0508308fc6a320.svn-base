using Demo.DataAccessLayer.BDD;
using Demo.DTOLibrary.Entities.Dossier;
using Demo.Framework.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Demo.DataAccessLayer.Entities.Dossier
{
    /// <summary>
    /// Classe data acess layer de Dossier
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class DossierDAL : Repository<DossierDTO, DemoDbContext>
    {
        #region CSTR

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        public DossierDAL()
            : base(new DemoDbContext())
        {
            // yl - Gestion des Lien vers les autres tables
            this.GestionInclude();
        }

        /// <summary>
        /// Constructeur avec paramètre
        /// </summary>
        /// <param name="pContext">Context de base de données</param>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        public DossierDAL(DemoDbContext pContext)
            : base(pContext)
        {
            // yl - Gestion des Lien vers les autres tables
            this.GestionInclude();
        }

        #endregion

        #region Include

        /// <summary>
        /// Gestion des liens vers les autres tables
        /// </summary>
		/// <remarks>ylouis - 06/09/2016 - Création</remarks>
        private void GestionInclude()
        {
		
		    // yl - Lien vers les ListEcriture
            this.Add(p => p.ListEcriture, this.IncludeListEcriture);
					
        }
		
        /// <summary>
        /// Include des ListEcriture
        /// </summary>
        /// <param name="pSource">Source</param>
        /// <returns>Include</returns>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        private IQueryable<DossierDTO> IncludeListEcriture(IQueryable<DossierDTO> pSource, Expression<Func<DossierDTO, object>> arg2, Framework.Domain.Query.SearchCriteria<DossierDTO> arg3)
        {
            // yl - retourne liens
            return pSource.Include(p => p.ListEcriture);
        }

		
        #endregion

    }
}
