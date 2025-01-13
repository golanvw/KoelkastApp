using KoelkastApp.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.Logic
{
    public class BeerLogic
    {
        public async static Task<List<Beer>> GetAPIBeersByBrand(string name)
        {
            List<Beer>? apiBeers = new List<Beer>();

            var url = APIBeer.BrandURL(name);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var beersByBrandResponse = JsonConvert.DeserializeObject<BeersByBrandResponse>(json);

                apiBeers = beersByBrandResponse.Beers as List<Beer>;    
            }

            return apiBeers;
        }

        public async static Task<List<APIBeer>> GetAPIBeersByStore(string name)
        {
            List<APIBeer> apiBeers = new List<APIBeer>();

            var url = APIBeer.StoreURL(name);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
            }

            return apiBeers;
        }
    }
}
