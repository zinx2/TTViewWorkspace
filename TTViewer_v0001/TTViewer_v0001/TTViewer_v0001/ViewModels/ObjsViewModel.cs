using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0001.Models;
using TTViewer_v0001.Views;

namespace TTViewer_v0001.ViewModels
{
    public class ObjsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ObjBase> objsViewModelCollection = new ObservableCollection<ObjBase>();
        public ObservableCollection<ObjBase> ObjsViewModelCollection
        {
            get
            {
                return objsViewModelCollection;
            }
        }

        public ObjsViewModel()
        {
            ready();
        }

        private async Task ready()
        {
            RunIndicator();
            ObjsModel objsModel = new ObjsModel();
            bool taskResult = await objsModel.downloadTask();
            if (taskResult)
            {
                foreach(object obj in objsModel.ObjList)
                {
                    ObjBase objBase = obj as ObjBase;
                    objsViewModelCollection.Add(objBase);
                }
            }
            StopIndicator();
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
        private void RunIndicator()
        {
            IsBusy = true;
        }
        private void StopIndicator()
        {
            IsBusy = false;
        }
    }
}
