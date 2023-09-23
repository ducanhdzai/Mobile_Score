using Mobile_Score.Services;
using Mobile_Score.Views;
using Xamarin.Forms;
[assembly: ExportFont("FluentSystemIcons-Filled.ttf", Alias = "FluentIconsFilled")]
[assembly: ExportFont("FluentSystemIcons-Regular.ttf", Alias = "FluentIcons")]
namespace Mobile_Score
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU4NjA5OEAzMjMyMmUzMDJlMzBpQ0pWUzl2SElsMzlCNkFicUFRMzhURGxhL3dDM3VGSnh2M3JMQkc3RnVvPQ==");
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new HomePage();
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
