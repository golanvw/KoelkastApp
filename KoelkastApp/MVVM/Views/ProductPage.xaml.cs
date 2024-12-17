using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductSettingsPage());
        }

        private void FillBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FillPage());
        }

        private void UseBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsePage());
        }

        private void CreateProductBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateProductPage());
        }
    }
}