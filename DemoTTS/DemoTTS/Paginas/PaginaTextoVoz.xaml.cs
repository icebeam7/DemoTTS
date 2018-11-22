using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DemoTTS.Servicios;

namespace DemoTTS.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaTextoVoz : ContentPage
	{
        public PaginaTextoVoz()
        {
            InitializeComponent();
        }

        private void btnHablar_Clicked(object sender, EventArgs e)
        {
            ServicioTTS.Speak(txtMensaje.Text);
        }
    }
}