using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmCrossViewModelInitialization.Views
{
    [Activity(Label = "View for FirstViewModel")]
	public class SecondView : MvxActivity
    {
		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.SecondView);
		}
    }
}