using WhatsAppSpy.Common;
using Xamarin.Forms;

namespace WhatsAppSpy.Controls
{
    public class WhatsAppWebView : WebView
    {
        public WhatsAppWebView()
        {
            Source = AppConstants.WhatsAppWebUrl;
        }
    }
}