using System;
using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;
using Cirrious.CrossCore;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MvvmCrossViewModelInitialization
{
	public class StartPageViewModel : BaseViewModel
	{
		public LoginViewModel Login { get; set; }

		protected override void InitFromBundle (IMvxBundle parameters)
		{
			Login = LoadViewModel<LoginViewModel> (parameters);
		}

		protected void Init(string SerializedParameterObject)
		{
			// this call does not happen!
			Mvx.Trace (Cirrious.CrossCore.Platform.MvxTraceLevel.Diagnostic, "Did call into the Init");
		}

		public ICommand DoIt { 
			get {
				ComplexObjectType theObject = new ComplexObjectType () {
					Foo = "for second",
					Child = new NestedObjectType () {
						Foobar = "bam baz"
					}
				};

				string serialized = JsonConvert.SerializeObject (theObject, Formatting.None, new JsonSerializerSettings () { NullValueHandling = NullValueHandling.Ignore });

				MvxBundle bundle = new MvxBundle (new Dictionary<string, string> () {
					{ "parameter", serialized }
				});

				return new MvxCommand(() => ShowViewModel<SecondViewModel>(bundle));
			} 
		}
	}
}

