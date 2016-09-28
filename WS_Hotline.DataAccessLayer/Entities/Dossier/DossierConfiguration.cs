﻿using Demo.DTOLibrary.Entities.Dossier;
using Demo.Framework.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccessLayer.Entities.Dossier
{
    /// <summary>
    /// Classe de configuration de DossierDTO
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
    public class DossierConfiguration : EntityTypeConfiguration<DossierDTO>, IEntityConfiguration
    {
        #region METHODS

        /// <summary>
        /// Méthode permettant d'ajouter le registre de configuration
        /// </summary>
        /// <param name="pRegistrar">Registre de configuration à ajouter</param>
        /// <remarks>ylouis - 06/09/2016 - Création</remarks>
        public void Add(ConfigurationRegistrar pRegistrar)
        {
            pRegistrar.Add(this);
        }

        #endregion
    }
}

		