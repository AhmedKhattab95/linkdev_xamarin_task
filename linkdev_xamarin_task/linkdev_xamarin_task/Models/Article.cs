using System;

namespace linkdev_xamarin_task.Models
{
    /// <summary>
    /// class reporesents article
    /// </summary>
    public class Article
    {
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
    }

}
