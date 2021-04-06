using Xamarin.Forms;

namespace Magenic
{
    public partial class TransactionDetailPage : ContentPage
    {
        public TransactionDetailPage()
        {
            InitializeComponent();
            webView.Navigated += webView_Navigated;
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                activityIndicator.IsRunning = false;
                activityIndicator.IsVisible = false;
                webView.IsVisible = true;
            }
        }
    }
}
