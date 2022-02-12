namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using Autofac;
	using Helpers;
	using System;
	using System.Linq;
	using ViewModels;

	public class ViewModelLocator
	{
		#region properties

		public ItemsViewModel ItemsViewModel => SharedResources.DependencyContainer.Resolve<ItemsViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public LoginViewModel LoginViewModel => SharedResources.DependencyContainer.Resolve<LoginViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public ItemDetailViewModel ItemDetailViewModel => SharedResources.DependencyContainer.Resolve<ItemDetailViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public NewItemViewModel NewItemViewModel => SharedResources.DependencyContainer.Resolve<NewItemViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		public MyViewModel MyViewModel => SharedResources.DependencyContainer.Resolve<MyViewModel>() ?? throw new ApplicationException("No viewmodel found in DI.");

		#endregion
	}
}
