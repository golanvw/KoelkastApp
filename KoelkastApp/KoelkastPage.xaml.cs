namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KoelkastPage : ContentPage
    {
        string NavigationTarget = "Koelkast";
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
            Navigation.PushAsync(new ScanQRPage(NavigationTarget));
        }
    }
}