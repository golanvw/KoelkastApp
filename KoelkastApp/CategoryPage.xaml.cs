using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void CategoryBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductPage());
        }

        private void SettingsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategorySettingsPage());
        }

        private void CreateCatergoryBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateCategoryPage());
        }
    }
}