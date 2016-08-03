using System;
using HttpClientHelpers;
using Microsoft.Practices.Unity;
using Repositories;

namespace WebApp
{
    /// <summary>
    /// Specifies the Unity configuration for the main _container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity _container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity _container.</summary>
        /// <param name="container">The unity _container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // _container.LoadConfiguration();
            
            container.RegisterType<IRepository, GitHubRepository>();
            container.RegisterType<IHttpClientHelper, GitHubHttpClientHelper>();
        }
    }
}
