using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0001.Models
{
    public class ObjBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObjBase(string main_thumb, string main_title, string author, string summary)
        {
            MainThumb = main_thumb;
            MainTitle = main_title;
            Author = author;
            Summary = summary;
        }
        private string mainThumb;
        public string MainThumb
        {
            get
            {
                return mainThumb;
            }
            set
            {
                mainThumb = value;
                OnPropertyChanged("MainThumb");
            }
        }

        private string mainTitle;
        public string MainTitle
        {
            get
            {
                return mainTitle;
            }
            set
            {
                mainTitle = value;
                OnPropertyChanged("MainTitle");
            }
        }

        private string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        private string summary;
        public string Summary
        {
            get
            {
                return summary;
            }
            set
            {
                summary = value;
                OnPropertyChanged("Summary");
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
