using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace unsplashAlternative.ViewModel
{
    public class unSplashHelper
    {
        public const string BASE_URL = "https://api.unsplash.com/";
        public const string AUTOCOMPLETE_ENDPOINT = "photos/?client_id={0}";
        public const string API_KEY = "1vOpqq-6xkNAJpoz8MM_UiscPInlT43Dt4VE2bSa34c";

        public static async Task<List<unSplashHelper>> ImageApi()
        {
            List<unSplashHelper> image;
            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT, API_KEY);

            using (HttpClient client = new())
            {
                var response = client.GetAsync(url).Result;
                string json = await response.Content.ReadAsStringAsync();

                image = JsonConvert.DeserializeObject<List<unSplashHelper>>(json);
            }

            return image;
        }
    }
}
