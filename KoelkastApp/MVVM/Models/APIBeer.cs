using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.MVVM.Models
{
    public class APIBeer
    {
        public static string BrandURL(string name)
        {
            return string.Format(Constants.BEER_BY_BRAND, name);
        }

        public static string StoreURL(string name)
        {
            return string.Format(Constants.BEER_BY_STORE, name);
        }
    }
}
