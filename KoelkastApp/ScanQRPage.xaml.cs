using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Maui;



namespace KoelkastApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanQRPage : ContentPage
    {
        string NavigationTarget {get; set;}
        public ScanQRPage(string a)
        {
            InitializeComponent();
            NavigationTarget = a;
        }
        
        protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            foreach (var barcode in e.Results)
                if (barcode.Value == "coolkast")
                    Navigation.PushAsync(new KoelkastPage(NavigationTarget));
                else
                    DisplayAlert("Fout", "invalide qr code", "OK");
        }

        private void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            if (NavigationTarget == "Koelkast")
                Navigation.PushAsync(new KoelkastPage(NavigationTarget));
            else if (NavigationTarget == "Bijvullen")
                Navigation.PushAsync(new FillPage());
            else
                Navigation.PushAsync(new UsePage());
        }
    }
}