using Demo.Framework.Domain.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTOLibrary.Entities.Compte
{

	/// <summary>
    /// Classe DTO permettant de gérer Compte
    /// </summary>
    /// <remark>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remark>
    [DataContract]
    [Table("T_COMPTE")]
    public class CompteDTO : BaseDTO
    {
		#region Property
				
		private int _IdCompte;
        /// <summary>
        /// Clé primaire de la table
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Key,Column("ID_COMPTE")] 
		[Required(ErrorMessage = "IdCompte error")]
        public int IdCompte
        {
            get { return _IdCompte; }
            set
            {
                _IdCompte = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IdCompte" });
            }
        }
				
		private string _Compte;
        /// <summary>
        /// Numéro du compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("CPT_COMPTE")]
        public string Compte
        {
            get { return _Compte; }
            set
            {
                _Compte = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Compte" });
            }
        }
				
		private string _Libelle;
        /// <summary>
        /// Libelle du compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("CPT_LIBELLE")]
        public string Libelle
        {
            get { return _Libelle; }
            set
            {
                _Libelle = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Libelle" });
            }
        }
		  
		#endregion
	
		#region Liaison
				
		private ICollection<Ecriture.EcritureDTO> _ListEcriture;
		/// <summary>
		/// Liste de Ecriture
		/// </summary>
		/// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
		[InverseProperty("Compte")]
		[DataMember]
		public ICollection<Ecriture.EcritureDTO> ListEcriture
		{
			get { return _ListEcriture; }
			set
			{
				_ListEcriture = value;
			}
		}

			
		#endregion
    }
}
		