using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace DataFrame
{
    public class Map<T> where T : new()
    {
        static string connectionString;

        public static string NomeDB { get; set; }
        public Map(string Connection, string nomedb)
        {
            connectionString = Connection;
            NomeDB = nomedb;
        }

        public void CreateTables()
        {
            CreateDataBase();
            CreateCommand(CmdCreateTable(), false);
        }

        private static bool CreateCommand(string queryString, bool IsDB)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                int r = -1;
                if (IsDB)
                {
                    r = (int)command.ExecuteScalar();

                }
                else
                {
                    r = command.ExecuteNonQuery();
                }
                return r != 1 ? true : false;
            }
        }
        private void CreateDataBase()
        {
            var Check = $"SELECT top 1 COUNT(*) FROM sys.databases where name = '{NomeDB}'";
            if (CreateCommand(Check, true))
            {
                CreateCommand($"CREATE DATABASE {NomeDB}", false);
            }
        }

        public string CmdCreateTable()
        {
            string properties = "";
            var m = GetTables();
            m.ForEach(x => Console.WriteLine(x));
            /* foreach (PropertyInfo prop in typeof(object).GetProperties(BindingFlags.Public | BindingFlags.Instance))
             {
                  if (prop.PropertyType == typeof(string))
                  {
                      properties += $"{prop.Name.ToUpper()} nvarchar(100),";
                  }
                  else if (prop.PropertyType == typeof(int))
                  {
                      properties += $"{prop.Name.ToUpper()} int,";
                  }
             }*/

            string aux = $"use {NomeDB} ; Create table {typeof(object).Name} (" +
                         $"Id int identity (1,1), {properties} PRIMARY KEY (Id) " +
                         $");";
            return aux;
        }
        public List<object> GetTables()
        {
             /*var objectType = new T().GetType();
             var obj = Activator.CreateInstance(objectType);*/

            var Tables = new List<object>();

            foreach (PropertyInfo prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                Tables.Add(prop);
            }
            return Tables;
        }
    }

}
