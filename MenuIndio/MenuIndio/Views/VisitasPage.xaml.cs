using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace MenuIndio.Views
{

    [DesignTimeVisible(false)]
    public partial class VisitasPage : CarouselPage
    {

        public VisitasPage() {
            InitializeComponent();
            Date1.Format = "dd/M/yyyy";
            Date2.Format = "dd/M/yyyy";
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false); // Oculta la barra de navegación
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

        void NextButton_Clicked(object sender, System.EventArgs e)
        {
            
        }
    }
}