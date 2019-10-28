using CompassSPAPP.Model;
using CompassSPAPP.Layers.Business;
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
            Search = new Search();
            Search.CPF = "39164301818";

            SearchClickedCommand = new Command(() =>
            {
                var jsonResult = new ResultBusiness().doSearchByCPF(Search.CPF);
                var result = new Result();
                result.JsonResult = jsonResult;
                new ResultBusiness().SaveActualResult(result);

                App.LoadGlobalVariables();

                MessagingCenter.Send<SearchViewModel>(this, "RealizaPesquisa");
            });
        }
        
    }
}
