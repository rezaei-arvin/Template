namespace Infrastructure
{
    public class BaseServiceTemp1 : object
    {
        public BaseServiceTemp1(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected HttpClient HttpClient { get; }

        protected string RequestUri;
    }
}