using Newtonsoft.Json;
using Oenskeportalen_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oenskeportalen_APP.Services
{
    public class AboutService : IAbout
    {
        public async Task<AboutUs> getAbout()
        {
            var aboutUs = new List<AboutUs>();
            var client = new HttpClient();

            string url = "https://xn--nskeportalen-ujb.dk/api/AboutUs.json";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync("");
            if(response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                aboutUs=JsonConvert.DeserializeObject<List<AboutUs>>(content);

                return await Task.FromResult(aboutUs.FirstOrDefault());
            }
            else
            {
                return null;
            }
        }
    }
}
