using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TTViewer_v0001.ViewModels;
using Xamarin.Forms;

namespace TTViewer_v0001.Views
{
    public partial class ObjsListView : ContentView
    {

        public ObjsListView()   
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new ObjsViewModel();
        }

        //void OnPush(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new ChildListView());
        //}
    }
}
