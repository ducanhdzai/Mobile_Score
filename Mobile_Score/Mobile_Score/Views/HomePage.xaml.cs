﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_Score.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private void Button_SizeChanged(object sender, EventArgs e)
        {

        }
		private void MajorButton(object sender, EventArgs e)
		{
            Navigation.PushModalAsync(new MajorPage());
        }
        private void StatisticButton(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StatisticPage());
        }
        private void LecturerButton(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LecturePage());
        }
        private void StudentButton(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentPage());
        }
    }
}