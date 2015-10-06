using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.Views.MainViews;
using TTViewer_v0003.Views.TabViews;

namespace TTViewer_v0003.ViewModels
{
    public class SwitcherMainPageViewModel : BaseViewModel
    {
        enum ViewType { GENRE, TODAY, DATE, BOOK, FINISH }

        public SwitcherMainPageViewModel()
        {
            Pages = new List<MainContentChildViewModel>()
            {
                new MainContentChildViewModel { ImageSource = "back.png" },
                new MainContentChildViewModel { ImageSource = "back.png" },
                new MainContentChildViewModel { ImageSource = "back.png" },
                new MainContentChildViewModel { ImageSource = "back.png" },
                new MainContentChildViewModel { ImageSource = "back.png" },
            };
            CurrentPage = Pages.First();
        }

        IEnumerable<MainContentChildViewModel> _pages;
        public IEnumerable<MainContentChildViewModel> Pages
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

        MainContentChildViewModel _currentPage;
        public MainContentChildViewModel CurrentPage
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

    public class MainContentChildViewModel : BaseViewModel, ITabProvider
    {
        public MainContentChildViewModel() { }
        public string ImageSource { get; set; }
        
    }
}
