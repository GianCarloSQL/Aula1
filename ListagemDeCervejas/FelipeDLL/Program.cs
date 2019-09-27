using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;
namespace FelipeDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            //   HoraDoShow h = new HoraDoShow();
            //  h.Birllllllllll();
            try
            {
                DocumentsAutoGenerate d = new DocumentsAutoGenerate();
                d.CriarPastaMeusDocumentos("Gian");
                d.DeletarPastaMeusDocumentos("Gian", false);
                d.ObterPastasDiretorioMeuDocumentos().ForEach(a => Console.WriteLine(a));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro");
                throw;
            }

          
        }

    }
}
