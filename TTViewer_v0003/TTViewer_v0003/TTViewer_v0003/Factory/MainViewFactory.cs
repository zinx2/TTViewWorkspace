using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.Views.MainViews.ChildViews;
using TTViewer_v0003.Views.MainViews.ChildViews.Book;
using TTViewer_v0003.Views.MainViews.ChildViews.Date;
using TTViewer_v0003.Views.MainViews.ChildViews.Finished;
using TTViewer_v0003.Views.MainViews.ChildViews.Genre;
using TTViewer_v0003.Views.MainViews.ChildViews.Today;
using Xamarin.Forms;

namespace TTViewer_v0003.Factory
{
    public class MainViewFactory
    {
        private static MainViewFactory mainViewModel = new MainViewFactory();
        public static MainViewFactory GetInstance
        {
            get{
                return mainViewModel;
            }
        }

        public int ViewType = 0;

        public ContentView GetChildView()
        {
            ViewType = ViewType + 1;
            if (ViewType == 1) return new MainContentChildView_Genre();
            else if (ViewType == 2) return new MainContentChildView_Today();
            else if (ViewType == 3) return new MainContentChildView_Date();
            else if (ViewType == 4) return new MainContentChildView_Book();
            else return new MainContentChildView_Finished();
        }

    }
}
