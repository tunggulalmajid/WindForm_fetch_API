using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForm_fetch_API.Services
{
    public class ApiClient
    {
        private static readonly HttpClient _instance;
        static ApiClient()
        {
            _instance = new HttpClient()
            {
                BaseAddress = new Uri(AppConfig.BaseUrl)
            };
            _instance.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public static HttpClient Instance => _instance;
    }
}
