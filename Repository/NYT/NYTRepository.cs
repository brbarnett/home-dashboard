using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Repository.Models;

namespace Repository.NYT
{
    public class NYTRepository : INewsRepository
    {
        private readonly string _apiKey;
        private string serviceUrl => $"https://api.nytimes.com/svc/topstories/v2/home.json?api-key={this._apiKey}";

        public NYTRepository(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            this._apiKey = apiKey;
        }

        public async Task<IEnumerable<NewsItem>> GetNewsItems()
        {
            using (HttpClient client = new HttpClient())
            {
                string data = await client.GetStringAsync(this.serviceUrl);
                NYTResponse response = JsonConvert.DeserializeObject<NYTResponse>(data);

                return response.results
                               .Where(x => string.Equals(x.item_type, "Article", StringComparison.CurrentCultureIgnoreCase))
                               .Select(x => new NewsItem
                               {
                                   Abstract = x.Abstract,
                                   Published = x.published_date,
                                   ThumbnailUrl = x.multimedia
                                        .FirstOrDefault(y => string.Equals(y.format, "thumbLarge", StringComparison.InvariantCultureIgnoreCase))
                                        ?.url,
                                   Title = x.title,
                                   Updated = x.updated_date,
                                   Url = x.url
                               });
            }
        }
    }
}
