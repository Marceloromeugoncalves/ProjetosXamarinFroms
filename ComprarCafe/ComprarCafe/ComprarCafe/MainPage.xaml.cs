using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprarCafe
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 0;

        double valorUnitario = 5;

        double total = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Text)
            {
                case "-":
                    if(quantidade > 0)
                    {
                        quantidade--;
                    }
                    break;

                case "+":
                    quantidade++;
                    break;
            }

            total = quantidade * valorUnitario;

            labelQuantidade.Text = $"Quantidade: {quantidade}";

            labelTotal.Text = $"Total: R$ {total.ToString("N2")}";
        }
    }
}
