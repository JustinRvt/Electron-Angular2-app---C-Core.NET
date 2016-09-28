using WS_Hotline.DataAccessLayer.Entities.Ecriture;
using WS_Hotline.DTOLibrary.Entities.Ecriture;
using WS_Hotline.DTOLibrary.Exception.EcritureException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Hotline.DomainLibrary.Metier.Ecriture
{
    /// <summary>
    /// Classe metier de Ecriture
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class EcritureMetier : BaseMetier<EcritureDAL, EcritureDTO, CritereEcritureDTO,EcritureException>
    {

		#region Validation

        /// <summary>
        /// Validation de la Ecriture
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
                throw new EcritureException(ex);
            }
        }

        #endregion

    }
}
		