using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Model
{
    class CestaFrutas
    {
        List<string> listas;
        public void add(string fruta) {
            listas.Add(fruta);
        }
        public int MyProperty { get; set; }
        
    }
}
