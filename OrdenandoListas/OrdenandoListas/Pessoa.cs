using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoListas
{
    public class Pessoa
    {
        public Pessoa(int cod,string nome,DateTime data,double carteira) {
            this.ID = cod;
            this.Nome = nome;
            this.DataNascimento = data;
            this.Carteira = carteira;
        }

        public Pessoa(String nome,int idade)
        {
        }
        public  int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento  { get; set; }
        public double Carteira { get; set; }
        public override string ToString()
        {
            // {indice, quantidade de casas}
            string template = "ID: {0,-3}  Nome: {1,-10} Data Nascimento: {2,10} Carteira: {3,5}";
            string text = string.Format(template, ID,Nome,DataNascimento.ToShortDateString(),Carteira.ToString("C"));
            return text; 
        }
    }
}
