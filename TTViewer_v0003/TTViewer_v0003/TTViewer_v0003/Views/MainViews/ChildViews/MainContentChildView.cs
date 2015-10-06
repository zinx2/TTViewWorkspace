using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.Factory;
using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews.ChildViews
{
    public class MainContentChildView : ContentView
    {
        public MainContentChildView()
        {
            //var childView = new ContentView();
            //this.SetBinding(ContentView.ClassIdProperty, "childView");
            //this.SetBinding(ContentView.)
            //MainViewFactory.GetInstance
            Content = new StackLayout
            {
                Children =
                {
                    MainViewFactory.GetInstance.GetChildView(),
                }
            };
        }
    }
}
