using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews.ChildViews.Today
{
    public partial class TodayToonFragment : StackLayout
    {
        public TodayToonFragment()
        {
            InitializeComponent();
        }

        void OpenView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TodayToonView());
        }
    }
}
