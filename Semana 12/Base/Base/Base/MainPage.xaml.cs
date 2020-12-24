using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Diagnostics;
using Xamarin.Essentials;

namespace Base
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnNet.Clicked += BtnNet_Clicked;
            btnNet.Clicked += BtnGPS_Clicked; 
            btnMap.Clicked += BtnMap_Clicked;

        }

        private void BtnMap_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat)) { return; }
            if (!double.TryParse(EntryLongitud.Text, out double lng)) { return; }
            Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }

        private void BtnNet_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnGPS_Clicked(object sender, EventArgs e)
        {
            ObtenerUbica();
        }

        private async void ObtenerUbica()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                if (location == null)
                {
                    lblLocaliza.Text = "No hay GPS";
                }
                else
                {
                    lblLocaliza.Text = $"{location.Latitude}{location.Longitude}";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Algo sale mal :{ ex.Message}");
            }
        }
    }
}
