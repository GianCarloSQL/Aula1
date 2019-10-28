
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIDADE.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class CalculoController : ApiController
    {

        public string Get()
        {
            return "App para poder beber hoje";
        }
        public string Get(int ano)
        {
            return (DateTime.Now.Year - ano) >= 18 ? "App para poder beber hoje" : "Não Pode nao";
        }
        public string Get(int[] args)
        {
            string retorno = "";
            foreach (var item in args)
            {
                retorno += item + "\n";
            }
            return retorno;
        }

        public string Get(double altura,double peso, string nome)
        {
            var x = peso / (altura * altura);
            return $"Ola {nome} seu imc é {x*10000}";
        }
    }
}
