using Demo.DataAccessLayer.Entities.User;
using Demo.DTOLibrary.Entities.User;
using Demo.DTOLibrary.Exception.UserException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DomainLibrary.Metier.User
{
    /// <summary>
    /// Classe metier de User
    /// </summary>
    /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0</remarks>
    public class UserMetier : BaseMetier<UserDAL, UserDTO, CritereUserDTO,UserException>
    {

		#region Validation

        /// <summary>
        /// Validation de la User
        /// </summary>
        /// <param name="pEntity">Entité a valider</param>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0</remarks>
        public override void ValidatedDTO(Framework.AccesDonnees.IBaseDTO pEntity)
        {
            try
            {
                base.ValidatedDTO(pEntity);
            }
            catch(Exception ex)
            {
                throw new UserException(ex);
            }
        }

        #endregion

    }
}
		