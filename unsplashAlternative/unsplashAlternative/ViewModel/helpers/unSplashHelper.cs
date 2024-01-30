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
        public const string AUTOCOMPLETE_ENDPOINT = "photos/?client_id={0}&page={1}";
        public const string SEARCH_ENDPOINT = "&query={0}";

        public const string API_KEY = "1vOpqq-6xkNAJpoz8MM_UiscPInlT43Dt4VE2bSa34c";

        public static async Task<unSplashImage[]> ImageApi(string search, int page = 1)
        {
            unSplashImage[] images;
            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT, API_KEY, page);
            if (!string.IsNullOrWhiteSpace(search))
            {
                url += string.Format(SEARCH_ENDPOINT, search);
            }

            using (HttpClient client = new())
            {
                var response = client.GetAsync(url).Result;
                string json = await response.Content.ReadAsStringAsync();

                images = JsonConvert.DeserializeObject<unSplashImage[]>(json);
            }

            return images;
        }
    }
}
