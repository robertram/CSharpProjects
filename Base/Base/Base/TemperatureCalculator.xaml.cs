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
    public partial class TemperatureCalculator : ContentPage
    {
        public TemperatureCalculator()
        {
            InitializeComponent();
            convetirAFarenheit.Clicked += ConvetirAFarenheit;
            convetirACentigrados.Clicked += ConvetirACentigrados;
        }

        private void ConvetirAFarenheit(object sender, EventArgs e)
        {
            var faren = 0;
            var cent = 0;
            faren = Convert.ToInt32(farenheitEntry.Text);
            cent = Convert.ToInt32(centigradosEntry.Text); 

            if (faren == 0) //Centigrados a Farenheit
            {

            }
            else
            {
                var resultadoFaren = cent *9/5 + 32;
                farenheitEntry.Text = resultadoFaren.ToString();
            }
        }

        private void ConvetirACentigrados(object sender, EventArgs e)
        {
            var faren = 0;
            var cent = 0;
            faren = Convert.ToInt32(farenheitEntry.Text);
            cent = Convert.ToInt32(centigradosEntry.Text);

            if (cent == 0) //Farenheit a Centigrados 
            {

            }
            else
            {
                var resultadoCent = (faren - 32) * 5 / 9;
                centigradosEntry.Text = resultadoCent.ToString();
            }
            
        }

    }
}