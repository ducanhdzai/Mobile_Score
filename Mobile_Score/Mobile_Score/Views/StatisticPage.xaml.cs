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
	public partial class StatisticPage : ContentPage
	{
		public StatisticPage ()
		{
			InitializeComponent ();
		}
        private void DetailButton(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StatisticDetailPage());
        }
    }
}