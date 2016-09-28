using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTOLibrary.Entities.Ecriture
{
    /// <summary>
    /// Classe de critère pour EcritureDTO
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
    public class CritereEcritureDTO : CritereBaseDTO<EcritureDTO>
    {
        #region Property
		
		private int? _IdEcriture;
        /// <summary>
        /// Filtre sur IdEcriture
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public int? IdEcriture
        {
            get { return _IdEcriture; }
            set
            {
                _IdEcriture = value;
                // yl - Mise en place du filtre
                this.Filters["IdEcriture"] = p => p.IdEcriture == _IdEcriture;
            }
        }
		
		private double? _Credit;
        /// <summary>
        /// Filtre sur Credit
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public double? Credit
        {
            get { return _Credit; }
            set
            {
                _Credit = value;
                // yl - Mise en place du filtre
                if (_Credit != null)
					this.Filters["Credit"] = p => p.Credit == _Credit;
            }
        }
		
		private double? _Debit;
        /// <summary>
        /// Filtre sur Debit
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public double? Debit
        {
            get { return _Debit; }
            set
            {
                _Debit = value;
                // yl - Mise en place du filtre
                if (_Debit != null)
					this.Filters["Debit"] = p => p.Debit == _Debit;
            }
        }
		
		private string _Journal;
        /// <summary>
        /// Filtre sur Journal
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public string Journal
        {
            get { return _Journal; }
            set
            {
                _Journal = value;
                // yl - Mise en place du filtre
                if (string.IsNullOrEmpty(_Journal)==false)
					this.Filters["Journal"] = p => p.Journal.StartsWith(_Journal);
            }
        }
		
		private int? _IdCompte;
        /// <summary>
        /// Filtre sur IdCompte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public int? IdCompte
        {
            get { return _IdCompte; }
            set
            {
                _IdCompte = value;
                // yl - Mise en place du filtre
                if (_IdCompte != null)
					this.Filters["IdCompte"] = p => p.IdCompte == _IdCompte;
            }
        }
		
		private int? _IdDossier;
        /// <summary>
        /// Filtre sur IdDossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public int? IdDossier
        {
            get { return _IdDossier; }
            set
            {
                _IdDossier = value;
                // yl - Mise en place du filtre
                if (_IdDossier != null)
					this.Filters["IdDossier"] = p => p.IdDossier == _IdDossier;
            }
        }
		  
		#endregion
	
		#region Liaison
		
		private bool _TakeCompte;
        /// <summary>
        /// Prendre Compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public bool TakeCompte
        {
            get { return _TakeCompte; }
            set
            {
                _TakeCompte = value;
                // yl - indique qu'il faut prendre Compte
                if (_TakeCompte)
                    this.Include(p => p.Compte);
            }
		}

		
		private bool _TakeDossier;
        /// <summary>
        /// Prendre Dossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public bool TakeDossier
        {
            get { return _TakeDossier; }
            set
            {
                _TakeDossier = value;
                // yl - indique qu'il faut prendre Dossier
                if (_TakeDossier)
                    this.Include(p => p.Dossier);
            }
		}

		
        #endregion
    }
}

		