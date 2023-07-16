using jcabezasS7.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace jcabezasS7.Views
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