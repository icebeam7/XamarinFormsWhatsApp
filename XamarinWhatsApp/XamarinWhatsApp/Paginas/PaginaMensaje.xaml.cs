using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWhatsApp.Helpers;
using XamarinWhatsApp.Modelos;
using XamarinWhatsApp.Servicios;

namespace XamarinWhatsApp.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaMensaje : ContentPage
	{
        ObservableCollection<MessageResource> ListaMensajes = new ObservableCollection<MessageResource>();

		public PaginaMensaje ()
		{
			InitializeComponent ();

            lsvMensajes.ItemsSource = ListaMensajes;
            txtFrom.Text = Constantes.NumeroTwilioWhatsApp;
            txtTo.Text = Constantes.NumeroUsuarioWhatsApp;
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var mensaje = new Mensaje()
            {
                From = txtFrom.Text,
                To = txtTo.Text,
                Body = txtBody.Text
            };

            var whatsapp = ServicioWhatsAppTwilio.EnviarMensaje(mensaje);
            ListaMensajes.Add(whatsapp);
        }
    }
}