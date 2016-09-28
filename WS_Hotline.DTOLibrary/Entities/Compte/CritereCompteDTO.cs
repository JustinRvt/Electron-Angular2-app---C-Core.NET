using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WS_Hotline.DTOLibrary.Entities.Compte
{
    /// <summary>
    /// Classe de critère pour CompteDTO
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
    public class CritereCompteDTO : CritereBaseDTO<CompteDTO>
    {
        #region Property
		
		private int _IdCompte;
        /// <summary>
        /// Filtre sur IdCompte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public int IdCompte
        {
            get { return _IdCompte; }
            set
            {
                _IdCompte = value;
                // yl - Mise en place du filtre
                this.Filters["IdCompte"] = p => p.IdCompte == _IdCompte;
            }
        }
		
		private string _Compte;
        /// <summary>
        /// Filtre sur Compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public string Compte
        {
            get { return _Compte; }
            set
            {
                _Compte = value;
                // yl - Mise en place du filtre
                if (string.IsNullOrEmpty(_Compte)==false)
					this.Filters["Compte"] = p => p.Compte.StartsWith(_Compte);
            }
        }
		
		private string _Libelle;
        /// <summary>
        /// Filtre sur Libelle
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public string Libelle
        {
            get { return _Libelle; }
            set
            {
                _Libelle = value;
                // yl - Mise en place du filtre
                if (string.IsNullOrEmpty(_Libelle)==false)
					this.Filters["Libelle"] = p => p.Libelle.StartsWith(_Libelle);
            }
        }
		  
		#endregion
	
		#region Liaison
		
		private bool _TakeListEcriture;
        /// <summary>
        /// Prendre ListEcriture
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public bool TakeListEcriture
        {
            get { return _TakeListEcriture; }
            set
            {
                _TakeListEcriture = value;
                // yl - indique qu'il faut prendre Ecriture
                if (_TakeListEcriture)
                    this.Include(p => p.ListEcriture);
            }
		}

		
        #endregion
    }
}

		