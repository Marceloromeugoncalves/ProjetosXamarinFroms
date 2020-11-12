using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavPaginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageExemplo : ContentPage
    {
        public PageExemplo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}