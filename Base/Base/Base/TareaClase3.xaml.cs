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
    public partial class TareaClase3 : ContentPage
    {
        public TareaClase3()
        {
            InitializeComponent();
            btnNavigationBack.Clicked += OnPreviousPageButtonClicked;
            bntAceptarChbx.Clicked += AceptarChbx;
        }

        private void AceptarChbx(object sender, EventArgs e)
        {
            bool isChecked1 = chbx1.IsChecked;//Batería
            bool isChecked2 = chbx2.IsChecked;//Guitarra
            bool isChecked3 = chbx3.IsChecked;//Ambos

            if (isChecked1) //Batería
            {
                lblBatería.Text += " Si";
            }
            else if (isChecked2) //Guitarra
            {
                lblGuitarra.Text += " Si";
            }
            else if(isChecked3) //Ambos
            {
                lblAmbos.Text += " Si";
            }
            else
            {
                
            }
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void CheckboxChanged(object sender, EventArgs e)
        {
            
        }
    }
}