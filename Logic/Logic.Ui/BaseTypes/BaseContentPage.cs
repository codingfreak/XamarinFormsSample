namespace codingfreaks.XamarinFormsSample.Logic.Ui.BaseTypes
{
	using System;
	using System.Linq;
	using ViewModels;
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
