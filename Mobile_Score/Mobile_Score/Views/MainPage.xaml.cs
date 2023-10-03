using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_Score.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : Shell
	{
		public MainPage ()
		{
			InitializeComponent();
			var iConHome = new FontImageSource()
			{
				FontFamily="FluentIcons",
				Glyph= "\ue70e"
            };
			var iConStatistic = new FontImageSource()
			{
				FontFamily ="FluentIcons",
				Glyph = "\uf2e8"
			};
			var iConSetting = new FontImageSource()
			{
				FontFamily ="FluentIcons",
				Glyph = "\uf6b1"
            };
			tabBar.Items.Add(new ShellContent() { Icon= iConStatistic, Content = new StatisticPage(), Title = "Thống kê" });
			tabBar.Items.Add(new ShellContent() { Icon= iConHome, Content = new HomePage(), Title = "Trang chủ" });
			tabBar.Items.Add(new ShellContent() { Icon= iConSetting, Content = new HomePage(), Title = "Cài đặt" });
		}
	}
}