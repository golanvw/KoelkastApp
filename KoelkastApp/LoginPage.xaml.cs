namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        List<string> UsernameList =  new List<string> { "admin", "banaan", "golan"};
        List<string> PasswordList = new List<string> { "admin", "banaansap", "cool" };
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (UsernameList.Contains(Username.Text) && PasswordList.Contains(Password.Text))
                Navigation.PushAsync(new KoelkastPage(Username.Text));
            else
                Error.Text = "Gebruikersnaam en wachtwoord zijn niet correct";
        }
        
        
    }
}