using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WS_Hotline.DTOLibrary.Entities.User;

namespace WS_Hotline.DTOLibrary.Entities.Phone
{
    /// <summary>
    /// Classe de critère pour CustomerDTO
    /// </summary>
    /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
    public class CritereCustomerDTO : CritereBaseDTO<CustomerDTO>
    {
        #region property

        private string _CustomerName;
        /// <summary>
        /// Recherche par nom
        /// </summary>
        /// <remark>[jravat] - [29092016] - Généré par snippet v1.0</remark>
        [DataMember]
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                _CustomerName = value;
                // [Initiale] - Mise en place du filtre
                if (_CustomerName != null)
                    this.Filters["Nom"] = p => Expression;
            }
        }
        #endregion

        #region Liaison

        #endregion
    }
}
