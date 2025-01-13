using KoelkastApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KoelkastApp.MVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiscountCheckerPage : ContentPage
	{
		public DiscountCheckerPage ()
		{
			InitializeComponent ();
		}

        private async void SearchBeerBrandBtn_Clicked(object sender, EventArgs e)
        {
            var beers = await BeerLogic.GetAPIBeersByBrand(BeerBrandEntry.Text);
            BeerListView.ItemsSource = beers;
        }

        //private async void pickerBrand_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var picker = (Picker)sender;
        //    int selectedIndex = picker.SelectedIndex;

        //    if (selectedIndex != -1)
        //    {
        //        //BeersDiscount.Text = BeerLogic.GetAPIBeersByBrand((string)picker.ItemsSource[selectedIndex]);
        //        var Beers = await BeerLogic.GetAPIBeersByBrand((string)pickerBrand.SelectedItem);
        //        BeersDiscount.Text = Beers.ToString();
        //    }
        //}
    }
}