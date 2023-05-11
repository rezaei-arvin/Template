using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;

namespace Infrastructure
{
    public class BaseServiceTemp1 : object
    {
        public BaseServiceTemp1(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected HttpClient HttpClient { get; }

        protected string RequestUri { get; set; }

        public async Task<IList<T>> GetAsycn()
        {
            var result = await HttpClient.GetFromJsonAsync<IList<T>>(RequestUri);

            return result;
        }
    }
}