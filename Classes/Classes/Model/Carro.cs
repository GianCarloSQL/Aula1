using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Model
{
    class Carro
    {
        public Carro(string marca,string modelo,int ano,double valor,string placa) {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Valor = valor;
            this.Placa = placa;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Valor { get; set; }
        public string Placa { get; set; }

        override
        public string ToString()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}\nValor: {Valor}\nPlaca: {Placa}";
        }
    }
}
