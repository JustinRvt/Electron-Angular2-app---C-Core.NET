using Demo.DataAccessLayer.BDD;
using Demo.DTOLibrary.Entities.Ecriture;
using Demo.Framework.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Demo.DataAccessLayer.Entities.Ecriture
{
    /// <summary>
    /// Classe data acess layer de Ecriture
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class EcritureDAL : Repository<EcritureDTO, DemoDbContext>
    {
        #region CSTR

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        public EcritureDAL()
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
        public EcritureDAL(DemoDbContext pContext)
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
		
		    // yl - Lien vers les Compte
            this.Add(p => p.Compte, this.IncludeCompte);
			
		    // yl - Lien vers les Dossier
            this.Add(p => p.Dossier, this.IncludeDossier);
					
        }
		
        /// <summary>
        /// Include des Compte
        /// </summary>
        /// <param name="pSource">Source</param>
        /// <returns>Include</returns>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        private IQueryable<EcritureDTO> IncludeCompte(IQueryable<EcritureDTO> pSource, Expression<Func<EcritureDTO, object>> arg2, Framework.Domain.Query.SearchCriteria<EcritureDTO> arg3)
        {
            // yl - retourne liens
            return pSource.Include(p => p.Compte);
        }

		
        /// <summary>
        /// Include des Dossier
        /// </summary>
        /// <param name="pSource">Source</param>
        /// <returns>Include</returns>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        private IQueryable<EcritureDTO> IncludeDossier(IQueryable<EcritureDTO> pSource, Expression<Func<EcritureDTO, object>> arg2, Framework.Domain.Query.SearchCriteria<EcritureDTO> arg3)
        {
            // yl - retourne liens
            return pSource.Include(p => p.Dossier);
        }

		
        #endregion

    }
}
