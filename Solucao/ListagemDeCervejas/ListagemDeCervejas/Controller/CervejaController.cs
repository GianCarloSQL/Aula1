using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        public SistemaCervejaContext context { get; set; }
        public CervejaController()
        {
            context = new SistemaCervejaContext();
        }

        public void ListaCervejas()
        {
            context.cervejas.ForEach(c => Console.WriteLine(c.ToString()));
        }
        public string GetCervejas()
        {
            string aux = "";
            context.cervejas.ForEach(c => aux += c.ToString() + "\n");
            return aux;
        }
        /// <summary>
        /// Este metodo adiciona uma cerveja na lista
        /// </summary>
        /// <param name="c"></param>
        public void AdicionaCerveja(Cerveja c)
        {
            c.ID = SistemaCervejaContext.count++;
            context.cervejas.Add(c);
        }
        /// <summary>
        /// Este metodo adiciona todas as cervejas da Colecao informada
        /// como parametro ao final da lista
        /// </summary>
        /// <param name="cervejas">Collection contendo as cervejas</param>
        public void AdicionaCerveja(IEnumerable<Cerveja> cervejas)
        {
            foreach (var c in cervejas)
            {
                c.ID = SistemaCervejaContext.count++;
                context.cervejas.Add(c);
            }
        }
        public double GetValorTotal()
        {
            return context.cervejas.Sum(c => c.Valor);
        }
        public double GetTotalLitros()
        {
            double aux = 0;
            context.cervejas.ForEach(c => aux += c.Litros);
            return aux;
        }
        public bool IsPresso(double Peso)
        {
            double aux = 0;
            context.cervejas.ForEach(c => aux += (c.Litros * 1000) / c.Alcool);
            return ((Peso * 0.08) / aux) > 0.016;
        }
        public void RemoveCerveja()
        {
            context.cervejas.RemoveAt(context.cervejas.Count - 1);
        }
    }
}
