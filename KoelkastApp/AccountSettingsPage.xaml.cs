using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccountSettingsPage : ContentPage
	{
		string PlaceholderText = "koelkast";
		public AccountSettingsPage ()
		{
			InitializeComponent ();
		}

        private void SaveSettingBtn_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new KoelkastPage(PlaceholderText));
        }
    }
}