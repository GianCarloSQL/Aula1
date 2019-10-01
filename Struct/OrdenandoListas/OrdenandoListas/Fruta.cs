using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoListas
{
    public class Fruta
    {
        static int indice = 0;
        public Fruta(string name, string cor, double peso)
        {
            this.ID = indice;
            indice++;
            this.Name = name;
            this.Cor = cor;
            this.Peso = peso;
        } 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Cor { get; set; }
        public double Peso { get; set; }
    }
}
