using System;
using Cirrious.MvvmCross.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using Cirrious.CrossCore;

namespace MvvmCrossViewModelInitialization
{
	public class BaseViewModel : MvxViewModel
	{
		public const string ParameterName = "SerializedParameterObject";

		protected T LoadViewModel<T> (IMvxBundle parameters) where T : MvxViewModel
		{
			var loaderService = Mvx.Resolve<IMvxViewModelLoader> ();
			MvxViewModelRequest request = new MvxViewModelRequest (typeof(T), parameters, null, null);
			return loaderService.LoadViewModel (request, null /* saved state */) as T;
		}

		protected void ShowViewModel<TViewModel>(object parameter) where TViewModel : IMvxViewModel
		{
			string text = JsonConvert.SerializeObject (parameter, Formatting.Indented, new JsonSerializerSettings () { NullValueHandling = NullValueHandling.Ignore });
			base.ShowViewModel<TViewModel>(new Dictionary<string, string>()
				{
					{ParameterName, text}
				}
			);
		}
	}

	public abstract class BaseViewModel<T> : BaseViewModel
	{
//		protected override void InitFromBundle (IMvxBundle parameters)
//		{
//			if (parameters.Data.ContainsKey (ParameterName)) {
//				Init (parameters.Data [ParameterName]);
//			}
//		}

		protected virtual void Init(string SerializedParameterObject)
		{
			var deserialized = JsonConvert.DeserializeObject<T> (SerializedParameterObject);
			InitWithObject(deserialized);
		}

		protected abstract void InitWithObject(T value);

	}
}