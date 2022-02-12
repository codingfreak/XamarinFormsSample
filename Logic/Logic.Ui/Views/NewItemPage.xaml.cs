namespace codingfreaks.XamarinFormsSample.Logic.Ui.Views
{
	using Models;
	using Mvvm.BaseTypes;
	using System;
	using System.Linq;
	using ViewModels;

	public partial class NewItemPage : BaseContentPage
	{
		#region constructors and destructors

		public NewItemPage()
		{
			InitializeComponent();
		}

		/// <inheritdoc />
		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		#endregion

	}
}
