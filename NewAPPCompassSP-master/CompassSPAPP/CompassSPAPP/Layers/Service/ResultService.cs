using System;
using System.Net.Http;
using System.Text;
using CompassSPAPP.Model;
using Newtonsoft.Json;


namespace CompassSPAPP.Layers.Service
{
    public class ResultService
    {
        public Result getResultByCPF(string cpf)
        {
            try
            {
                var url = "http://10.0.2.2:3006/api/arpenp/GetData";

                System.Net.Http.HttpClient client = new HttpClient();
                var resposta = client.GetAsync(url).Result;

                if (resposta.IsSuccessStatusCode)
                {
                    var result = new Result();
                    var resultado = resposta.Content.ReadAsStringAsync().Result;
                    result.JsonResult = resultado;
                    return result;
                }
                else
                {
                    throw new Exception("Dados do investidor não encontrado!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Dados do investidor não encontrado!");
            }
        }
    }
}
