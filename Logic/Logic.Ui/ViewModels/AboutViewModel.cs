namespace Ui.Mobile.ViewModels
{
	using System;
	using System.Linq;
	using System.Windows.Input;
	using Xamarin.Essentials;
	using Xamarin.Forms;

	public class AboutViewModel : BaseViewModel
	{
		#region constructors and destructors

		public AboutViewModel()
		{
			Title = "About";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
		}

		#endregion

		#region properties

		public ICommand OpenWebCommand { get; }

		#endregion
	}
}
