using linkdev_xamarin_task.Utils;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Repositories
{

    public abstract class BaseRepository
    {
        static readonly HttpClient httpClient = new HttpClient();
        public BaseRepository()
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", Urls.ApiKey);
            httpClient.DefaultRequestHeaders.Add("Authorization", Urls.ApiKey);
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            T result;
            var response = await httpClient.GetStringAsync(url);
            if (!string.IsNullOrWhiteSpace(response))
                result = JsonConvert.DeserializeObject<T>(response);
            else
                result = default;
            return result;
        }

    }
}
