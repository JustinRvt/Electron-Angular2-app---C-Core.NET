using System;
using System.Runtime.Serialization;
using Demo.DTOLibrary.Entities.Dossier;

namespace Demo.DTOLibrary.Exception.DossierException
{
    /// <summary>
    /// Exeption sur le Type Dossier
    /// </summary>
	/// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
    [Serializable]
    public class DossierException : BaseDTOException<DossierDTO>
    {
        #region Constructeur

		/// <summary>
        /// Constructeur
        /// </summary>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public DossierException(): base()
        { }

		 /// <summary>
        /// Constructeur avec message
        /// </summary>
        /// <param name="pMessage">Message de l'exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public DossierException(string pMessage): base(pMessage)
        { }

		/// <summary>
        /// Constructeur avec innner exception, message generer en automatique
        /// </summary>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
		public DossierException(System.Exception pInnrException)
            : base(pInnrException)
        { }

		/// <summary>
        /// Constructeur avec message et inner exception
        /// </summary>
        /// <param name="pMessage">Message</param>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        public DossierException(string pMessage, System.Exception pInnrException)
            : base(pMessage, pInnrException)
        { }

		/// <summary>
        /// COnstructeur pour serialisation
        /// </summary>
        /// <param name="pInfo">Info</param>
        /// <param name="pContext">Context</param>
        /// <remarks>ylouis - 06/09/2016 - Généré par Template T4 v1.0 </remarks>
        protected  DossierException(SerializationInfo pInfo, StreamingContext pContext): base (pInfo,pContext)
        { }

        #endregion
    }
}
		