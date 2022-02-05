namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using BaseTypes;
	using Models;
	using System;
	using System.Diagnostics;
	using System.Linq;
	using Xamarin.Forms;

	[QueryProperty(nameof(ItemId), nameof(ItemId))]
	public class ItemDetailViewModel : BaseViewModel
	{
		#region methods

		public async void LoadItemId(string itemId)
		{
			try
			{
				Item = await DataStore.GetItemAsync(itemId);
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to Load Item");
			}
		}

		#endregion

		#region properties

		public Item Item { get; set; }

		public string ItemId
		{
			get => Item?.Id;
			set => LoadItemId(value);
		}

		#endregion
	}
}
