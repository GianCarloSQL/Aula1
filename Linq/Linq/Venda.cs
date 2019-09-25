using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Venda
    {

        public Venda(string prod, int qtd, double valor)
        {
            Produto = prod;
            Qtd = qtd;
            Valor = valor;
        }
        public string Produto { get; set; }
        public int Qtd { get; set; }
        public double Valor { get; set; }
    }
}
