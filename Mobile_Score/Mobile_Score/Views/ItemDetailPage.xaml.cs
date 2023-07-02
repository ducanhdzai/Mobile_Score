using Mobile_Score.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobile_Score.Views
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