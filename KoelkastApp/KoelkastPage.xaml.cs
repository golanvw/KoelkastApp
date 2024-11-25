namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KoelkastPage : ContentPage
    {
        public KoelkastPage(string a)
        {
            InitializeComponent();
            Username.Text = a;
        }

        public class Koelkast()
        {
            //idee (credits=Rob) koelkast gps coordinaten toevoegen om automatisch de juiste koelkast te gebruiken
        }
    }
}