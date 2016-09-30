using Demo.Framework.AccesDonnees;
using UnityConfiguration;

namespace Demo.Framework.InversionOfControl
{
    public class ConventionRegistry : UnityRegistry
    {
        /// <summary>
        /// Define convention for IntegrAccor assembly
        /// </summary>
        public ConventionRegistry()
        {
            // On Récupére uniquemement les classes et les interfaces du NameSpace "IntegrAccor"
            this.Scan(
                pScan =>
                {
                    pScan.AssembliesInBaseDirectory(pAssembly => pAssembly.FullName.StartsWith("Demo"));
                    pScan.InternalTypes();
                    pScan.With<MultipleImplementationConvention>()
                           .TypesImplementing( typeof(IEntityConfiguration))
                           .AsSingleton();
                    pScan.With<InterfaceConvention>();
                    pScan.With<ExoCommandConvention>();
                });
        }
    }
}