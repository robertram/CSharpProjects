using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Base.Models;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Globalization;

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
            GetExrate();
        }

        private void GetExrate()
        {
            //link xml del banco
            string url = "https://portal.vietcombank.com.vn/Usercontrols/TVPortal.TyGia/pXML.aspx?b=68";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //obtener Respuesta
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Llamada GetResponseStream para retornar flujo
            Stream responseStream = response.GetResponseStream();
            //Convertir XML en el modelo C#
            XmlSerializer serializer = new XmlSerializer(typeof(ExrateList));
            ExrateList exrateList = (ExrateList)serializer.Deserialize(responseStream);
            LabelDate.Text = "Date: " + exrateList.DateTime;
            //AUD
            LabelAUDBuy.Text = exrateList.Exrates[0].Buy;
            LabelAUDSell.Text = exrateList.Exrates[0].Sell;
            //CAD
            LabelCADBuy.Text = exrateList.Exrates[1].Buy;
            LabelCADSell.Text = exrateList.Exrates[1].Sell;

            //CHF
            LabelCHFBuy.Text = exrateList.Exrates[2].Buy;
            LabelCHFSell.Text = exrateList.Exrates[2].Sell;

            //DKK
            LabelDKKBuy.Text = exrateList.Exrates[3].Buy;
            LabelDKKSell.Text = exrateList.Exrates[3].Sell;

            //EUR
            LabelEURBuy.Text = exrateList.Exrates[4].Buy;
            LabelEURSell.Text = exrateList.Exrates[4].Sell;

            //GBP
            LabelGBPBuy.Text = exrateList.Exrates[5].Buy;
            LabelGBPSell.Text = exrateList.Exrates[5].Sell;

            //HKD
            LabelHKDBuy.Text = exrateList.Exrates[6].Buy;
            LabelHKDSell.Text = exrateList.Exrates[6].Sell;

            //INR
            LabelINRBuy.Text = exrateList.Exrates[7].Buy;
            LabelINRSell.Text = exrateList.Exrates[7].Sell;

            //JPY
            LabelJPYBuy.Text = exrateList.Exrates[8].Buy;
            LabelJPYSell.Text = exrateList.Exrates[8].Sell;

            //KRW
            LabelKRWBuy.Text = exrateList.Exrates[9].Buy;
            LabelKRWSell.Text = exrateList.Exrates[9].Sell;

            //KWD
            LabelKWDBuy.Text = exrateList.Exrates[10].Buy;
            LabelKWDSell.Text = exrateList.Exrates[10].Sell;

            //MYR
            LabelMYRBuy.Text = exrateList.Exrates[11].Buy;
            LabelMYRSell.Text = exrateList.Exrates[11].Sell;

            //NOK
            LabelNOKBuy.Text = exrateList.Exrates[12].Buy;
            LabelNOKSell.Text = exrateList.Exrates[12].Sell;

            //RUB
            LabelRUBBuy.Text = exrateList.Exrates[13].Buy;
            LabelRUBSell.Text = exrateList.Exrates[13].Sell;

            //USD
            LabelUSDBuy.Text = exrateList.Exrates[14].Buy;
            LabelUSDSell.Text = exrateList.Exrates[14].Sell;
        }
    }
}
