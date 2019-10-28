using CompassSPAPP.VIewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompassSPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{

        protected LoginViewModel loginViewModel;

        public LoginPage ()
		{
			InitializeComponent ();
		}
	}
}