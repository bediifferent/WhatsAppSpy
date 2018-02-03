using Android.Content;
using WhatsAppSpy.Common;
using WhatsAppSpy.Controls;
using WhatsAppSpy.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WhatsAppWebView), typeof(WhatsAppWebViewRenderer))]
namespace WhatsAppSpy.Droid.Renderers
{
    public class WhatsAppWebViewRenderer : WebViewRenderer
    {
        public WhatsAppWebViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.UserAgentString = AppConstants.AndroidUserAgent;
        }
    }
}