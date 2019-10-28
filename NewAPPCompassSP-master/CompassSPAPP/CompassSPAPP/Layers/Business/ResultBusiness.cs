using System;
using System.Collections.Generic;
using System.Text;
using CompassSPAPP.Layers.Service;
using CompassSPAPP.Model;

namespace CompassSPAPP.Layers.Business
{
    public class ResultBusiness
    {
        public String doSearchByCPF(string cpf)
        {
            var response = new ResultService().getResultByCPF(cpf);
            return response.JsonResult;
        }
        public Model.Result getActualResult()
        {
            var result = new Data.ResultData().Get();

            if (result != null)
            {
                return result;
            }

            return new Model.Result();
        }
        
        public void SaveActualResult(Result result)
        {
            new Data.ResultData().Insert(result);
        }
    }
}
