using System;
using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;
using Cirrious.CrossCore;
using System.Windows.Input;

namespace MvvmCrossViewModelInitialization
{
	public class DetailParameters
	{
		public int Index { get; set; }
	}

	public class SecondViewModel : MvxViewModel
	{

		protected override void InitFromBundle (IMvxBundle parameters)
		{
			base.InitFromBundle (parameters);
		}

		protected void Init(string parameter)
		{
			// this call does not happen!
			Mvx.Trace (Cirrious.CrossCore.Platform.MvxTraceLevel.Diagnostic, "Did call into the Init");
		}

		protected void Init(DetailParameters parameters)
		{
			// this call does not happen!
			Mvx.Trace (Cirrious.CrossCore.Platform.MvxTraceLevel.Diagnostic, "Did call into the Init");
		}

		protected void Init(int Index)
		{
			// this call does not happen!
			Mvx.Trace (Cirrious.CrossCore.Platform.MvxTraceLevel.Diagnostic, "Did call into the Init");
		}

		private string _second;

		public string Second {
			get { return _second; }
			set {
				_second = value;
				RaisePropertyChanged (() => Second);
			}
		}
	}
}

