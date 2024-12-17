namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public List<string> UsernameList = new List<string> { "admin", "banaan", "golan" };
        public List<string> PasswordList = new List<string> { "admin", "banaansap", "cool" };       
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            int NameIndex = UsernameList.IndexOf(Username.Text);
            int PassIndex = PasswordList.IndexOf(Password.Text);
            
            if (NameIndex == PassIndex)
                Navigation.PushAsync(new KoelkastPage(Username.Text));
            else
                Error.Text = "Gebruikersnaam en wachtwoord zijn niet correct";
        }
        
        
    }
}