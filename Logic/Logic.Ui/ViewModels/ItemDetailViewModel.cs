namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using System;
	using System.Diagnostics;
	using System.Linq;
	using Xamarin.Forms;

	[QueryProperty(nameof(ItemId), nameof(ItemId))]
	public class ItemDetailViewModel : BaseViewModel
	{
		#region member vars

		private string description;
		private string itemId;
		private string text;

		#endregion

		#region methods

		public async void LoadItemId(string itemId)
		{
			try
			{
				var item = await DataStore.GetItemAsync(itemId);
				Id = item.Id;
				Text = item.Text;
				Description = item.Description;
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to Load Item");
			}
		}

		#endregion

		#region properties

		public string Id { get; set; }

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

		public string ItemId
		{
			get => itemId;
			set
			{
				itemId = value;
				LoadItemId(value);
			}
		}

		#endregion
	}
}
