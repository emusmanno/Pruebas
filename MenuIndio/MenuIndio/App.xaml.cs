using MenuIndio.Models;
using MenuIndio.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuIndio
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();
            if (!Settings.IsLoggedIn)
            {
                //MainPage = new LoginPage();
                MainPage = new MainShell();            
            }
            else
            {
                MainPage = new MainShell();
          
            }
          //  MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
