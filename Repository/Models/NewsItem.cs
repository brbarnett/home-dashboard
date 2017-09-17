using System;
namespace Repository.Models
{
    public class NewsItem
    {
        public string Abstract { get; set; }
        public DateTime Published { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
        public DateTime Updated { get; set; }
        public string Url { get; set; }
    }
}
