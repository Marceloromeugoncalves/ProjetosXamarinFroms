using System;
using Xamarin.Forms;

namespace AppEmail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Clicked(object sender, EventArgs e)
        {
            string destinatario = entryDestinatario.Text;
            string assunto = entryAssunto.Text;
            string texto = editorTexto.Text;

            string url = $"mailto:{destinatario}?subject={assunto}&body={texto}";

            Device.OpenUri(new Uri(url));
        }
    }
}
