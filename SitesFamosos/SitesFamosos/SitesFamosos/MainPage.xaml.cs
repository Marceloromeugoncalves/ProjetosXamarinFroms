using SitesFamosos.Util;
using System;
using Xamarin.Forms;

namespace SitesFamosos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognizerTapped1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Links.LinkIconFinder));
        }

        void OnTapGestureRecognizerTapped2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Links.LinkJsonFormatterValidator));
        }

        void OnTapGestureRecognizerTapped3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Links.LinkBuildMyString));
        }
    }
}
