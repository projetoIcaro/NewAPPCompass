using CompassSPAPP.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CompassSPAPP.VIewModel
{
    public class LoginViewModel {
        public ICommand LoginClickedCommand { get; set; }

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

                    MessagingCenter.Send<String>("", "LoginSucesso");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        }
    }
}
