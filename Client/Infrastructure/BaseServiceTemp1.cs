using System.Net.Http.Json;

namespace Infrastructure
{
    public class BaseServiceTemp1<T> : object
    {
        public BaseServiceTemp1(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected HttpClient HttpClient { get; }

        protected string BaseUrl { get; set; }

        public async Task<IList<T>> GetAsycn()
        {
            var result = await HttpClient.GetFromJsonAsync<IList<T>>(BaseUrl);

            return result;
        }
    }
}