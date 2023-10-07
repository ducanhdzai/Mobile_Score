using Mobile_Score.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_Score.Services.Implements
{
    public class Services<TResult, TParam> : IServices<TResult, TParam> where TResult : class
    {
        // implement http services
        private readonly IHttpServices _httpServices;
        public Services(IHttpServices httpServices)
        {
            _httpServices = httpServices;
        }
        public Services()
        {
            // get http services
            _httpServices = DependencyService.Get<IHttpServices>();
        }
        public async Task<TResult> GetPagingData(string url)
        {
            var result = await _httpServices.GetListAsync<TResult>(url);
            return result;
        }
    }
}
