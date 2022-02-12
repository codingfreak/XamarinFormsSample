namespace codingfreaks.XamarinFormsSample.Logic.Mvvm.BaseTypes
{
	using System;
	using System.Linq;
	using Xamarin.Forms;

	public abstract class BaseContentPage : ContentPage
	{
		#region methods

		/// <inheritdoc />
		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (BindingContext is BaseViewModel viewModel)
			{
				viewModel.OnAppearing();
			}
		}

		#endregion
	}
}
