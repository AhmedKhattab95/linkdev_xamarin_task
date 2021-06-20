using System;

namespace linkdev_xamarin_task.Utils
{
    public static class Urls
    {
        public const string ApiKey = "4ad6f761da3c4acd88e608311e4095ea";
        private const string BaseUrl = "https://newsapi.org";
        public static string getArticleUrl(string source)
        {
            return $"{BaseUrl}/v1/articles?source={source}&apiKey={ApiKey}";
        }

    }
}
