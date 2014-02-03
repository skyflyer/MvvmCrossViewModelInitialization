using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.IoC;

namespace MvvmCrossViewModelInitialization.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart<StartPageViewModel>();

			// load plugins
			// using Newtonsoft.Json
			//Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
		}
	}
}

