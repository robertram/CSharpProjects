using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Base.Model;

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
            BtnAllUser.Clicked += BtnAllUser_Clicked;
            BtnInsert.Clicked += BtnInsert_Clicked;
        }

        private void BtnInsert_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            UserRepository.Instancia.AddNewUser(txtUsername.Text, txtEmail.Text, txtPassword.Text);
            StatusMessage.Text = UserRepository.Instancia.EstadoMensaje;
        }
        private void BtnAllUser_Clicked(object sender, EventArgs e)
        {
            var allUsers = UserRepository.Instancia.GetAllUsers();
            
            userList.ItemsSource = allUsers;
            StatusMessage.Text = UserRepository.Instancia.EstadoMensaje;
        }
    }
}
