using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0001.Models
{
    public class ChildListItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ChildListItem(string sub_thumb, string sub_title, string url)
        {
            SubThumb = sub_thumb;
            SubTitle = sub_title;
            Url = url;
        }

        private string subThumb;
        public string SubThumb
        {
            get
            {
                return subThumb;
            }
            set
            {
                subThumb = value;
                OnPropertyChanged("SubThumb");
            }
        }

        private string subTitle;
        public string SubTitle
        {
            get
            {
                return subTitle;
            }
            set
            {
                subTitle = value;
                OnPropertyChanged("SubTitle");
            }
        }

        private string url;
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                OnPropertyChanged("Url");
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
    }
}
