using System;
using System.Collections.Generic;
using System.ComponentModel;
using Ui.Mobile.Models;
using Ui.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ui.Mobile.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}