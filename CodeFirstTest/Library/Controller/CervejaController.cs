using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
namespace Library.Controller
{
    public class CervejaController
    {
        Context contextDb = new Context(@"data source=(localdb)\MSSQLLocalDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cerveja c) {
            contextDb.Cervejas.Add(c);
        }
    }
}
