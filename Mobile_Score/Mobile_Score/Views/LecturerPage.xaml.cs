using Mobile_Score.ViewModels;
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
	public partial class LecturePage : ContentPage
	{
		public LecturePage ()
		{
			InitializeComponent();
			this.BindingContext = new LecturesViewModel();
		}
		// on appering
		protected override async void OnAppearing()
		{
            base.OnAppearing();
          var test =  await (this.BindingContext as LecturesViewModel).GetList();
        }
	}
}