using Demo.DTOLibrary.Business.Navigation;
using Demo.DTOLibrary.Entities.Ecriture;
using Demo.DTOLibrary.Enum.Module;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WPF.Instance
{
    /// <summary>
    /// Instance de l'application
    /// </summary>
    public class CInstance
    {
        #region Constructeur

        /// <summary>
        /// COnstriucteur
        /// </summary>
        /// <remarks>LOUIS Yoann 06/09/2016</remarks>
        public CInstance()
        {
            // yl - gestion des abonnement
            GestionAbonnement();
        }

        #endregion

        #region Methode

        /// <summary>
        /// Gestion de la navigation
        /// </summary>
        /// <remarks>LOUIS Yoann 06/09/2016</remarks>
        private void GestionNavigationEcriture(NavigationDTO<EcritureDTO> pNavigation)
        {
            // yl - On renvoie vers l'auter ecran
            Messenger.Default.Send<EModule>(pNavigation.Module);
           // yl - On passe l'object en paramettre
           Messenger.Default.Send<EcritureDTO>(pNavigation.ObjectDTO);
           
        }

        #region Register

        /// <summary>
        /// Gestion des abonnement
        /// </summary>
        /// <remarks>LOUIS Yoann 06/09/2016</remarks>
        private void GestionAbonnement()
        {
            Messenger.Default.Register<NavigationDTO<EcritureDTO>>(this, GestionNavigationEcriture);
        }

        #endregion

        #endregion
    }
}
