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
    class Program
    {

        static List<int> myList = new List<int>();

        public static void Main(string[] args)
        {
            testSingleton();
            // Console.WriteLine(FormataNumeroRealEmBitcoin(1));
            Thread.Sleep(100000);
        }

        public void conversaoNumeros() {
            int n = 10;
            Console.WriteLine($"Inteiro em decimal {n}: {n.ToString("C")}");
            double d = 10.10;
            Console.WriteLine($"Decimal em inteiro {d}: { d.ToString(".")}");
            Thread.Sleep(10000000);
        }


        public static void ListaDecimal() {
            var list = new List<double>();
            list.Add(3.5);
            list.Add(10.0);
            list.Add(1.8);
            list.Add(18.0);

            list.Where(i => i %2==0).ToList().ForEach(i => Console.WriteLine(i));   
        }

        public static void mostrar(List<int> lista)
        {
            lista.ForEach(n => Console.WriteLine(n));
        }

        public static void lista() {
            myList.Add(13);
            myList.Add(10);
            myList.Add(66);
            String aux = "";
            myList.ForEach(n => aux += (n % 2 == 0 ? aux = n + ": par" : aux = n + ": impar") + "\n");
            Console.WriteLine(aux);
            Thread.Sleep(10000000);
        }

        public static void expressao() {
            //myList.ForEach(n => aux += (n % 2 == 0 ? aux = n + ": par" : aux = n + ": impar") + "\n");
            //list.Where(i => i % 2 == 0).ToList().ForEach(i => Console.WriteLine(i));
        }

        public static void testSingleton() {
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
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.5252).ToString("C", CultureInfo.CreateSpecificCulture("eu-EU"));
        }

        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.0379).ToString("C", CultureInfo.CreateSpecificCulture("ja-JA"));
        }
        private static string FormataNumeroRealEmBitcoin(double meuNumero)
        {
            return (meuNumero / 41796.93).ToString("C", CultureInfo.CreateSpecificCulture(""));
        }
    }
}

