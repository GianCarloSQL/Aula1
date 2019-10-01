using ListagemDeCarros.Model;
using SistemaDeCarroBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        private SistemaCarrosContext context;
        public CarroController()
        {
            context = new SistemaCarrosContext();
        }

        /// <summary>
        /// Este Metodo mostra todos os carros existentes na lista de Carros no Console
        /// </summary>
        public void ListaCarrosConsole()
        {
            context.listaCarros.ForEach(c => Console.WriteLine(c.ToString()));
        }

        /// <summary>
        /// Retorna todos os carros contidos na lista separados por linha
        /// </summary>
        /// <returns> string contendo os carros da lista</returns>
        public string ListaCarros()
        {
            string aux = "";
            context.listaCarros.ForEach(c => aux += c.ToString() + "\n");
            return aux;
        }

        /// <summary>
        /// Este metodo percorre a lista de carros e retorna todos os carros 
        /// que satisfaçam a condição informada pelos parametros.
        /// </summary>
        /// <param name="prop"> Propriedade da Classe</param>
        /// <param name="igual"> Valor para comparar com a propriedade</param>
        /// <returns></returns>
        public string ListaCarros(string prop, string igual)
        {
            string aux = "";
            List<Carro> c = context.listaCarros.FindAll(x => x.Compara(prop) == igual);
            c.ForEach(x => aux += x.ToString() + "\n");
            return aux;
        }
        public List<Carro> GetListaCarros() {
            return context.listaCarros;
        }
    }

}
