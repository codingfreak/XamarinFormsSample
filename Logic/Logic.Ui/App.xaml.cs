namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using Services;
	using System;
	using System.Linq;
	using Xamarin.Forms;

	public partial class App : Application
	{
		#region constructors and destructors

		public App()
		{
			InitializeComponent();
			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
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
