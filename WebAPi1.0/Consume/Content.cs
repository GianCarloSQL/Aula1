using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Consume
{

  
    public class Content
    {
        static HttpClient client;
        static Uri UsuarioUri;
        static string resultado;

        public static string GetWebContent()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            GetAll();
            return resultado;
        }
        private static async void GetAll()
        {
            HttpResponseMessage response = client.GetAsync("RS/Porto%20Alegre/all/json/").Result;
            if (response.IsSuccessStatusCode)
            {
                UsuarioUri = response.Headers.Location;
                var usuarios = await response.Content.ReadAsStringAsync();
                resultado = usuarios;
                formatString();
                Console.WriteLine(resultado);
                Console.ReadKey(true);
            }
            else
                Console.WriteLine(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }

        public static void formatString()
        {
            string r = "";
            r = resultado.Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "")
                .Replace('"', ' ').Replace(",", "").Trim().Replace(" ", "");
            resultado = r;
        }
    }

}

    

