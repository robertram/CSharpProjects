using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" }); 
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            InitializeComponent();

            MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new TareaClase3());
            MainPage = new NavigationPage(new TareaClase3Otros());
            MainPage = new NavigationPage(new ImageScreen());
            MainPage = new NavigationPage(new TemperatureCalculator());
            MainPage = new NavigationPage(new Semana5());
            //MainPage = new NavigationPage(new Semana5Ejer2());
            MainPage = new NavigationPage(new Semana6());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
