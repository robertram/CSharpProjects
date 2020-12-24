using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

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
            
            ButtonVibrate.Clicked += ButtonVibrate_Clicked;
            ButtonCancel.Clicked += ButtonCancel_Clicked;
            ButtonHablar.Clicked += ButtonHablar_Clicked;
            btnMail.Clicked += BtnMail_Clicked;
        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonVibrate_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void ButtonHablar_Clicked(object sender, EventArgs e)
        {
            //SpeakNowDefaultSettings();
            await TextToSpeech.SpeakAsync(EntryText.Text, new SpeechOptions
            {
                Volume = (float)SliderVolume.Value
            }
            );
        }

        private async void BtnMail_Clicked(object sender, EventArgs e)
        {
            var message = new EmailMessage(EntrySubject.Text, EntryEmail.Text);
            //message.Attachments =
            message.Body = "Un mensaje simple";
            await Email.ComposeAsync(message);
        }
    }
}
