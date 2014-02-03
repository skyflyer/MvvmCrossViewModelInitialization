using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;
using Newtonsoft.Json;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Views;
using System.Collections.Generic;

namespace MvvmCrossViewModelInitialization
{
	[Activity (
		Label = "MvvmCrossViewModelInitialization"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen () : base (Resource.Layout.SplashScreen)
		{
		}

		// testing some logic to start with a different view model based on runtime decisions
//		protected override void TriggerFirstNavigate ()
//		{
//			var dispatcher = Mvx.Resolve<IMvxViewDispatcher> ();
//
//			ComplexObjectType theObject = new ComplexObjectType () {
//				Foo = "foo",
//				Child = new NestedObjectType () {
//					Foobar = "bam baz"
//				}
//			};
//
//			string serialized = JsonConvert.SerializeObject (theObject, Formatting.None, new JsonSerializerSettings () { NullValueHandling = NullValueHandling.Ignore });
//
//			MvxBundle bundle = new MvxBundle (new Dictionary<string, string> () {
//				{ BaseViewModel.ParameterName, serialized }
//			});
//			dispatcher.ShowViewModel (new MvxViewModelRequest (typeof(StartPageViewModel), bundle, null, null));
//		}
	}
}