using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategorySettingsPage : ContentPage
    {
        public CategorySettingsPage()
        {
            InitializeComponent();
        }

        private void SaveSettingsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategoryPage());
        }
    }
}