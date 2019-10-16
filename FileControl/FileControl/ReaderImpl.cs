using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoTech.Controller;
using MercadoTech.Model;
namespace FileControl
{
    public class ReaderImpl : AbsctractReader
    {
        Controller controller = new Controller();
        
        public static string path = @"C:\src\RedirectApplication\RedirectApplication\301s.xlsx";
        public override void ExcellReader(string Arquivo)
        {
            OleDbConnection conn = new OleDbConnection();
            DataTable dt = new DataTable();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Arquivo + ";Extended Properties=Excel 12.0;";
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from [" + "Modelo" + "$]";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                {
                   controller.Context.Modelo.Add(new Modelo()
                    {
                        Codigo = 16 + int.Parse(item[0].ToString()),
                        Nome = item[1].ToString()
                    }) ;
                //    Console.Write(item[0].ToString() + "       |       " + item[1].ToString());
                }

            }
            Console.WriteLine("Feito!");
            controller.Context.SaveChanges();
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }
    }
}
