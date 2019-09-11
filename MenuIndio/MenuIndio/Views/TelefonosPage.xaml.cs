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
            //   lblClickFunc();
            lst.ItemsSource = new List<ContactoUtil>() {
    new ContactoUtil() {
            Name = "Umair", Num = "0456445450945", imgsource = "https://cdn2.iconfinder.com/data/icons/basics-1/100/Call-512.png",
        },
        new ContactoUtil() {
            Name = "Cat", Num = "034456445905", imgsource = "https://cdn2.iconfinder.com/data/icons/basics-1/100/Call-512.png",
        },
        new ContactoUtil() {
            Name = "Nature", Num = "56445905", imgsource = "https://cdn2.iconfinder.com/data/icons/basics-1/100/Call-512.png",
        },
        new ContactoUtil() {
            Name = "Pato", Num = "1131187529", imgsource = "https://cdn2.iconfinder.com/data/icons/basics-1/100/Call-512.png",
        },
        };
            
            lst.ItemSelected += clickItem;
         


        }

   

        private void clickItem(object sender, SelectedItemChangedEventArgs e)
        {
    
            ContactoUtil c =(ContactoUtil) e.SelectedItem;
            PlacePhoneCall(c.Num);
        }

        private void PlacePhoneCall(string numero)
        {
            try
            {
                PhoneDialer.Open(numero);

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

      /*  void lblClickFunc(string num)
        {
            labelPop.GestureRecognizers.Add(item: new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayActionSheet("Llamar", "llamando", "Aceptar");

                })


            });

        }*/

    }

}