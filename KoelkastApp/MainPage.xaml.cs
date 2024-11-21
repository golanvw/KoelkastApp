namespace KoelkastApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void CreateAccBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccPage());
        }
    }

}
