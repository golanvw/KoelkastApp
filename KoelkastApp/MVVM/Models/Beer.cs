using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.MVVM.Models
{
    public class Bonus
    {
        public string Store { get; set; }
        public string ExpirationDate { get; set; }
    }
    public class Beer
    {
        public string Brand {  get; set; }
        public  List<Bonus> bonuses { get; set; }
    }
}
