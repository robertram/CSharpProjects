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
            btnIr.Clicked += BtnIr_Clicked;
        }

        private void BtnIr_Clicked(object sender, EventArgs e)
        {
            if((txt_correo.Text == "admin") && (txt_contrasena.Text == "123"))
            {
                General.UsrName = txt_correo.Text;
                ((NavigationPage)this.Parent).PushAsync(new DeBanco(txt_correo.Text));
            }
        }
    }
}
