using Demo.DataAccessLayer.Entities.Compte;
using Demo.DTOLibrary.Entities.Compte;
using Demo.DTOLibrary.Exception.CompteException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DomainLibrary.Metier.Compte
{
    /// <summary>
    /// Classe metier de Compte
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class CompteMetier : BaseMetier<CompteDAL, CompteDTO, CritereCompteDTO,CompteException>
    {

		#region Validation

        /// <summary>
        /// Validation de la Compte
        /// </summary>
        /// <param name="pEntity">Entité a valider</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        public override void ValidatedDTO(Framework.AccesDonnees.IBaseDTO pEntity)
        {
            try
            {
                base.ValidatedDTO(pEntity);
            }
            catch(Exception ex)
            {
                throw new CompteException(ex);
            }
        }

        #endregion

    }
}
		