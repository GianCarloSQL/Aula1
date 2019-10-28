
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculandoIDADE.Models;

namespace CalculandoIDADE.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoController : ApiController
    {
        List<IMC> ListaIMC = new List<IMC>() {
            new IMC("Gian")
        };
        
        public List<IMC> Get()
        {
            return ListaIMC;
        }
        public string Get(int ano)
        {
            return (DateTime.Now.Year - ano) >= 18 ? "App para poder beber hoje" : "Não Pode nao";
        }

        public string Get(double altura, double peso, string nome)
        {
            var x = peso / (altura * altura);
            return $"Ola {nome} seu imc é {x * 10000}";
        }
        public IMC Post(IMC value)
        {
            value.valor = value.GetIMC();
            ListaIMC.Add(value);
            return value;
        }
    }
}
