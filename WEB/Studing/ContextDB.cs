using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFrame;
namespace Studing
{
    public class ContextDB : IMapTables
    {
        public ContextDB() {
        }

        public List<Modelo> modelos = new List<Modelo>();
        public List<Marca> marcas = new List<Marca>();
        
    }
}
