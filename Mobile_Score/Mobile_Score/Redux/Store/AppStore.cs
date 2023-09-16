using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile_Score.Redux.Store
{
    public class AppStore
    {
        // singleton appstore
        private static AppStore _instance;
        public static AppStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppStore();
                }
                return _instance;
            }
        }
        // lock object
        private static readonly object _lock = new object();
        // state
        private AppState _state;
        public AppState State
        {
            get
            {
                lock (_lock)
                {
                    if (_state == null)
                    {
                        _state = new AppState();
                    }
                    return _state;
                }
            }
        }
        // dispatch action
        public void Dispatch(object action)
        {
            // TODO: dispatch action
            MessagingCenter.Send(this, "Dispatch", action);
        }
        // subscribe
        public void Subscribe(Action<object> action)
        {
            MessagingCenter.Subscribe<AppStore, object>(this, "Dispatch", (sender, arg) =>
            {
                action(arg);
            });
        }
    }
}
