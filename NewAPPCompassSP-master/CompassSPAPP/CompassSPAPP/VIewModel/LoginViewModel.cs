using CompassSPAPP.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CompassSPAPP.VIewModel
{
    public class LoginViewModel
    {
        public ICommand LoginClickedCommand { get; private set; }

        public Usuario Usuario { get; set; }

        public LoginViewModel()
        {
            Usuario = new Usuario();
            Usuario.Login = "guizanella";
            Usuario.Senha = "guizanella";

            LoginClickedCommand = new Command(() => {
                try
                {
                    //Efetuando Login
                    MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        }
    }
}
