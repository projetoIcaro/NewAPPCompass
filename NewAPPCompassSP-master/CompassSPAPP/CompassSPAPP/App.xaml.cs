using CompassSPAPP.VIewModel;
using CompassSPAPP.Views;
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

            MainPage = new CompassSPAPP.Views.LoginPage();
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSucesso",
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
