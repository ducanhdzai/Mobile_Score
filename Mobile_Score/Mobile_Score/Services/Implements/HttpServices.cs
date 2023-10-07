using Mobile_Score.Services.Interfaces;
using Mobile_Score.Services.Provider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Mobile_Score.Services.Implements
{
    public class HttpServices : IHttpServices
    {
        private HttpClient _httpClient;
        public HttpServices()
        {
            HttpClientHandler insecureHandler = GetInsecureHandler();
            _httpClient = new HttpClient(insecureHandler);
            _httpClient.BaseAddress = new Uri(Constant.Score_Constant.BASE_URL);
        }
        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
        public Task<TResult> DeleteAsync<TResult>(string url, Guid id) where TResult : class
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetByIdAsync<TResult>(string url, Guid id) where TResult : class
        {
            throw new NotImplementedException();
        }

        public async Task<TResult> GetListAsync<TResult>(string url) where TResult : class
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                string responseData = await response.Content.ReadAsStringAsync();
                TResult result = JsonConvert.DeserializeObject<TResult>(responseData);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
                return null;
            }
        }

        public Task<TResult> PostAsync<TResult>(string url, TResult data) where TResult : class
        {
            throw new NotImplementedException();
        }

        public Task<TResult> PutAsync<TResult>(string url, TResult data) where TResult : class
        {
            throw new NotImplementedException();
        }
    }
}
