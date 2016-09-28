using GalaSoft.MvvmLight;
using WPF.Model;

namespace WPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        #region Property

        private List<Demo.DTOLibrary.Entities.Dossier.DossierDTO> _ListeDossier;
        /// <summary>
        /// Liste de dossier
        /// </summary>
        /// <remarks>ylouis - 08/07/2016 - Généré par snippet v1.0</remarks>
        public List<Demo.DTOLibrary.Entities.Dossier.DossierDTO> ListeDossier
        {
            get
            {
                return this._ListeDossier;
            }
            set
            {
                this._ListeDossier = value;
                RaisePropertyChanged(ListeDossier);
            }
        }

        private Demo.DTOLibrary.Entities.Dossier.CritereDossierDTO _CritereDossier;
        /// <summary>
        /// CritereDossier
        /// </summary>
        /// <remarks>ylouis - 08/07/2016 - Généré par snippet v1.0</remarks>
        public Demo.DTOLibrary.Entities.Dossier.CritereDossierDTO CritereDossier
        {
            get
            {
                return this._CritereDossier;
            }
            set
            {
                this._CritereDossier = value;
                OnPropertyChanged("CritereDossier");
            }
        }



        #endregion

        #region Constructeur

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
           
        }

        #endregion

        #region Methode

        

        #endregion

    }
}