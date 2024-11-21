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
            count++;

            if (count == 1)
                LoginBtn.Text = $"Clicked {count} time";
            else
                LoginBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(LoginBtn.Text);
        }

        private void CreateAccBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
