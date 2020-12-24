using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeBanco : ContentPage
    {
        public DeBanco(String nombre)
        {
            InitializeComponent();
            lbl_nombre.Text = "El usuario es: " + nombre +"!";
        }
    }
}