using WS_Hotline.DataAccessLayer.Entities.Dossier;
using WS_Hotline.DTOLibrary.Entities.Dossier;
using WS_Hotline.DTOLibrary.Exception.DossierException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Hotline.DomainLibrary.Metier.Dossier
{
    /// <summary>
    /// Classe metier de Dossier
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class DossierMetier : BaseMetier<DossierDAL, DossierDTO, CritereDossierDTO,DossierException>
    {

		#region Validation

        /// <summary>
        /// Validation de la Dossier
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
                throw new DossierException(ex);
            }
        }

        #endregion

    }
}
		