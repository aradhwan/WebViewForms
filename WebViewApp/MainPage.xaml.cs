using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void BackButton_Clicked(object sender, System.EventArgs e)
        {
            if(webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        void ForwardButton_Clicked(object sender, System.EventArgs e)
        {
            if(webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        void RefreshButton_Clicked(object sender, System.EventArgs e)
        {
            webView.Source = (webView.Source as UrlWebViewSource).Url;
        }

        void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            loadingIndicator.IsVisible = false;
            loadingIndicator.IsRunning = false;
            refreshButton.IsVisible = true;
        }

        void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            refreshButton.IsVisible = false;
            loadingIndicator.IsVisible = true;
            loadingIndicator.IsRunning = true;
        }
    }
}
