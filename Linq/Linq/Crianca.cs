using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Crianca
    {
        public Crianca(string nome, int bala) {
            this.Balas = bala;
            this.Nome = nome;
        }
        public string Nome { get; set; }
        public int Balas { get; set; }
    }
}
