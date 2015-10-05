using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0003.Factory
{
    public class MainViewFactory
    {
        private static MainViewFactory mainViewModel = new MainViewFactory();
        public static MainViewFactory GetInstance
        {
            get{
                return mainViewModel;
            }
        }
    }
}
