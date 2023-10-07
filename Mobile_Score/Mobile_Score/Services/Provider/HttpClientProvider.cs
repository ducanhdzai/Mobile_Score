using Mobile_Score.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace Mobile_Score.Services.Provider
{
    public class HttpClientProvider
    {
        public HttpClient Get()
        {
            var nativeHttpMessageHandler = DependencyService.Get<INativeHttpMessageHandlerProvider>().Get();
            return new HttpClient(nativeHttpMessageHandler);    // nativeHttpMessageHander is injected from Android project
        }
    }
}
