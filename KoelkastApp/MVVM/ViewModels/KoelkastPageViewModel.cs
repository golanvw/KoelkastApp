using Bogus;
using KoelkastApp.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KoelkastApp.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class KoelkastPageViewModel
    {
        public List<Koelkast>? Koelkasten { get; set; }
        public Koelkast? CurrentKoelkast { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? Deletecommand { get; set; }


        private void GenerateNewKoelkast()
        {
            CurrentKoelkast = new Faker<Koelkast>()
                .Generate();
        }

        private void Refresh()
        {
            Koelkasten = App.KoelkastRepo.GetAll();
        }

        public KoelkastPageViewModel()
        {
            Refresh();
            GenerateNewKoelkast();
            AddOrUpdateCommand = new Command(async () =>
            {
                App.KoelkastRepo.AddOrUpdate(CurrentKoelkast);
                Console.WriteLine(App.KoelkastRepo.statusMessage);
                GenerateNewKoelkast();
                Refresh();
            });

            Deletecommand = new Command(() =>
            {
                App.KoelkastRepo.Delete(CurrentKoelkast.KoelkastId);
                Refresh();
                GenerateNewKoelkast();
            });
        }
    }
}
