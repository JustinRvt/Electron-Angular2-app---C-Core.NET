using Demo.Framework.Domain.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTOLibrary.Entities.Dossier
{

	/// <summary>
    /// Classe DTO permettant de gérer Dossier
    /// </summary>
    /// <remark>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remark>
    [DataContract]
    [Table("T_DOSSIER")]
    public class DossierDTO : BaseDTO
    {
		#region Property
				
		private int _IdDossier;
        /// <summary>
        /// Clé primaire de la table
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Key,Column("ID_DOSSIER")] 
		[Required(ErrorMessage = "IdDossier error")]
        public int IdDossier
        {
            get { return _IdDossier; }
            set
            {
                _IdDossier = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IdDossier" });
            }
        }
				
		private string _Code;
        /// <summary>
        /// Code du dossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("DO_CODE")]
		[MaxLength(16)] 
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Code" });
            }
        }
				
		private string _Nom;
        /// <summary>
        /// Nom du dossier
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
        [DataMember]
        [Column("DO_NOM")]
		[MaxLength(16)] 
        public string Nom
        {
            get { return _Nom; }
            set
            {
                _Nom = value; 
				ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Nom" });
            }
        }
		  
		#endregion
	
		#region Liaison
				
		private ICollection<Ecriture.EcritureDTO> _ListEcriture;
		/// <summary>
		/// Liste de Ecriture
		/// </summary>
		/// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0</remarks>
		[InverseProperty("Dossier")]
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
		