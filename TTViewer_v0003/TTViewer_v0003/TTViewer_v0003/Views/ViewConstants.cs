using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0003.Views
{
    static class ViewConstants
    {
        public static string DeviceScreenHeight = Convert.ToString(DeviceInfo.GetInstance.ScreenHeight);
        public static string DeviceScreenWidth = Convert.ToString(DeviceInfo.GetInstance.ScreenWidth);

        public static string Margin_10 = "10";
        public static int Margin_20 = 20;

        public static double DeviceScreenWidth_double = Convert.ToDouble(DeviceInfo.GetInstance.ScreenWidth);
        public static double ImageWidthType_1 = (DeviceScreenWidth_double - 40) / 3;

        public static string ImageWidthType_1_str = Convert.ToString(ImageWidthType_1);
    }
}
