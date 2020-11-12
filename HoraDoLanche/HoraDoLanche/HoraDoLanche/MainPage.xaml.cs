using System;
using Xamarin.Forms;

namespace HoraDoLanche
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Text = "Comi o biscoito!";

            foto.Source = "after_cookie";
        }
    }
}
