using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string callerName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string callerName = "")
        {
            if(EqualityComparer<T>.Default.Equals(storage, value))
                    return false;
            storage = value;
            this.OnPropertyChanged(callerName);
            return true;
        }
    }
}
