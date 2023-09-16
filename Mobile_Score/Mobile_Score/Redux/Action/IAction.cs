using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Score.Redux.Action
{
    public interface IAction
    {
        // hành động để kiểm tra state
        bool IsRefresh { get; set; }
    }
}
