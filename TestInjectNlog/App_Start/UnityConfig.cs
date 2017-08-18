using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using TestInjectNlog.Logger;
using NLog;

namespace TestInjectNlog.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var unityContainer = new UnityContainer();
            RegisterTypes(unityContainer);
            return unityContainer;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
			// NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
			// container.LoadConfiguration();

			// TODO: Register your types here
			// container.RegisterType<IProductRepository, ProductRepository>();

			//ILogger logger = new InjectionFactory(x => LogManager.GetLogger(typeof(this))));
			//7:             .Register<MyClassWithLoggerDependency>()

			//container.RegisterType<ILogger>(new InjectionFactory(x => LogManager.GetLogger("pouet")));

			//var x = typeof(this);

							//.Register<MyClassWithLoggerDependency>();

			container.RegisterType<ILoggerService, LoggerService>();
        }
    }
}