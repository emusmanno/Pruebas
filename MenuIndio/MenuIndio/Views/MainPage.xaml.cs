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

namespace MenuIndio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
            // _restService = new RestService();
        
        //  conectarClimaAsync();
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
            requestUri += $"?q={"Buenos Aires"}";
            requestUri += "&units=imperial"; // or units=metric
            requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }

       
    }
}
