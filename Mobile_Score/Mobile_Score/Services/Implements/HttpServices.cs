using Mobile_Score.Services.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public async Task<TResult> GetAsync<TResult>(string url) where TResult : class
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
                throw new Exception($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        public Task<TResult> PutAsync<TResult>(string url, TResult data) where TResult : class
        {
            throw new NotImplementedException();
        }

        public async Task<TResult> PostAsync<TResult, TData>(string url, TData data)
            where TResult : class
            where TData : class
        {
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(url, content);
            var stringResult = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrWhiteSpace(stringResult))
            {
                TResult result = JsonConvert.DeserializeObject<TResult>(stringResult);
                return result;
            }
            return default;
        }

        public async Task<TResult> PutAsync<TResult, TData>(string url, TData data)
            where TResult : class
            where TData : class
        {
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            var stringResult = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrWhiteSpace(stringResult))
            {
                TResult result = JsonConvert.DeserializeObject<TResult>(stringResult);
                return result;
            }
            return default;
        }
    }
}
