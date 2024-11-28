namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (Password.Text == "admin")
                Navigation.PushAsync(new KoelkastPage(Username.Text));
            else
                Error.Text = "Gebruikersnaam en wachtwoord zijn niet correct";
        }
        
        
    }
}