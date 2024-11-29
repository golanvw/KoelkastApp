namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KoelkastPage : ContentPage
    {
        string NavigationTarget1 = "Koelkast";
        string NavigationTarget2 = "Bijvullen";
        string NavigationTarget3 = "Verbruiken";
        public KoelkastPage(string a)
        {
            InitializeComponent();
            Username.Text = a;
        }

        public class Koelkast()
        {
            //idee (credits=Rob) koelkast gps coordinaten toevoegen om automatisch de juiste koelkast te gebruiken
        }

        private void AddKoelkastBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanQRPage(NavigationTarget1));
        }

        private void CreateKoelkastBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateKoelkastPage());
        }

        private void GroceryListBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroceryListPage());
        }

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KoelkastSettingsPage());
        }

        private void RefillBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanQRPage(NavigationTarget2));
        }

        private void UseBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanQRPage(NavigationTarget3));
        }

        private void AccountSettingBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountSettingsPage());
        }
    }
}