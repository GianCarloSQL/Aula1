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
            this.iD = cod;
            this.nome = nome;
            this.DataNascimento = data;
            this.carteira = carteira;
        }
        public  int iD { get; set; }
        public string nome { get; set; }
        public DateTime DataNascimento  { get; set; }
        public double carteira { get; set; }
    }
}
