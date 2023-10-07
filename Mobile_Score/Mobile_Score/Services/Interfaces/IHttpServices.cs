using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Score.Services.Interfaces
{
    public interface IHttpServices
    {
        // Get list
        Task<TResult> GetListAsync<TResult>(string url) where TResult : class;
        // Get by id
        Task<TResult> GetByIdAsync<TResult>(string url, Guid id) where TResult : class;
        // Post
        Task<TResult> PostAsync<TResult>(string url, TResult data) where TResult : class;
        // Put
        Task<TResult> PutAsync<TResult>(string url, TResult data) where TResult : class;
        // Delete
        Task<TResult> DeleteAsync<TResult>(string url, Guid id) where TResult : class;

    }
}
