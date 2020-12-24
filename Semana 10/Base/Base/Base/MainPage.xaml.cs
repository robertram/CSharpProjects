using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Base.Models;

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
            btnGuardar.Clicked += BtnGuardar_Clicked;
            btnLeer.Clicked += BtnLeer_Clicked;
            btnLimpiar.Clicked += BtnLimpiar_Clicked;
        }

        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            entryNombre.Text = "";
        }

        private void BtnLeer_Clicked(object sender, EventArgs e)
        {
            var allAgendas = AgendaRepository.Instancia.GetAllAgendas();
            agendasList.ItemsSource = allAgendas;
            lblResultado.Text = AgendaRepository.Instancia.EstadoMensaje;
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            entryNombre.Text = string.Empty;
            AgendaRepository.Instancia.AddNewAgenda(entryNombre.Text);
            lblResultado.Text = AgendaRepository.Instancia.EstadoMensaje;
        }
    }
}
