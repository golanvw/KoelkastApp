using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductSettingsPage : ContentPage
    {
        public ProductSettingsPage()
        {
            InitializeComponent();
        }

        private void SaveSettingsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductPage());
        }
    }
}