namespace codingfreaks.XamarinFormsSample.Logic.Ui.Views
{
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public partial class ItemDetailPage : ContentPage
	{
		#region constructors and destructors

		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}

		#endregion
	}
}
