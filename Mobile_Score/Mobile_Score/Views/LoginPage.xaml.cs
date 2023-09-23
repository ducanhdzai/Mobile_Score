using Mobile_Score.Constant;
using Mobile_Score.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_Score.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        async void ButtonLogin(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}