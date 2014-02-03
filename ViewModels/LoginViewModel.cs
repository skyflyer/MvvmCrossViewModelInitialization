using System;
using System.Diagnostics;

namespace MvvmCrossViewModelInitialization
{
	public class LoginViewModel : BaseViewModel<ComplexObjectType>
	{
		#region implemented abstract members of BaseViewModel
		protected override void InitWithObject (ComplexObjectType value)
		{
			// abrakadabra! it works
			Debug.Assert (value != null);
			Debug.Assert (value.Foo != null);
			Debug.Assert (value.Child != null);
		}
		#endregion


		private string _name;
		public string Name {
			get { return _name; }
			set {
				_name = value;
				RaisePropertyChanged (() => Name);
			}
		}
	}
}

