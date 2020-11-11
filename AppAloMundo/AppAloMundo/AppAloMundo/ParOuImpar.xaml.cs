using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAloMundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        private void buttonExecutar_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(entryNumero.Text);

            labelResposta.Text = numero % 2 == 0 ? $"O número {numero} é par." : $"O número {numero} é ímpar.";
        }
    }
}