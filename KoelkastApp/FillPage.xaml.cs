﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FillPage : ContentPage
	{
		public FillPage ()
		{
			InitializeComponent ();
		}

        private void SaveFillBtn_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new ProductPage());
        }
    }
}