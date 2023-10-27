using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Score.Services.Interfaces
{
    public interface IServices<TResult, TParam>
    {
        Task<TResult> GetPagingData(string url);
    }
}
