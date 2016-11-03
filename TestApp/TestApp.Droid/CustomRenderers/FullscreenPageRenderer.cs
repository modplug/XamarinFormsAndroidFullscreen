using Android.App;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Views;
using TestApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ContentPage), typeof(FullscreenPageRenderer))]
namespace TestApp.Droid.CustomRenderers
{
    public class FullscreenPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            Activity parent = (Activity)Context;
            var toolbar = parent.FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Background = new ColorDrawable(Color.Transparent.ToAndroid());
            toolbar.SetFitsSystemWindows(false);
            ViewGroup.SetFitsSystemWindows(false);
            parent.Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            parent.Window.AddFlags(WindowManagerFlags.Fullscreen);
        }
    }
}