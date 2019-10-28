using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculandoIDADE.Models
{
    public class IMC
    {
        public IMC(string name) {
            Nome = name;
        }
        public double valor { get; set; } = 0;
        public double Peso { get; set; } = 0;
        public double Altura { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;

        internal double GetIMC()
        {
            var x = (Peso / (Altura * Altura)) * 10000;
            return x;
        }
    }
}