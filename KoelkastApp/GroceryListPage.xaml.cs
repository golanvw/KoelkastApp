using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroceryListPage : ContentPage
	{
		public GroceryListPage ()
		{
			InitializeComponent ();
		}

        private void RefillBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}