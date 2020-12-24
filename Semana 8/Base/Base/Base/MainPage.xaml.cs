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
            tb1.Clicked += Tb1_Clicked;
            tb2.Clicked += Tb2_Clicked;
            tb3.Clicked += Tb3_Clicked;
            tb4.Clicked += Tb4_Clicked;

        }
        private void Tb4_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Logout Selecionado";
        }
        private void Tb3_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "About Selecionado";
        }
        private void Tb2_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "About Selecionado";
        }
        private void Tb1_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Home Selecionado";
        }
    }
}
