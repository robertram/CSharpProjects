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
            btnSave.Clicked += BtnSave_Clicked;
            btnRestore.Clicked += BtnRestore_Clicked;
            btnBorrar.Clicked += BtnBorrar_Clicked;

        }

        private void BtnBorrar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                File.Delete(rutaCompleta);
                Txt_Restore.Text = "Borrado";
            }
        }

        

        private void BtnRestore_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                using (var lector = new StreamReader(rutaCompleta, true))
                {
                    String TextoLeido;
                    while ((TextoLeido=lector.ReadLine())!=null)
                    {

                        Txt_Restore.Text = TextoLeido;
                    }
                }
            }
            
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                using (var escritor = File.AppendText(rutaCompleta))
                {
                    escritor.Write(Txt_Guardar.Text);
                }
            }
            else
            {
                using (var escritor = File.CreateText(rutaCompleta))
                {
                    escritor.Write(Txt_Guardar.Text);
                }
            }
            Txt_Guardar.Text = "";
            Txt_Restore.Text = "";
        }
    }
}
