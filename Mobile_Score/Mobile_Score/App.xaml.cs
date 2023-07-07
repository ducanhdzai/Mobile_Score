using Mobile_Score.Services;
using Mobile_Score.Views;
using Xamarin.Forms;

namespace Mobile_Score
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF5cXmdCdkx0WmFZfV1gdl9DYlZTQ2YuP1ZhSXxQdkJjXH5fcnVRR2RcVkQ=");
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
