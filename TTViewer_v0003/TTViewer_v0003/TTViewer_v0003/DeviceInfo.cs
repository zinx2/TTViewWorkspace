using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0003
{
    public class DeviceInfo
    {
        private static DeviceInfo deviceInfo = new DeviceInfo();
        public static DeviceInfo GetInstance
        {
            get
            {
                return deviceInfo;
            }
        }

        public int ScreenWidth { set; get; }
        public int ScreenHeight { set; get; }
    }
}
