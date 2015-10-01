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
        public ObjBase(string thumb, string title, string author, string summary)
        {
            Thumb = thumb;
            Title = title;
            Author = author;
            Summary = summary;
        }
        private string _thumb;
        public string Thumb
        {
            get
            {
                return _thumb;
            }
            set
            {
                _thumb = value;
                OnPropertyChanged("Thumb");
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }

        private string _summary;
        public string Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
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
