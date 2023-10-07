using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Mobile_Score.Services.Provider
{
    public interface INativeHttpMessageHandlerProvider
    {
        HttpMessageHandler Get();
    }
}
