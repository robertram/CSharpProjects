using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

            tbGuardar.Clicked += TbtGuardar_Clicked;
            tbVer.Clicked += TbtVer_Clicked;
            tbBorrar.Clicked += TbtBorrar_Clicked;

            btnSuma.Clicked += BtnSuma_Clicked;
            btnResta.Clicked += BtnResta_Clicked;
            btnMultiplicacion.Clicked += BtnMultiplicacion_Clicked;
            btnDivision.Clicked += BtnDivision_Clicked;
            btnLimpiar.Clicked += BtnLimpiar_Clicked;

        }

        private void TbtBorrar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                File.Delete(rutaCompleta);
                lblResultado.Text = "Borrado";
            }
        }

        private void TbtVer_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new VisualizarResultados());
            Txt_num1.Text = "";
            Txt_num2.Text = "";
        }
        public String operacion;

        private void TbtGuardar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                using (var escritor = File.AppendText(rutaCompleta))
                {
                    escritor.Write(Txt_num1.Text + operacion + Txt_num2.Text + " = " + lblResultado.Text + "  |  ");
                }
            }
            else
            {
                using (var escritor = File.CreateText(rutaCompleta))
                {
                    escritor.Write(Txt_num1.Text + operacion + Txt_num2.Text + " = " + lblResultado.Text + "  |  ");
                }
            }
            Txt_num1.Text = "";
            Txt_num2.Text = "";
        }

        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            Txt_num1.Text = "";
            Txt_num2.Text = "";
        }

        private async void BtnDivision_Clicked(object sender, EventArgs e)
        {
            if (Txt_num1.Text != null && Txt_num2.Text != null && Convert.ToInt32(Txt_num1.Text) != 0 && Convert.ToInt32(Txt_num2.Text) != 0)
            {
                var num1 = 0;
                var num2 = 0;
                num1 = Convert.ToInt32(Txt_num1.Text);
                num2 = Convert.ToInt32(Txt_num2.Text);

                lblResultado.Text = (num1 / num2).ToString();
                operacion = "/";
            }
            else
            {
                await DisplayAlert("Alert", "Llena todos los espacios", "OK");
            }
        }

        private async void BtnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            if (Txt_num1.Text != null && Txt_num2.Text != null)
            {
                var num1 = 0;
                var num2 = 0;
                num1 = Convert.ToInt32(Txt_num1.Text);
                num2 = Convert.ToInt32(Txt_num2.Text);

                lblResultado.Text = (num1 * num2).ToString();
                operacion = "*";
            }
            else
            {
                await DisplayAlert("Alert", "Llena todos los espacios", "OK");
            }
        }

        private async void BtnResta_Clicked(object sender, EventArgs e)
        {
            if (Txt_num1.Text != null && Txt_num2.Text != null)
            {
                var num1 = 0;
                var num2 = 0;
                num1 = Convert.ToInt32(Txt_num1.Text);
                num2 = Convert.ToInt32(Txt_num2.Text);

                lblResultado.Text = (num1 - num2).ToString();
                operacion = "-";

            }
            else
            {
                await DisplayAlert("Alert", "Llena todos los espacios", "OK");
            }
        }

        async void Alert(String message, object sender, EventArgs e)
        {
            await DisplayAlert("Alert", message, "OK");
        }

        private async void BtnSuma_Clicked(object sender, EventArgs e)
        {
            if (Txt_num1.Text != null && Txt_num2.Text != null)
            {
                var num1 = 0;
                var num2 = 0;
                num1 = Convert.ToInt32(Txt_num1.Text);
                num2 = Convert.ToInt32(Txt_num2.Text);

                lblResultado.Text = (num1+num2).ToString();

                operacion = "+";

            }
            else
            {
                await DisplayAlert("Alert", "Llena todos los espacios", "OK");
            }
        }
    }
}
