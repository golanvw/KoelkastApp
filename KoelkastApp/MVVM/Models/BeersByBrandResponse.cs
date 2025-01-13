using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.MVVM.Models
{
    public class BeersByBrandResponse
    {
        public IList<Beer>? Beers { get; set; }
    }
}
