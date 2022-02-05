namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public class ViewModelLocator
	{
		#region properties

		public ItemsViewModel ItemsViewModel => DependencyService.Get<ItemsViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public LoginViewModel LoginViewModel => DependencyService.Get<LoginViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public ItemDetailViewModel ItemDetailViewModel => DependencyService.Get<ItemDetailViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public NewItemViewModel NewItemViewModel => DependencyService.Get<NewItemViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public MyViewModel MyViewModel => DependencyService.Get<MyViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		#endregion
	}
}
