namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using Services;
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public partial class App : Application
	{
		#region constructors and destructors

		public App()
		{
			InitializeComponent();
			InitDependencies();
			MainPage = new AppShell();
		}

		private void InitDependencies()
		{
			DependencyService.Register<ItemsViewModel>();
			DependencyService.Register<NewItemViewModel>();
			DependencyService.Register<ItemDetailViewModel>();
			DependencyService.Register<LoginViewModel>();
			DependencyService.Register<MyViewModel>();
			DependencyService.Register<MockDataStore>();
		}

		#endregion

		#region methods

		protected override void OnResume()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnStart()
		{
		}

		#endregion
	}
}
