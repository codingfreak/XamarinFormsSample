namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using BaseTypes;
	using Interfaces;
	using Models;
	using System;
	using System.Linq;
	using Xamarin.Forms;

	public class NewItemViewModel : BaseViewModel
	{
		#region member vars

		private Item _item;

		#endregion

		#region constructors and destructors

		public NewItemViewModel(IDataStore<Item> dataSource)
		{
			DataStore = dataSource;
			SaveCommand = new Command(OnSave, () => Item.IsValid);
			CancelCommand = new Command(OnCancel);
			Item = new Item();
			Item.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
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
			await DataStore.AddItemAsync(Item);

			// This will pop the current page off the navigation stack
			await Shell.Current.GoToAsync("..");
		}

		#endregion

		#region properties

		public Item Item { get; set; }

		public Command SaveCommand { get; }

		public Command CancelCommand { get; }

		private IDataStore<Item> DataStore { get; }

		#endregion
	}
}
