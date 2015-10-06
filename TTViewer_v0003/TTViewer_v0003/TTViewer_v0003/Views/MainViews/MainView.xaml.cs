using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews
{
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
            BackgroundColor = Color.Red;
            BackgroundImage = "red.png";
        }
    }
}
