using Restaurante.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Restaurante.Views
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