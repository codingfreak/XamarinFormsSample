namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public class ViewModelLocator
	{
		
		#region properties

		public ItemsViewModel ItemsViewModel => DependencyService.Get<ItemsViewModel>();

		public LoginViewModel LoginViewModel => DependencyService.Get<LoginViewModel>();

		public ItemDetailViewModel ItemDetailViewModel => DependencyService.Get<ItemDetailViewModel>();

		#endregion
	}
}
