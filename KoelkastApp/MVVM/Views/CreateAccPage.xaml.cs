namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccPage : ContentPage
    {
        public CreateAccPage()
        {
            InitializeComponent();
        }

        private void CreateAccBtn_Clicked(object sender, EventArgs e)
        {
            if(Username.Text != "" && Password.Text != "")
                
                Navigation.PushAsync(new KoelkastPage(Username.Text));
        }
    }
}