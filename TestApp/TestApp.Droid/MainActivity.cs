using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Xamarin.Forms.Platform.Android;

namespace TestApp.Droid
{
	[Activity (Label = "TestApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            // set the layout resources first
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;
            global::Xamarin.Forms.Forms.Init (this, bundle);
            //Window.AddFlags(WindowManagerFlags.Fullscreen);
            //Window.AddFlags(WindowManagerFlags.TranslucentStatus);
            //View decorView = Window.DecorView;
            //var uiOptions = (int)decorView.SystemUiVisibility;
            //var newUiOptions = (int)uiOptions;

            //newUiOptions |= (int)SystemUiFlags.LowProfile;
            //newUiOptions |= (int)SystemUiFlags.Fullscreen;
            //newUiOptions |= (int)SystemUiFlags.HideNavigation;
            //newUiOptions |= (int)SystemUiFlags.Immersive;

            //decorView.SystemUiVisibility = (StatusBarVisibility)newUiOptions;
            LoadApplication (new TestApp.App ());
		}
	}
}

