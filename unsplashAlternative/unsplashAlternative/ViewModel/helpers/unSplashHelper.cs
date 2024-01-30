using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace unsplashAlternative.ViewModel.helpers
{
    public class unSplashHelper
    {
        public const string BASE_URL = "https://api.unsplash.com/";
        public const string AUTOCOMPLETE_ENDPOINT = "search/photos?page={0}&query={1}&client_id={2}";
        public const string SEARCH_ENDPOINT = "&query={0}";

        public const string API_KEY = "1vOpqq-6xkNAJpoz8MM_UiscPInlT43Dt4VE2bSa34c";

        public static async Task<unSplashImage> ImageApi(string search, int page = 1)
        {
            unSplashImage images;
            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT, page, search, API_KEY);

            using (HttpClient client = new())
            {
                var response = client.GetAsync(url).Result;
                string json = await response.Content.ReadAsStringAsync();

                images = JsonConvert.DeserializeObject<unSplashImage>(json);
            }

            return images;
        }
    }
}
