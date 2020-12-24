using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Base.Model;

namespace Base
{
    public partial class App : Application
    {
        public App(string filename)
        {
            InitializeComponent();
            UserRepository.Inicializador(filename);
            MainPage = new MainPage();
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
