namespace Ui.Mobile.Views
{
	using Models;
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public partial class NewItemPage : ContentPage
	{
		#region constructors and destructors

		public NewItemPage()
		{
			InitializeComponent();
			BindingContext = new NewItemViewModel();
		}

		#endregion

		#region properties

		public Item Item { get; set; }

		#endregion
	}
}
