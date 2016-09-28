using Demo.Framework.InversionOfControl;
using GalaSoft.MvvmLight.Threading;
using Microsoft.Practices.ServiceLocation;
using System.Windows;

namespace Demo.WPF
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Instance.CInstance AppInstance = new Instance.CInstance();

        protected override void OnStartup(StartupEventArgs e)
        {
            // Initialisation du system
            DispatcherHelper.Initialize();
            //var ltest = new UnityDependencyResolverWPF();
            ServiceLocator.SetLocatorProvider(()=>new UnityDependencyResolverWPF());
            base.OnStartup(e);
        }
    }
}
