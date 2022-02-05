using System.ComponentModel;
using Ui.Mobile.ViewModels;
using Xamarin.Forms;

namespace Ui.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}