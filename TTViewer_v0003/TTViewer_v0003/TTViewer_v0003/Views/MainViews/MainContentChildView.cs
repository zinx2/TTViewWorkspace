using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews
{
    public class MainContentChildView : ContentView
    {
        public MainContentChildView()
        {
            //var childView = new ContentView();
            //this.SetBinding(ContentView.ClassIdProperty, "childView");
            //this.SetBinding(ContentView.)
            Content = new StackLayout
            {
                Children =
                {
                    new MainContentChildView_Genre(),

                }
            };
        }
    }
}
