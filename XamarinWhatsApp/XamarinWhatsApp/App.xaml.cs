using Twilio;
using Xamarin.Forms;
using XamarinWhatsApp.Helpers;

namespace XamarinWhatsApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            TwilioClient.Init(Constantes.TwilioAccountSID, Constantes.TwilioAuthToken);
            MainPage = new XamarinWhatsApp.Paginas.PaginaMensaje();
		}
	}
}
