using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Carro


    {

        public Carro(int id,string marca, double valor, int qtd,DateTime data) {
            ID = id;
            Marca = marca;
            Valor = valor;
            Quantidade = qtd;
            Data = data;
        }
        public int ID { get; set; }
        public string Marca { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
