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
