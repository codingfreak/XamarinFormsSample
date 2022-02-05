namespace codingfreaks.XamarinFormsSample.Logic.Ui
{
	using System;
	using System.Linq;
	using Views;
	using Xamarin.Forms;

	public partial class AppShell : Shell
	{
		#region constructors and destructors

		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

		#endregion
	}
}
