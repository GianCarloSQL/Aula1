using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeCarroBackEnd.Model
{
    public class Carro
    {
        public Carro()
        {
        }

        public Carro(int id, string marca, string modelo, int ano, int cilindrada, int porta)
        {
            ID = id;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cilindradas = cilindrada;
            Portas = porta;
        }

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Cilindradas { get; set; }
        public int Portas { get; set; }
        public override string ToString()
        {
            string template = "{0,-3}|{1,-10}|{2,-10}|{3,-5}|{4,-4}|{5,-2}";
            return string.Format(template, ID, Marca, Modelo, Ano, Cilindradas, Portas);
        }

        internal string Compara(string prop)
        {
            switch (prop)
            {
                case "Id":
                    return ID +"";
                case "Marca":
                    return Marca;
                case "Modelo":
                    return Modelo;
                case "Ano":
                    return Ano + "";
                case "Portas":
                    return Portas + "";
                case "Cilindrada":
                    return Cilindradas + "";
                default:
                    break;
            }
            return null;
        }
    }
}
