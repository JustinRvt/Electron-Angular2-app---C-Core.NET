using Demo.Framework.Domain.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTOLibrary.Entities.Ecriture
{

	/// <summary>
    /// Classe DTO permettant de gérer Ecriture
    /// </summary>
    /// <remark>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remark>
    [DataContract]
    [Table("T_ECRITURE")]
    public class EcritureDTO : BaseDTO
    {
		#region Property
				
		private int _IdEcriture;
        /// <summary>
        /// Clé primaire de la table
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Key,Column("ID_ECRITURE")] 
		[Required(ErrorMessage = "IdEcriture error")]
        public int IdEcriture
        {
            get { return _IdEcriture; }
            set
            {
                _IdEcriture = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IdEcriture" });
            }
        }
				
		private double? _Credit;
        /// <summary>
        /// Montant au crédit
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("ERC_CREDIT")] 
        public double? Credit
        {
            get { return _Credit; }
            set
            {
                _Credit = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Credit" });
            }
        }
				
		private double? _Debit;
        /// <summary>
        /// Montant au débit
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("ERC_DEBIT")] 
        public double? Debit
        {
            get { return _Debit; }
            set
            {
                _Debit = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Debit" });
            }
        }
				
		private string _Journal;
        /// <summary>
        /// Journal
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("ERC_JOURNAL")]
		[MaxLength(16)] 
        public string Journal
        {
            get { return _Journal; }
            set
            {
                _Journal = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Journal" });
            }
        }
				
		private int? _IdCompte;
        /// <summary>
        /// ID du compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("ID_COMPTE")] 
        public int? IdCompte
        {
            get { return _IdCompte; }
            set
            {
                _IdCompte = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IdCompte" });
            }
        }
				
		private int? _IdDossier;
        /// <summary>
        /// ID du dossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("ID_DOSSIER")] 
        public int? IdDossier
        {
            get { return _IdDossier; }
            set
            {
                _IdDossier = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IdDossier" });
            }
        }


 
        /// <summary>
        /// Montant
        /// </summary>
        /// <remarks>ylouis - 06/09/2016</remarks>
        [DataMember]
        [NotMapped]
        public double Montant
        {
            get { return (Credit.HasValue ? Credit.Value : 0.00) - (Debit.HasValue ? Debit.Value : 0.00); }
            set
            {
                Debit = value < 0 ? - value : 0;
                Credit = value > 0 ? value : 0;
            }
        }
		  
		#endregion
	
		#region Liaison
				
		private Compte.CompteDTO _Compte;
        /// <summary>
        /// Liens vers Compte
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [ForeignKey("IdCompte")]
		[DataMember]
        public Compte.CompteDTO Compte
        {
            get { return _Compte; }
            set
            {
                _Compte = value;
            }
        }
				
		private Dossier.DossierDTO _Dossier;
        /// <summary>
        /// Liens vers Dossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [ForeignKey("IdDossier")]
		[DataMember]
        public Dossier.DossierDTO Dossier
        {
            get { return _Dossier; }
            set
            {
                _Dossier = value;
            }
        }
			
		#endregion
    }
}
		