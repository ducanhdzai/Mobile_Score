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
			tabBar.Items.Add(new ShellContent() { Icon= iConHome, Content = new MajorPage(), Title = "About" });
			tabBar.Items.Add(new ShellContent() { Icon= iConHome, Content = new HomePage(), Title = "1" });
			tabBar.Items.Add(new ShellContent() { Icon= iConHome, Content = new LoginPage(), Title = "A2bout" });
		}
	}
}