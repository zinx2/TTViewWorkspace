using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.Views.TabViews;
using Xamarin.Forms;

namespace TTViewer_v0003.ViewModels
{
    public class SwitchGalleryViewModel : BaseViewModel
    {
        public SwitchGalleryViewModel()
        {
            Pages = new List<GalleryViewModel>() {
                new GalleryViewModel { Title = "1", Background = Color.White },
                new GalleryViewModel { Title = "2", Background = Color.Red },
                new GalleryViewModel { Title = "3", Background = Color.Blue },
                new GalleryViewModel { Title = "4", Background = Color.Yellow },
            };

            CurrentPage = Pages.First();
        }

        IEnumerable<GalleryViewModel> _pages;
        public IEnumerable<GalleryViewModel> Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                SetObservableProperty(ref _pages, value);
                CurrentPage = Pages.FirstOrDefault();
            }
        }

        GalleryViewModel _currentPage;
        public GalleryViewModel CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                SetObservableProperty(ref _currentPage, value);
            }
        }
    }

    public class GalleryViewModel : BaseViewModel
    {
        public GalleryViewModel() { }

        public string Title { get; set; }
        public Color Background { get; set; }
    }
}
