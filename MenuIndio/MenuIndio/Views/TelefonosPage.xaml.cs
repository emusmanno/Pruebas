using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;
namespace MenuIndio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelefonosPage : ContentPage
    {
        public TelefonosPage()
        {
            InitializeComponent();
            lblClickFunc();
        }

        private void PlacePhoneCall(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("1136167515");

            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        void lblClickFunc()
        {
            labelPop.GestureRecognizers.Add(item: new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayActionSheet("Llamar", "llamando", "Aceptar");

                })


            });

        }

    }

}