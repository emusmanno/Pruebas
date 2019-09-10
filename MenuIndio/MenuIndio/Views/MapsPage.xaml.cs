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
            //InitializeComponent();

            var map = new Map(
     MapSpan.FromCenterAndRadius(
             new Position(-34.349588f, -58.889960f), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            map.MapType = MapType.Satellite;
            map.HasZoomEnabled = true;
  
            var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-34.351299f,
                    -58.885261f),
                    Label = "Canchas de tenis",
                    Address = "SANSE"
                };
            map.Pins.Add(pin);
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
           

        }

    }
}