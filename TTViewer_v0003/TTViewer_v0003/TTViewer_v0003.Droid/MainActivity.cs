using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Java.Lang;
using Android.Graphics.Drawables;

namespace TTViewer_v0003.Droid
{
    [Activity(Label = "터치툰", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        Theme= "@style/CustomActionBarTheme")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var actionBar = this.ActionBar;
            actionBar.SetIcon(new ColorDrawable(Color.Transparent));

            DeviceInfo.GetInstance.ScreenWidth = (int)Resources.DisplayMetrics.WidthPixels;
            DeviceInfo.GetInstance.ScreenHeight = (int)Resources.DisplayMetrics.HeightPixels;
            //actionBar.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
            //actionBar.SetSplitBackgroundDrawable(new ColorDrawable(Color.Transparent));
            //actionBar.SetStackedBackgroundDrawable(new ColorDrawable(Color.Transparent));
            //actionBar.
            //actionBar.set

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        protected override void OnTitleChanged(ICharSequence title, Color color)
        {
            base.OnTitleChanged(title, Color.Aqua);
        }
    }
}

