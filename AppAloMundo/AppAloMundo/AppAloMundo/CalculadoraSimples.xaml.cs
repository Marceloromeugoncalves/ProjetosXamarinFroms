using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAloMundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double valorA = 0;
            double valorB = 0;
            double resultado = 0;

            double.TryParse(entryValorA.Text, out valorA);
            double.TryParse(entryValorB.Text, out valorB);

            Button button = sender as Button;

            if (button == null) return;

            switch(button.Text)
            {
                case "+":
                    resultado = valorA + valorB;
                    break;

                case "-":
                    resultado = valorA - valorB;
                    break;

                case "/":
                    try
                    {
                        resultado = valorA / valorB;
                    }
                    catch (Exception)
                    {
                        DisplayAlert("Erro", "Não é permitido realizar a divisão por zero.", "OK");
                    }                   
                    break;

                case "*":
                    resultado = valorA * valorB;
                    break;
            }

            labelResultado.Text = resultado.ToString();
        }
    }
}