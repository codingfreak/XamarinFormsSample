namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using BaseTypes;
	using System;
	using System.Linq;
	using Views;
	using Xamarin.Forms;

	public class LoginViewModel : BaseViewModel
	{
		#region constructors and destructors

		public LoginViewModel()
		{
			LoginCommand = new Command(OnLoginClicked);
		}

		#endregion

		#region methods

		private async void OnLoginClicked(object obj)
		{
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
			await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
		}

		#endregion

		#region properties

		public Command LoginCommand { get; }

		#endregion
	}
}
