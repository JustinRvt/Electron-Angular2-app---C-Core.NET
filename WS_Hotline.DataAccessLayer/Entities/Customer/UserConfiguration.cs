using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Hotline.DTOLibrary.Entities.User;
using WS_Hotline.Framework.AccesDonnees;

namespace WS_Hotline.DataAccessLayer.Entities.Customer
{
    /// <summary>
    /// Classe de configuration de NameDTO
    /// </summary>
    /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
    public class NameConfiguration : EntityTypeConfiguration<CustomerDTO>, IEntityConfiguration
    {
        #region METHODS

        /// <summary>
        /// Méthode permettant d'ajouter le registre de configuration
        /// </summary>
        /// <param name="pRegistrar">Registre de configuration à ajouter</param>
        /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
        public void Add(ConfigurationRegistrar pRegistrar)
        {
            pRegistrar.Add(this);
        }

        #endregion
    }
}
