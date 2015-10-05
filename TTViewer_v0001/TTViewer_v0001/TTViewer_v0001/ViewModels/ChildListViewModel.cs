using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0001.Models;

namespace TTViewer_v0001.ViewModels
{
    class ChildListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ChildListItem> childListItemModelCollection = new ObservableCollection<ChildListItem>();
        public ObservableCollection<ChildListItem> ChildListItemModelCollection
        {
            get
            {
                return childListItemModelCollection;
            }
        }

        public ChildListViewModel()
        {
            ready();
        }

        private async Task ready()
        {
            ChildListItemModel childListItemModel = new ChildListItemModel();
            bool taskResult = await childListItemModel.downloadTask();
            if (taskResult)
            {
                foreach (object obj in childListItemModel.ChildItemList)
                {
                    ChildListItem childListItem = obj as ChildListItem;
                    childListItemModelCollection.Add(childListItem);
                }
            }
            MainViewModel.GetInstance().RunIndicator()
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
