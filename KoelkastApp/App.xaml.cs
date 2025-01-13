using KoelkastApp.Repositories;

namespace KoelkastApp
{
    public partial class App : Application
    {
        public static KoelkastRepository? KoelkastRepo { get; private set; }
        public App(KoelkastRepository koelkastRepo)
        {
            InitializeComponent();

            KoelkastRepo = koelkastRepo;
            MainPage = new NavigationPage(new MainPage());
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
    }
}