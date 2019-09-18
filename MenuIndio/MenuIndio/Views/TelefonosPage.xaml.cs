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
                    new ContactoUtil("ADMINISTRACION","0456445450945","https://cdn0.iconfinder.com/data/icons/streamline-emoji-1/48/153-man-office-worker-1-512.png"),
                    new ContactoUtil("DEFENSA CIVIL","103","https://cdn0.iconfinder.com/data/icons/streamline-emoji-1/48/195-construction-worker-512.png"),
                    new ContactoUtil("POLICIA","101","https://cdn0.iconfinder.com/data/icons/streamline-emoji-1/48/188-man-police-officer-2-512.png"),
                    new ContactoUtil("EMERGENCIAS MEDICAS","107","https://cdn0.iconfinder.com/data/icons/streamline-emoji-1/48/127-woman-health-worker-1-512.png"),
                    new ContactoUtil("BOMBEROS","100","https://cdn0.iconfinder.com/data/icons/streamline-emoji-1/48/184-man-firefighter-2-512.png"),
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

     
    }

}