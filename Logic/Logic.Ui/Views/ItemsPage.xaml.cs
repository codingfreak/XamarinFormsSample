namespace Ui.Mobile.Views
{
	using System;
	using System.Linq;
	using ViewModels;
	using Xamarin.Forms;

	public partial class ItemsPage : ContentPage
	{
		#region member vars

		private readonly ItemsViewModel _viewModel;

		#endregion

		#region constructors and destructors

		public ItemsPage()
		{
			InitializeComponent();
			BindingContext = _viewModel = new ItemsViewModel();
		}

		#endregion

		#region methods

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}

		#endregion
	}
}
