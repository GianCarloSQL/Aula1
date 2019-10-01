using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class NoLista<T>
    {
        NoLista<T> prox;
        T info;
        public NoLista(T info) {
            this.info = info;
        }
        public void setProx(NoLista<T> proximo)
        {
            this.prox = proximo;
        }

        public NoLista<T> getProx() {
            return prox;
        }
        public T getInfo() {
            return this.info;
        }
    }
}
