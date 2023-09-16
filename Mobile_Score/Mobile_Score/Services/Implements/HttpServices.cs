using Mobile_Score.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration;

namespace Mobile_Score.Services.Implements
{
    public class HttpServices : IHttpServices
    {
        private readonly string _baseUrl;
        private HttpClient _httpClient => new HttpClient();
        
        public Task<TResult> DeleteAsync<TResult>(string url, Guid id) where TResult : class
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetByIdAsync<TResult>(string url, Guid id) where TResult : class
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetListAsync<TResult>(string url) where TResult : class
        {
           // get access token
           var accessToken = Preferences.Get("AccessToken", string.Empty);
            // set header
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            // get data
            var response = _httpClient.GetAsync(_baseUrl + url).Result;
            // get data from response
            var data = response.Content.ReadAsStringAsync().Result;
            // return data
            return Task.FromResult(data as TResult);
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
