using System;
using System.Net.Http;

namespace OpenWeather.Services
{
    public static class ServiceClient
    {
        public static HttpClient Client
        {
            get
            {
                return new HttpClient();
            }
        }

        public static HttpClient GetClient()
        {
            Client.DefaultRequestHeaders.Add("ContentType", "application/json");
            return Client;
        }
    }
}
