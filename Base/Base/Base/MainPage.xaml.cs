using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            btn.Clicked += BtnClicked;
            btnNavigation.Clicked += BtnNavigationAsync;
        }

        async void BtnNavigationAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TareaClase3());
        }

        private void BtnClicked(object sender, EventArgs e)
        {
            lbl.Text = dtp.Date.ToString() + " " + ss.Value.ToString() + " " + txt1.Text;
            txt1.IsEnabled = false;
        }
    }
}
