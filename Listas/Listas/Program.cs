using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listas
{
    public class Program
    {

        static List<int> myList = new List<int>();

        public static void Main(string[] args)
        {
             testSingleton();
            // Console.WriteLine(FormataNumeroRealEmBitcoin(1));
          /*  Console.WriteLine("Valor a ser convertido: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Moeda: ");
            TipoMoeda moeda = (TipoMoeda)Enum.Parse(typeof(TipoMoeda), Console.ReadLine());
            Console.WriteLine( CovertCoin(valor, moeda));
            */
            Thread.Sleep(100000);
        }

        public static void conversaoNumeros()
        {
            int n = 10;
            Console.WriteLine($"Inteiro em decimal {n}: {n.ToString("C")}");
            double d = 10.10;
            Console.WriteLine($"Decimal em inteiro {d}: { d.ToString(".")}");
            Thread.Sleep(10000000);
        }


        public static void ListaDecimal()
        {
            var list = new List<double>();
            list.Add(3.5);
            list.Add(10.0);
            list.Add(1.8);
            list.Add(18.0);

            list.Where(i => i % 2 == 0).ToList().ForEach(i => Console.WriteLine(i));
        }

        public static void mostrar(List<int> lista)
        {
            lista.ForEach(n => Console.WriteLine(n));
        }

        public static void lista()
        {
            myList.Add(13);
            myList.Add(10);
            myList.Add(66);
            String aux = "";
            myList.ForEach(n => aux += (n % 2 == 0 ? aux = n + ": par" : aux = n + ": impar") + "\n");
            Console.WriteLine(aux);
            Thread.Sleep(10000000);
        }

        public static void expressao()
        {
            //myList.ForEach(n => aux += (n % 2 == 0 ? aux = n + ": par" : aux = n + ": impar") + "\n");
            //list.Where(i => i % 2 == 0).ToList().ForEach(i => Console.WriteLine(i));
        }

        public static void testSingleton()
        {
            AbstractClass ab = AbstractClass.GetInstance();
            ab.SetValue(10);
            AbstractClass ab2 = AbstractClass.GetInstance();
            ab2.SetValue(20);

            GCHandle objHandle = GCHandle.Alloc(ab, GCHandleType.WeakTrackResurrection);
            int address = GCHandle.ToIntPtr(objHandle).ToInt32();
            GCHandle objHandle2 = GCHandle.Alloc(ab2, GCHandleType.WeakTrackResurrection);
            int address2 = GCHandle.ToIntPtr(objHandle).ToInt32();

            Console.WriteLine($"{address} : {ab.GetValue()}");
            Console.WriteLine($"{address2} : {ab2.GetValue()}");

        }
        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.5252).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro : ");
        }
        /// <summary>
        /// metodo para converter valor em real em Dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns>retorna o valor formatado em Dolar</returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }/// <summary>
         /// converte real em Yen
         /// </summary>
         /// <param name="meuNumero">meu numero em real</param>
         /// <returns>retorna meu numero formatado em yen</returns>
        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.0379).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Converte real em Bitcoin
        /// </summary>
        /// <param name="meuNumero">numero em real</param>
        /// <returns>Retorna meu numero em Bitcoin</returns>
        private static string FormataNumeroDecimalEmBitcoin(double meuNumero)
        {
            return (meuNumero / 41796.93).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC : ");
        }
        public static string CovertCoin(double valor, TipoMoeda moeda)
        {
            switch (moeda)
            {
                case TipoMoeda.DOLAR:
                    return FormataNumeroDecimalEmDolar(valor);
                case TipoMoeda.YEN:
                    return FormataNumeroDecimalEmYen(valor);
                case TipoMoeda.EURO:
                    return FormataNumeroDecimalEmEuro(valor);
 
                default:
                    return $"{valor* 197.51} porém, vale mais que dinheiro";
                  
            }
            return null;
        }
    }
}

