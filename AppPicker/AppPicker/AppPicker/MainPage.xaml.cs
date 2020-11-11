using System;
using Xamarin.Forms;

namespace AppPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Clicked(object sender, EventArgs e)
        {
            int valor = 0;

            int.TryParse(entryValor.Text, out valor);

            int indicePicker = pickerOperacao.SelectedIndex;

            switch(indicePicker)
            {
                case 0:
                    //Número Primo.
                    labelResposta.Text = Primo(valor) ? $"O número {valor} é Primo." : $"O número {valor} não é Primo";
                    break;

                case 1:
                    //Número Par.
                    labelResposta.Text = Par(valor) ? $"O número {valor} é Par." : $"O número {valor} é Ímpar.";
                    break;

                case 2:
                    //Fatorial.
                    labelResposta.Text = $"{valor}! = {Fatorial(valor)}";
                    break;
            }
        }

        public bool Par(int valor) => valor % 2 == 0;

        public int Fatorial(int valor)
        {
            if (valor == 1) return 1;

            return valor * Fatorial(valor - 1);
        }

        public bool Primo(int valor)
        {
            int count = 0;

            for(int i = valor; i > 0; i--)
            {
                if (valor % i == 0)
                {
                    count++;
                }
            }

            if(count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
