using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTViewer_v0001.Views;
using Xamarin.Forms;

namespace TTViewer_v0001
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = MainView.GetInstance();
            
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
