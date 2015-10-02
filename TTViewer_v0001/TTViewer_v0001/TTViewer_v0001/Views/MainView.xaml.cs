using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0001.ViewModels;
using Xamarin.Forms;

namespace TTViewer_v0001.Views
{
    public partial class MainView : ContentPage
    {
        private static MainView mainView = new MainView();
        public static MainView GetInstance()
        {
            return mainView;
        }

        private ObjsListView objsListView;
        private ChildListView childListView;
        private ChildWebView childWebView;

        public MainView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            
            InitializeComponent();
            BindingContext = MainViewModel.GetInstance();

            MainViewModel.GetInstance().RunIndicator();
            objsListView = new ObjsListView();
            MainStack.Children.Add(objsListView);
        }

        private int Page = 0;
        void OnPush(object sender, EventArgs e)
        {
            if (Page == 0)
            {
                MainStack.Children.Remove(objsListView);
                childListView = new ChildListView();
                MainStack.Children.Add(childListView);
            }
            else if (Page == 1)
            {
                MainStack.Children.Remove(childListView);
                childWebView = new ChildWebView();
                MainStack.Children.Add(childWebView);
            }
            Page = Page + 1;
        }

        void OnPop(object sender, EventArgs e)
        {
            if (Page == 1)
            {
                MainStack.Children.Remove(childListView);
                MainStack.Children.Add(objsListView);
            }
            else if(Page == 2)
            {
                MainStack.Children.Remove(childWebView);
                MainStack.Children.Add(childListView);
            }
            Page = Page - 1;
        }
    }
}