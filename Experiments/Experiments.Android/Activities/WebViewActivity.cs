using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace Experiments.Android
{
    [Activity(Label = "WebView")]
    public class WebViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.WebView);

            string url = Intent.GetStringExtra("URL");

            // Set up the webview and navigate to the URL
            var webView = SetupWebView();
            webView.LoadUrl(url);
        }

        private WebView SetupWebView()
        {
            WebView webView = FindViewById<WebView>(Resource.Id.WebView);

            // Apply settings
            webView.SetWebViewClient(new WebViewClient());
            webView.Settings.JavaScriptEnabled = true;
            webView.Settings.SetSupportZoom(true);
            webView.Settings.BuiltInZoomControls = true;
            webView.Settings.DisplayZoomControls = false;
            webView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            webView.ScrollbarFadingEnabled = false;

            return webView;
        }
    }
}