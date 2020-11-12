using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace AppBuscaSites
{
    public partial class MainPage : ContentPage
    {
        List<string> sites = new List<string>
        {
            "dfilito.com.br",
            "movieaholic.com.br",
            "makeindiegames.com.br",
            "bgdb.com.br",
            "unoeste.com.br",
            "google.com.br",
            "facebook.com.br",
            "udemy.com.br",
            "youtube.com.br"
        };

        public MainPage()
        {
            InitializeComponent();

            listViewSites.ItemsSource = sites;
        }

        private void searchBarSites_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = searchBarSites.Text;

            listViewSites.ItemsSource = sites.Where(x => x.ToLower().Contains(texto));
        }
    }
}
