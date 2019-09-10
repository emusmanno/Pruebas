using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Com.Mapbox.Mapboxsdk;
using System.Net;
using System.Runtime.ConstrainedExecution;
using static Com.Mapbox.Mapboxsdk.Attribution.AttributionMeasure;
using Acr.UserDialogs;

namespace MenuIndio.Droid
{
    [Activity(Label = "San Sebastian", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //
            UserDialogs.Init(this);
            ServicePointManager.ServerCertificateValidationCallback += (o, Cer, Chain, errors) => true;
            //
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            
            
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
          
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
                

        
    }
}