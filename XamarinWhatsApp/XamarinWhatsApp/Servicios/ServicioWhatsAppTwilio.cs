using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinWhatsApp.Helpers;
using XamarinWhatsApp.Modelos;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace XamarinWhatsApp.Servicios
{
    public static class ServicioWhatsAppTwilio
    {
        public static MessageResource EnviarMensaje(Mensaje mensaje)
        {
            var whatsapp = MessageResource.Create(
                body: mensaje.Body,
                from: new PhoneNumber($"whatsapp:{mensaje.From}"),
                to: new PhoneNumber($"whatsapp:{mensaje.To}")
            );

            return whatsapp;
        }
    }
}
