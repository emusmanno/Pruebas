using MenuIndio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Map = Xamarin.Forms.Maps.Map;

namespace MenuIndio.Views
{
   
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-34.351299, -58.885261), Distance.FromMiles(0.3)));
            CargarLocalizaciones();
           
        }


        private void OnMapClicked(object sender, SelectedItemChangedEventArgs e)
        {
            PuntoDeInteres punto = (PuntoDeInteres)e.SelectedItem;
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(punto.Posicion.Latitude, punto.Posicion.Longitude), Distance.FromMiles(0.05)));
                       
        }
       
        private void CargarLocalizaciones()
        {
            lst.ItemsSource = new List<PuntoDeInteres>() {
                    new PuntoDeInteres("club House","Tomate una birrita", "pinBar" ,new Position (-34.351299,-58.885261)),
                    new PuntoDeInteres("Rotonda","una rotonda nomas", "pingBasket" ,new Position (-34.350789, -58.893686))
            };
            lst.ItemSelected += OnMapClicked;
           
            MyMap.Pins.Add(CrearPin(-34.351299, -58.885261, "club House", "Tomate una birrita"));
           
            MyMap.Pins.Add(CrearPin(-34.350789, -58.893686, "Rotonda", "una rotonda nomas"));
        }

        private Pin CrearPin(double pLatitude, double pLongitud, string pNombre,string pDescripcion)
        {
            Pin pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(pLatitude, pLongitud),
                Label = pNombre,
                Address = pDescripcion
            };
            return pin;
        }
    }
}