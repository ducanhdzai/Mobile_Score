using Mobile_Score.Services;
using Mobile_Score.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_Score
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
