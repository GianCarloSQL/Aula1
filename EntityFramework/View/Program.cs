using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Control;
using EntityLibrary.Model;
namespace View
{
    class Program
    {
        static PessoaController Pessoa = new PessoaController();
        static void Main(string[] args)
        {
            Pessoa.AddPessoa(new Pessoa() { Nome = "Jean"});
            Pessoa.GetPessoas().ToList().ForEach(p =>  Console.WriteLine(p.Nome));
            Console.ReadKey();
        }
    }
}
