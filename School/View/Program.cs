using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SchoolBackEnd.Controller;
using SchoolBackEnd.Model;
namespace View
{
    class Program
    {
        static AlunoController Controller = new AlunoController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE GERENCIAMENTO DE ALUNOS");
            var opcao ="";
            while (true) {
                Console.WriteLine("Selecione uma Opção ");
                Console.WriteLine("0 - Sair ");
                Console.WriteLine("1 - Mostrar todos os alunos");
                Console.WriteLine("2 - Cadastrar Aluno ");
                Console.WriteLine("3 - Salvar");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":                    
                        System.Environment.Exit(0);
                        break;
                    case "1":
                        Console.Clear();
                        Controller.GetAlunos().ToList().ForEach(x => Console.WriteLine(x.ToString()));
                        Console.WriteLine("----------------------------------");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Informe o nome do Aluno");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Informe a Idade do Aluno");
                        var idade = Console.ReadLine();
                        Controller.AddAluno(new Aluno(nome, int.Parse(idade)));
                        break;
                    case "3":
                        Console.Clear();
                        Controller.SaveChanges();
                        var aux = ".";
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Clear();
                            Console.Write("Saving" + aux);
                            Thread.Sleep(200);
                            aux += ".";
                        }
                        Console.Clear();
                        Console.Write("Saved!");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
