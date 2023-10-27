using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mobile_Score.Services.Interfaces
{
    public interface IHttpServices
    {
        // Get list
        Task<TResult> GetAsync<TResult>(string url) where TResult : class;
        // Post
        Task<TResult> PostAsync<TResult,TData>(string url, TData data) where TResult : class where TData : class;
        // Put
        Task<TResult> PutAsync<TResult, TData>(string url, TData data) where TResult : class where TData : class;
        // Delete
        Task<TResult> DeleteAsync<TResult>(string url, Guid id) where TResult : class;

    }
}
