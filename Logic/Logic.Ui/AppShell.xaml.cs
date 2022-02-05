using System;
using System.Collections.Generic;
using Ui.Mobile.ViewModels;
using Ui.Mobile.Views;
using Xamarin.Forms;

namespace Ui.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
