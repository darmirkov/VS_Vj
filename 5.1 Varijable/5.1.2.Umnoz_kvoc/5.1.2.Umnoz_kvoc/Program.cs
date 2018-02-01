using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._2.Umnoz_kvoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Unesite prvi broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Umnozak je: {0}", a*b);
            Console.WriteLine("Kvocijent je: {0}", (float)a / (float)b);
            Console.ReadKey();
        }
    }
}
