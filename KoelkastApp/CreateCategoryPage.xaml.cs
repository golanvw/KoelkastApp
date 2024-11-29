using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateCategoryPage : ContentPage
	{
		public CreateCategoryPage ()
		{
			InitializeComponent ();
		}

        private void CreateBtn_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new CategoryPage());
        }
    }
}