using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Web.Syndication;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Brainvita.RssReader
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            FillContentAsync();
        }


        async Task FillContentAsync()
        {
            SyndicationClient client = new SyndicationClient();
            try
            {
                SyndicationFeed feed = await client.RetrieveFeedAsync(
                  new Uri("http://chinese.engadget.com/rss.xml"));

                this.DataContext = feed;
            }
            catch
            {
                // Handle any errors, such as a 404 from an unavailable site
                System.Diagnostics.Debugger.Break();
            }
        }

        void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0)
                return;

            // Show the selected item's content in the WebView because it is HTML
            this.webView.NavigateToString(
              (e.AddedItems[0] as SyndicationItem).Summary.Text);
        }

        private void backButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           
            this.Frame.Navigate(typeof(Blocks.HubPage));
        
        }



    }
}
