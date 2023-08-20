using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mobile_Score.ViewModels
{
    public class BaseAppViewModel : IDisposable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        protected void SetProperty<TValue>(ref TValue storeValue, TValue showValue, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(storeValue, showValue))
            {
                storeValue = showValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }

    }
}
