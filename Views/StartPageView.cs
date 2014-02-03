using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmCrossViewModelInitialization.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class StartPageView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.StartPage);
		}
    }
}