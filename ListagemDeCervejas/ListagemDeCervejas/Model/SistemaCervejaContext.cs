using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {

        public static int count = 5;
        public List<Cerveja> cervejas { get; }
        public SistemaCervejaContext()
        {
            cervejas = new List<Cerveja>() {
                new Cerveja(0,"Budwaiser",0.6,11.1,6.5),
                new Cerveja(1,"Stella",0.35,8.0,4.5),
                new Cerveja(2,"Corona",1.0,9.9,8.5),
                new Cerveja(3,"Brahma",1.5,5.6,12.0),
                new Cerveja(4,"Skoll",2.1,6.7,8.3),
            };

        }
    }
}
