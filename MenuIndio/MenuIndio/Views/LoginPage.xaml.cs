
using Acr.UserDialogs;
using MenuIndio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuIndio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false); // Oculta la barra de navegación
        }
        void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new SignUpPage());
        }

  
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Iniciando Sesion", MaskType.Gradient);
            var user = new User
            {
                NumeroDocumento = usernameEntry.Text,
                Contraseña=passwordEntry.Text,
                TipoDocumento= tdoc.SelectedIndex.ToString()
            };
            var client = new HttpClient(new System.Net.Http.HttpClientHandler());
            client.BaseAddress = new Uri("https://10.20.30.162:45456");
            string  result = JsonConvert.SerializeObject(user);


            HttpResponseMessage response = await client.PostAsync("/api/Account/Login", new StringContent(result, Encoding.UTF8, "application/json"));
            //Hide loader

            if (response.StatusCode == HttpStatusCode.OK)
            {
           Settings.IsLoggedIn = true;
                UserDialogs.Instance.HideLoading();
                Application.Current.MainPage = new MainShell();
                //await Navigation.PushAsync(new MainShell());
            //Application.Current.MainPage = new NavigationPage(new MainShell());
        }
        else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {

                string username = "Xamarin";
                    string password = "password";
            return user.NumeroDocumento == username && user.Contraseña == password;
        }
        
    }
}