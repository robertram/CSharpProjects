using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using System.IO;
using System.Reflection;

namespace Base
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ISimpleAudioPlayer player;
        public MainPage()
        {
            InitializeComponent();
            var stream = GetStreamFromFile("music1.mp3");
            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            player.Load(stream);

            InitControl();

        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("Base." + filename);
            return stream;
        }

        private void InitControl()
        {
            btnPlay.Clicked += BtnPlay_Clicked;
            btnPause.Clicked += BtnPause_Clicked;
            btnStop.Clicked += BtnStop_Clicked;

        }

        private void BtnPlay_Clicked(object sender, EventArgs e)
        {
            player.Play();
        }

        private void BtnPause_Clicked(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {
            player.Stop();
        }
        






    }
}
