namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using Autofac;
	using codingfreaks.XamarinFormsSample.Logic.Ui.Models;
	using Helpers;
	using Interfaces;
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
			var builder = new ContainerBuilder();
			builder.RegisterType<MockDataStore>().As<IDataStore<Item>>().SingleInstance();
			builder.RegisterType<ItemsViewModel>().AsSelf();
			builder.RegisterType<NewItemViewModel>().AsSelf();
			builder.RegisterType<ItemDetailViewModel>().AsSelf();
			builder.RegisterType<MyViewModel>().AsSelf();
			builder.RegisterType<ItemsViewModel>().AsSelf();
			SharedResources.DependencyContainer = builder.Build();
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
