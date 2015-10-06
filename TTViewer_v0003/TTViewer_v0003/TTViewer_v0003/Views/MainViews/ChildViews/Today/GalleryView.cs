using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews.ChildViews.Today
{
    public class GalleryView : StackLayout
    {
        public GalleryView()
        {
            BackgroundColor = Color.White;

            var label = new Label
            {
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            label.SetBinding(Label.TextProperty, "Title");
            this.SetBinding(ContentView.BackgroundColorProperty, "Background");

            VerticalOptions = LayoutOptions.CenterAndExpand;
            Children.Add(label);
            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    Children = {
            //        label
            //    }
            //};
        }
    }
}
