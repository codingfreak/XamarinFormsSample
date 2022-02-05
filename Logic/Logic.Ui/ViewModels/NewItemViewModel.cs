namespace Ui.Mobile.ViewModels
{
	using Models;
	using System;
	using System.Linq;
	using Xamarin.Forms;

	public class NewItemViewModel : BaseViewModel
	{
		#region member vars

		private string description;
		private string text;

		#endregion

		#region constructors and destructors

		public NewItemViewModel()
		{
			SaveCommand = new Command(OnSave, ValidateSave);
			CancelCommand = new Command(OnCancel);
			PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
		}

		#endregion

		#region methods

		private async void OnCancel()
		{
			// This will pop the current page off the navigation stack
			await Shell.Current.GoToAsync("..");
		}

		private async void OnSave()
		{
			var newItem = new Item
			{
				Id = Guid.NewGuid()
					.ToString(),
				Text = Text,
				Description = Description
			};
			await DataStore.AddItemAsync(newItem);

			// This will pop the current page off the navigation stack
			await Shell.Current.GoToAsync("..");
		}

		private bool ValidateSave()
		{
			return !String.IsNullOrWhiteSpace(text) && !String.IsNullOrWhiteSpace(description);
		}

		#endregion

		#region properties

		public string Text
		{
			get => text;
			set => SetProperty(ref text, value);
		}

		public string Description
		{
			get => description;
			set => SetProperty(ref description, value);
		}

		public Command SaveCommand { get; }

		public Command CancelCommand { get; }

		#endregion
	}
}
