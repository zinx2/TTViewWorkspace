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
    public class ObjsViewModel
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
            MainViewModel.GetInstance().StopIndicator();
        }

        
    }
}
