using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuIndio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitasPage : ContentPage
    {

        public VisitasPage() {
            InitializeComponent();
        }
      
        private async void OpenWhatsApp(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("", "https://sansebastian.linksolution.com.ar:81/Account/RegistroNuevoUsuario");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Not Installed", "Whatsapp Not Installed", "ok");
            }
        }
    }
}