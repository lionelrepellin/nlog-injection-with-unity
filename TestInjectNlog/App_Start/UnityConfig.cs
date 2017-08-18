using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using TestInjectNlog.Logger;

namespace TestInjectNlog.App_Start
{
	/// <summary>
	/// Specifies the Unity configuration for the main container.
	/// </summary>
	public static class UnityConfig
	{
		#region Unity Container
		private static Lazy<IUnityContainer> _container = new Lazy<IUnityContainer>(() =>
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
			return _container.Value;
		}
		#endregion

		/// <summary>Registers the type mappings with the Unity container.</summary>
		/// <param name="container">The unity container to configure.</param>
		/// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
		/// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
		public static void RegisterTypes(IUnityContainer container)
		{
			// TODO: Register your types here		
			container.RegisterType<ILoggerFactory, LoggerFactory>();
		}
	}
}
