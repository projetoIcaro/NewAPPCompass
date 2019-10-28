using CompassSPAPP.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CompassSPAPP.VIewModel
{
    public class SearchViewModel
    {

        public ICommand SearchClickedCommand { get; private set; }
            
        public Search Search { get; set; }

        public SearchViewModel()
        {
            Search.CPF = "39164301818";

            SearchClickedCommand = new Command(() =>
            {
                MessagingCenter.Send<SearchViewModel>(this, "RealizaPesquisa");
            });
        }
        
    }
}
