using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataFrame
{
    public class Context<T> where T : MapTables
    {
        public List<List<object>> ListOfTables;
    
        public void GetTablesList()
        {
            foreach (PropertyInfo prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)) {
               
            }

        }
    }
}
