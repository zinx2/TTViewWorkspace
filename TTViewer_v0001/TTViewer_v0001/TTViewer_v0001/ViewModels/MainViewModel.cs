using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0001.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private static MainViewModel mainViewModel = new MainViewModel();
        public static MainViewModel GetInstance()
        {
            return mainViewModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }
        public virtual void OnPropertyChanged(string param)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs arg = new PropertyChangedEventArgs(param);
                PropertyChanged(this, arg);
            }
        }
        public void RunIndicator()
        {
            IsBusy = true;
        }
        public void StopIndicator()
        {
            IsBusy = false;
        }
    }
}
