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
    public partial class TareaClase3Otros : ContentPage
    {
        public TareaClase3Otros()
        {
            InitializeComponent();
        }

        void OnPlatformRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            platformLabel.Text = $"You have chosen: {button.Text}";
        }
         

        void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            lblSwitch.Text = String.Format("Switch is now {0}", e.Value);
        }
    }
}