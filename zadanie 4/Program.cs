using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pole={0}", a * b);
            Console.WriteLine("obwód={0}", 2 * a + 2 * b);
            Console.ReadKey(true);

        }
    }
}
