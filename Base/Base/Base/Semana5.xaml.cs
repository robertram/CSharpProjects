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
    public partial class Semana5 : ContentPage
    {
        public IList<Provincia> Provincias
        {
            get;
            private set;
        }

        public Semana5()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
            Provincias = new List<Provincia>();
            Provincias.Add(new Provincia
            {
                Name = "San José",
                Ubicacion = "Central",
                Url ="https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Blason_de_San_Jos%C3%A9_%28Costa_Rica%29.svg/800px-Blason_de_San_Jos%C3%A9_%28Costa_Rica%29.svg.png"
            });
            Provincias.Add(new Provincia
            {
                Name = "Alajuela",
                Ubicacion = "Norte",
                Url ="https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Escudo_de_la_Provincia_de_Alajuela.svg/800px-Escudo_de_la_Provincia_de_Alajuela.svg.png"
            });
            Provincias.Add(new Provincia
            {
                Name = "Heredia",
                Ubicacion = "Norte",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Escudo_de_Heredia.svg/91px-Escudo_de_Heredia.svg.png"
            });
            Provincias.Add(new Provincia
            {
                Name = "Cartago",
                Ubicacion = "Norte",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/Escudo_de_Cartago_%28Costa_Rica%29.svg/150px-Escudo_de_Cartago_%28Costa_Rica%29.svg.png"
            });
            Provincias.Add(new Provincia
            {
                Name = "Puntarenas",
                Ubicacion = "Norte",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Escudo_de_la_Provincia_de_Puntarenas.svg/150px-Escudo_de_la_Provincia_de_Puntarenas.svg.png"
            });
            Provincias.Add(new Provincia
            {
                Name = "Limón",
                Ubicacion = "Norte",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3b/Escudo_de_la_Provincia_de_Lim%C3%B3n.svg/150px-Escudo_de_la_Provincia_de_Lim%C3%B3n.svg.png"
            });
            BindingContext = this;
        }

        public async Task ShowProvinceAsync(String Provincia)
        {
            await DisplayAlert("Titulo", Provincia, "Aceptar");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Provincia selectedItem = e.SelectedItem as Provincia;
            ShowProvinceAsync(selectedItem.Name);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Provincia tappedItem = e.Item as Provincia;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            //string respuesta = txtNombre.Text + " - " + txtNuevoMensaje.Text;
            //AvisoAsync2(respuesta);
            //Grid.IsVisible = !Grid.IsVisible;
        }

        public async Task AvisoAsync()
        {
            await DisplayAlert("Titulo", "Mensaje", "Aceptar");
        }
        public async Task AvisoAsync2(String Data)
        {
            await DisplayAlert("Titulo", Data, "Aceptar");
        }

        public async Task ValidadorOpc()
        {
            bool respuesta = await DisplayAlert("Elegir", "Desea borrar los datos?", "Aceptar", "Cancelar");
            AvisoAsync2(respuesta.ToString());
        }
    }

}