using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuIndio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
        }
        private async void ButtonOpenCoords_Clicked(object sender, EventArgs e) {
            await Map.OpenAsync(55, 213, new MapLaunchOptions()
           /* {
                NamedSize = EntryName.Text,
                Navigationmode = NavigationMode.None;
            }*/);
           
        }
        public async Task NavigateToBuilding25()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            await Map.OpenAsync(location, options);
        }
    }
}