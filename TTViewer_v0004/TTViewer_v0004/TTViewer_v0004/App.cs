﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTViewer_v0004.Controls;
using Xamarin.Forms;

namespace TTViewer_v0004
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new HomePage(CarouselLayout.IndicatorStyleEnum.Tabs));
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
