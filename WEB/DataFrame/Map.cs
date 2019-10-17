using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataFrame
{
    public class Map<T>
    {
        public void CreateTable()
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                if (prop.PropertyType == typeof(string))
                {
                    Console.WriteLine("Create a string");
                }
                else if (prop.PropertyType == typeof(int))
                {
                    Console.WriteLine("Create a int");
                }

            }
        }


        private static void CreateCommand(string queryString,
          string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
