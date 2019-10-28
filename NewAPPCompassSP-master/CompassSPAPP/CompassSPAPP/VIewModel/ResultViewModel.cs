using CompassSPAPP.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CompassSPAPP.VIewModel
{
    public class ResultViewModel
    {
        public Result Result { get; set; }

        public ResultViewModel()
        {
            Result.JsonResult = "Teste: {" +
                "batata : 1" +
                "}";
        }
    }
}
