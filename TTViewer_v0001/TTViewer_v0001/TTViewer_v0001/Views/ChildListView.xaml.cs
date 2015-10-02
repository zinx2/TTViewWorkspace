using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0001.ViewModels;
using Xamarin.Forms;

namespace TTViewer_v0001.Views
{
    public partial class ChildListView : ContentView
    {
        public ChildListView()
        {
            InitializeComponent();
            BindingContext = new ChildListViewModel();
        }

    }
}
