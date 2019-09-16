using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{


    class Lista<T>
    {

        NoLista<T> atual;

        public Lista()
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
                aux += no.getInfo() + ",";

                no = no.getProx();
            }
            return aux.Substring(0,aux.Length-1);
        }
    }

}
