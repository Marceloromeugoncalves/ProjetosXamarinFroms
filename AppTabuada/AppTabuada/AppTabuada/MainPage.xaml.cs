using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppTabuada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Clicked(object sender, EventArgs e)
        {
            int numero = 0;

            int.TryParse(entryNumero.Text, out numero);

            List<string> items = new List<string>();

            for (int i = 0; i < 11; i++)
            {
                items.Add($"{numero} X {i} = {numero * i}");
            }

            listViewTabuada.ItemsSource = items;
        }
    }
}
