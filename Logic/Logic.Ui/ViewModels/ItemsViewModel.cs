namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using Models;
	using System;
	using System.Collections.ObjectModel;
	using System.Diagnostics;
	using System.Linq;
	using System.Threading.Tasks;
	using Views;
	using Xamarin.Forms;

	public class ItemsViewModel : BaseViewModel
	{
		#region member vars

		private Item _selectedItem;

		#endregion

		#region constructors and destructors

		public ItemsViewModel()
		{
			Title = "Browse";
			Items = new ObservableCollection<Item>();
			LoadItemsCommand = new Command(async () => await LoadItemsAsync());
			ItemTapped = new Command<Item>(OnItemSelected);
			AddItemCommand = new Command(OnAddItem);

		}

		#endregion

		#region methods

		public override void OnAppearing()
		{
			IsBusy = true;
			SelectedItem = null;
		}

		private async Task LoadItemsAsync()
		{
			IsBusy = true;
			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				foreach (var item in items)
				{
					Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}

		private async void OnAddItem(object obj)
		{
			await Shell.Current.GoToAsync(nameof(NewItemPage));
		}

		private async void OnItemSelected(Item item)
		{
			if (item == null)
			{
				return;
			}

			// This will push the ItemDetailPage onto the navigation stack
			await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
		}

		#endregion

		#region properties

		public ObservableCollection<Item> Items { get; }

		public Command LoadItemsCommand { get; }

		public Command AddItemCommand { get; }

		public Command<Item> ItemTapped { get; }

		public Item SelectedItem
		{
			get => _selectedItem;
			set
			{
				SetProperty(ref _selectedItem, value);
				OnItemSelected(value);
			}
		}

		#endregion
	}
}
