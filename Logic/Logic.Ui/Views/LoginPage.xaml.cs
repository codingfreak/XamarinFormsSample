namespace Ui.Mobile.Views
{
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;
	using Xamarin.Forms.Xaml;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		#region constructors and destructors

		public LoginPage()
		{
			InitializeComponent();
			BindingContext = new LoginViewModel();
		}

		#endregion
	}
}
