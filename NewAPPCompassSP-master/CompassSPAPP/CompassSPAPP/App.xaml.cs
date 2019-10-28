using CompassSPAPP.VIewModel;
using CompassSPAPP.Views;
using CompassSPAPP.Model;
using CompassSPAPP.Layers.Business;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CompassSPAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Método Interno que carrega variáveis (Objetos) Globais
            LoadGlobalVariables();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<String>("", "LoginSucesso",
                (sender) =>
                {
                    MainPage = new SearchPage();
                });

            MessagingCenter.Subscribe<SearchViewModel>(this, "RealizaPesquisa",
                (sender) =>
                {
                    MainPage = new ResultPage();
                });
        }

        internal static void LoadGlobalVariables()
        {
            // Carregando a lista de Perfil para acesso Global
            Model.Global.result = new ResultBusiness().getActualResult();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
