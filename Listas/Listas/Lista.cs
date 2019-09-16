using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{


    class ListaEncadeada<T>
    {

        NoLista<T> atual;

        public ListaEncadeada()
        {

        }
        public void Add(T info)
        {
            NoLista<T> no = new NoLista<T>(info);
            if (atual != null)
                no.setProx(atual);
            atual = no;

        }

        public string GetAll()
        {
            string aux = "";
            NoLista<T> no = atual;
            while (no != null)
            {
                aux += no.getInfo() + "\n";

                no = no.getProx();
            }
            return aux.Substring(0,aux.Length-1);
        }
    }

}
