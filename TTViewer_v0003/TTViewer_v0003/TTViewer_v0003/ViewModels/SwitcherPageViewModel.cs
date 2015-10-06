using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.Views.TabViews;
using Xamarin.Forms;

namespace TTViewer_v0003.ViewModels
{
    public class SwitcherPageViewModel : BaseViewModel
    {
        public SwitcherPageViewModel()
        {
            Pages = new List<HomeViewModel>() {
                new HomeViewModel { Title = "1", Background = Color.White, ImageSource = "back.png" },
                new HomeViewModel { Title = "2", Background = Color.Red, ImageSource = "back.png" },
                new HomeViewModel { Title = "3", Background = Color.Blue, ImageSource = "back.png" },
                new HomeViewModel { Title = "4", Background = Color.Yellow, ImageSource = "back.png" },
            };

            CurrentPage = Pages.First();
        }

        IEnumerable<HomeViewModel> _pages;
        public IEnumerable<HomeViewModel> Pages
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

        HomeViewModel _currentPage;
        public HomeViewModel CurrentPage
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

    public class HomeViewModel : BaseViewModel, ITabProvider
    {
        public HomeViewModel() { }

        public string Title { get; set; }
        public Color Background { get; set; }
        public string ImageSource { get; set; }
    }
}
