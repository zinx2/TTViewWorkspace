using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTViewer_v0003.Views;
using TTViewer_v0003.Views.MainViews;
using Xamarin.Forms;

namespace TTViewer_v0003
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainView());
        }
        private static ContentPage GetControlsPage(VisualElement mainPage)
        {
          
            var controls = new ContentPage
            {
                Title = "Controls",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "First Page"
                        }
                    }
                 }

            };
            return controls;
        }

        private static ContentPage GetControlsPage2(VisualElement mainPage)
        {

            var controls = new ContentPage
            {
                Title = "2",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Second Page"
                        }
                    }
                }

            };
            return controls;
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
