using Mobile_Score.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile_Score.ViewModels
{
    public class LoginViewModel : BaseAppViewModel
    {
        public Command LoginCommand { get; }
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            Username = "Đức Anh đẹp trai";
        }

        private void OnLoginClicked(object obj)
        {
            Username = "Đại ca";
            //// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
