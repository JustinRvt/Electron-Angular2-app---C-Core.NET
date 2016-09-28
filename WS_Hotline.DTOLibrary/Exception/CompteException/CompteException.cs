using System;
using System.Runtime.Serialization;
using WS_Hotline.DTOLibrary.Entities.Compte;

namespace WS_Hotline.DTOLibrary.Exception.CompteException
{
    /// <summary>
    /// Exeption sur le Type Compte
    /// </summary>
	/// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
    [Serializable]
    public class CompteException : BaseDTOException<CompteDTO>
    {
        #region Constructeur

		/// <summary>
        /// Constructeur
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public CompteException(): base()
        { }

		 /// <summary>
        /// Constructeur avec message
        /// </summary>
        /// <param name="pMessage">Message de l'exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public CompteException(string pMessage): base(pMessage)
        { }

		/// <summary>
        /// Constructeur avec innner exception, message generer en automatique
        /// </summary>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
		public CompteException(System.Exception pInnrException)
            : base(pInnrException)
        { }

		/// <summary>
        /// Constructeur avec message et inner exception
        /// </summary>
        /// <param name="pMessage">Message</param>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public CompteException(string pMessage, System.Exception pInnrException)
            : base(pMessage, pInnrException)
        { }

		/// <summary>
        /// COnstructeur pour serialisation
        /// </summary>
        /// <param name="pInfo">Info</param>
        /// <param name="pContext">Context</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        protected  CompteException(SerializationInfo pInfo, StreamingContext pContext): base (pInfo,pContext)
        { }

        #endregion
    }
}
		