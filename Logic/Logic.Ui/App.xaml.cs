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
			// register data store
			builder.RegisterType<MockDataStore>().As<IDataStore<Item>>().SingleInstance();
			// register all view model types
			foreach (var viewModelType in ReflectionHelper.ViewModelTypes)
			{
				builder.RegisterType(viewModelType).AsSelf();
			}
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
