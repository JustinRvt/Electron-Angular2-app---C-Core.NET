using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTOLibrary.Entities.Dossier
{
    /// <summary>
    /// Classe de critère pour DossierDTO
    /// </summary>
    /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
    public class CritereDossierDTO : CritereBaseDTO<DossierDTO>
    {
        #region Property
		
		private int _IdDossier;
        /// <summary>
        /// Filtre sur IdDossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public int IdDossier
        {
            get { return _IdDossier; }
            set
            {
                _IdDossier = value;
                // yl - Mise en place du filtre
                this.Filters["IdDossier"] = p => p.IdDossier == _IdDossier;
            }
        }
		
		private string _Code;
        /// <summary>
        /// Filtre sur Code
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                // yl - Mise en place du filtre
                if (string.IsNullOrEmpty(_Code)==false)
					this.Filters["Code"] = p => p.Code.StartsWith(_Code);
            }
        }
		
		private string _Nom;
        /// <summary>
        /// Filtre sur Nom
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        public string Nom
        {
            get { return _Nom; }
            set
            {
                _Nom = value;
                // yl - Mise en place du filtre
                if (string.IsNullOrEmpty(_Nom)==false)
					this.Filters["Nom"] = p => p.Nom.StartsWith(_Nom);
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

		