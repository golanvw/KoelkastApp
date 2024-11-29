using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateKoelkastPage : ContentPage
	{
		string Placeholdertext = "koelkast";
		public CreateKoelkastPage ()
		{
			InitializeComponent ();
		}

        private void CreateBtn_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new KoelkastPage(Placeholdertext));
        }
    }
}