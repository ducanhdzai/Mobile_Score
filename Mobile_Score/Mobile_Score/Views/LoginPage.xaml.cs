using Mobile_Score.Constant;
using Mobile_Score.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_Score.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : Shell
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void ButtonLogin(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}