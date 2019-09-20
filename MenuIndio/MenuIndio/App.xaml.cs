using MenuIndio.Models;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using Microsoft.AppCenter;
using Xamarin.Forms;

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
            AppCenter.Start("android=8565f244-d138-4f9e-ab23-706b4f5a186a;" +
                   "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
