using System;
using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;
using Cirrious.CrossCore;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MvvmCrossViewModelInitialization
{
	public class StartPageViewModel : MvxViewModel
	{
		public LoginViewModel Login { get; set; }

//		protected override void InitFromBundle (IMvxBundle parameters)
//		{
//			Login = LoadViewModel<LoginViewModel> (parameters);
//		}
//
//		protected void Init(string SerializedParameterObject)
//		{
//			// this call does not happen!
//			Mvx.Trace (Cirrious.CrossCore.Platform.MvxTraceLevel.Diagnostic, "Did call into the Init");
//		}

		public ICommand DoIt { 
			get {
				return new MvxCommand(() => {
					ComplexObjectType theObject = new ComplexObjectType () {
						Foo = "for second",
						Child = new NestedObjectType () {
							Foobar = "bam baz"
						}
					};

					string serialized = JsonConvert.SerializeObject (theObject, Formatting.None, new JsonSerializerSettings () { NullValueHandling = NullValueHandling.Ignore });

					var bundle = new Dictionary<string, string> () {
						{ "parameter", serialized }
					};
					ShowViewModel<SecondViewModel>(bundle);
				});
			} 
		}

		public ICommand DoIt2 { 
			get {
				return new MvxCommand(() => {
					var detail = new DetailParameters() { Index = 42 };
					ShowViewModel<SecondViewModel>(detail);
				});
			} 
		}

		public ICommand DoIt3 { 
			get {
				return new MvxCommand(() => {
					ComplexObjectType theObject = new ComplexObjectType () {
						Foo = "for second",
						Child = new NestedObjectType () {
							Foobar = "bam baz"
						}
					};

					string serialized = JsonConvert.SerializeObject (theObject, Formatting.None, new JsonSerializerSettings () { NullValueHandling = NullValueHandling.Ignore });

					var bundle = new MvxBundle(new Dictionary<string, string> () {
						{ "parameter", serialized }
					});
					ShowViewModel<SecondViewModel>(bundle, null, null);
				});
			} 
		}

		public ICommand DoIt4 { 
			get {
				return new MvxCommand(() => {
					ShowViewModel<SecondViewModel>(new { Index = 42 }, null, null);
				});
			} 
		}
	}
}

