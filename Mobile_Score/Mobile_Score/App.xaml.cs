using Mobile_Score.Models;
using Mobile_Score.Services;
using Mobile_Score.Services.Implements;
using Mobile_Score.Services.Interfaces;
using Mobile_Score.Services.Provider;
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
            DependencyService.Register<IHttpServices,HttpServices>();
            DependencyService.Register<IServices<PagingItem<Lectures>, string>, Services<PagingItem<Lectures>, string>>();
            MainPage = new LecturePage();
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
