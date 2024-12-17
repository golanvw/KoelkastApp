using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UsePage : ContentPage
	{
		public UsePage ()
		{
			InitializeComponent ();
		}

        private void SaveUseBtn_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new ProductPage());
        }
    }
}