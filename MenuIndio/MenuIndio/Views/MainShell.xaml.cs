using MenuIndio.Models;
using MenuIndio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuIndio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();
            Shell.PropertyChanged += Test;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Shell.CurrentItem.Title == "Cerrar Sesion")
            {

            }
            //your code here;

        } 
        public void Test(object e, EventArgs eve )
        {
            if (Shell.CurrentItem.Title == "Cerrar Sesion")
            {
                Settings.IsLoggedIn = false;
                Application.Current.MainPage = new LoginPage();
            }
        }

    }
}