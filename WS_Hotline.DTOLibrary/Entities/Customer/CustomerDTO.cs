using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WS_Hotline.Framework.Domain.Command;

namespace WS_Hotline.DTOLibrary.Entities.User
{
    /// <summary>
    /// Classe DTO permettant de gérer Objet
    /// </summary>
    /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
    [DataContract]
    [Table("V_HOTLINE_CONTACT_ACTIF")]
    public class CustomerDTO : BaseDTO
    {
        #region property

        private string _CustomerPhone;
        /// <summary>
        /// Téléphone client actif
        /// </summary>
        /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
        [DataMember]
        [Column("MainInvoicingContact_Phone")]
        [Required(ErrorMessage = "Customer Phone error")]
        [MaxLength(40)]
        public string  CustomerPhone
        {
            get { return _CustomerPhone; }
            set
            {
                _CustomerPhone = value;
                ValidateProperty(value, new ValidationContext(this, null, null)
                {
                    MemberName = "CustomerPhone"
                });
            }
        }

        private string _CustomerName;
        /// <summary>
        /// Nom de famille client actif
        /// </summary>
        /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
        [DataMember]
        [Column("MainInvoicingContact_Name")]
        [Required(ErrorMessage = "Customer Last Name Error")]
        [MaxLength(40)]
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                _CustomerName = value;
                ValidateProperty(value, new ValidationContext(this, null, null)
                {
                    MemberName = "CustomerName"
                });
            }
        }


        private string _CustomerFirstName;
        /// <summary>
        /// Prénom client actif
        /// </summary>
        /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
        [DataMember]
        [Column("MainInvoicingContact_FirstName")]
        [Required(ErrorMessage = "CustomeFirst Name Error")]
        [MaxLength(40)]
        public string CustomerFirstName
        {
            get { return _CustomerFirstName; }
            set
            {
                _CustomerFirstName = value;
                ValidateProperty(value, new ValidationContext(this, null, null)
                {
                    MemberName = "CustomerFirstName"
                });
            }
        }

        #endregion

        #region Liaison

        #endregion
    }
}
