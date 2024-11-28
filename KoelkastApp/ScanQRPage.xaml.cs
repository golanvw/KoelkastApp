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
        string NavigationTarget;
        public ScanQRPage(string a)
        {
            InitializeComponent();
            string NavigationTarget = a;
        }

        protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            foreach (var barcode in e.Results)
                Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
        }

        private void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            if (NavigationTarget == "Koelkast")
                Navigation.PushAsync(new KoelkastPage(NavigationTarget));
            if (NavigationTarget == "Bijvullen")
                Navigation.PushAsync(new FillPage());
            else
                Navigation.PushAsync(new UsePage());
        }
    }
}