using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Score.Models
{
    public class PagingItem <T> where T : class
    {
        // trang số 
        public int PageNumber { get; set; }
        // số lượng item trên 1 trang
        public int PageSize { get; set; }
        // có trang sau không
        public bool HasNext { get; set; }
        public List<T> Data { get; set; }
    }
}
