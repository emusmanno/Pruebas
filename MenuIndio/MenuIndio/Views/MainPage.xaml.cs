using MenuIndio.Controls;
using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using MenuIndio.Models;
using Xamarin.Essentials;

namespace MenuIndio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RestService _restService;

        public MainPage()
        {
            _restService = new RestService();
            conectarClimaAsync(_restService);
            InitializeComponent();
            CargarNovedades();

        }

        async void conectarClimaAsync(object sender)
        {
            WeatherData weatherData = await _restService.GetWeatherDataAsync(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
            BindingContext = weatherData;
        }

        public void CargarNovedades() {
            lst.ItemsSource = new List<Novedad>() {
                    new Novedad("Actividades y servicios en el hípico","Los servicios y actividades están abiertos al público (propietarios y no propietarios)","https://www.barriosansebastian.com.ar/wp-content/uploads/2019/05/Captura-de-pantalla-2019-09-08-a-las-11.39.14.png","https://www.barriosansebastian.com.ar/actividades-servicios-hipico/"),
                    new Novedad("Actividades y servicios en el hípico","Los servicios y actividades están abiertos al público (propietarios y no propietarios)","https://www.barriosansebastian.com.ar/wp-content/uploads/2019/05/Captura-de-pantalla-2019-09-08-a-las-11.39.14.png","https://www.barriosansebastian.com.ar/actividades-servicios-hipico/"),
                    new Novedad("Actividades y servicios en el hípico","Los servicios y actividades están abiertos al público (propietarios y no propietarios)","https://www.barriosansebastian.com.ar/wp-content/uploads/2019/05/Captura-de-pantalla-2019-09-08-a-las-11.39.14.png","https://www.barriosansebastian.com.ar/actividades-servicios-hipico/"),
                    new Novedad("","","","")
                };

                lst.ItemSelected += clickItem;

        }
        public void clickItem(object sender, SelectedItemChangedEventArgs e)
        {

            Novedad novedad = (Novedad)e.SelectedItem;
            Browser.OpenAsync(novedad.URL, BrowserLaunchMode.SystemPreferred);
        }

        protected override void OnAppearing()
        {
            /*   string content = await client.GetStringAsync(Url);
               List<Model_Post> posts = JsonConvert.DeserializeObject<List<Model_Post>>(content);
               _post = new ObservableCollection<Model_Post>(posts);
               MyListView.ItemsSource = _post;*/

            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false); // Oculta la barra de navegación
        }

        
        public async void CargarNotificaciones()
        {
            string url = "https://localhost:44353/api/notificaciones";


    var httpClient = new HttpClient();
            var resultado = await httpClient.GetAsync(url);
            var json = resultado.Content.ReadAsStringAsync().Result;
         //   ListView1.ItemsSource = json; 
        /*    var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "http://country.io/continent.json";  
        client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
           
            var Items = JsonConvert.DeserializeObject<List<string>>(content);
            ListView1.ItemsSource = Items;*/
        }

     
        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?q={"Pilar"}";
            requestUri += "&units=metric"; // or units=metric
            requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }

       
    }
}
