using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class Cerveja
    {
        public Cerveja()
        {
        }

        public Cerveja(string nome, double litro, double alcool, double valor)
        {
            Nome = nome;
            Litros = litro;
            Alcool = alcool;
            Valor = valor;
        }

        public Cerveja(int id, string nome, double litro, double alcool, double valor)
        {
            ID = id;
            Nome = nome;
            Litros = litro;
            Alcool = alcool;
            Valor = valor;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Litros { get; set; }
        public double Alcool { get; set; }
        public double Valor { get; set; }
        public override string ToString()
        {
            string template = "ID {0,-3}|Nome |{1,-10}|Litros {2,-5}|Alcool {3,-5}|Valor {4,-8}";
            return string.Format(template, ID, Nome, Litros, Alcool, Valor);
        }

    }
}
