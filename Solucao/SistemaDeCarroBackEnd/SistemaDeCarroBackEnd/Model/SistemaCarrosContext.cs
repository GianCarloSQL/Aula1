using SistemaDeCarroBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> listaCarros { get; }
        /// <summary>
        /// XGH APPROVED
        /// </summary>
        public SistemaCarrosContext()
        {
            listaCarros = new List<Carro>();
            listaCarros.Add(new Carro(0, "VW", "Gol", 2010, 75, 4));
            listaCarros.Add(new Carro(1, "Chevrolet", "Corsa", 2011, 76, 2));
            listaCarros.Add(new Carro(2, "Toyota", "Corolla", 2012, 120, 4));
            listaCarros.Add(new Carro(3, "Toyota", "Hilux", 2018, 220, 4));
            listaCarros.Add(new Carro(4, "Toyota", "Etius", 2017, 110, 2));
            listaCarros.Add(new Carro(5, "VW", "Golf", 2011, 90, 2));
            listaCarros.Add(new Carro(6, "Fiat", "Uno", 2012, 75, 2));
            listaCarros.Add(new Carro(7, "Fiat", "Uno Mile", 1998, 75, 2));
            listaCarros.Add(new Carro(8, "Fiat", "Palio", 2006, 75, 4));
            listaCarros.Add(new Carro(9, "VW", "Gol Bola", 2010, 75, 4));

        }

    }
}
