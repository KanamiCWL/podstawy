using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.
            int a, b, calkowita, reszta;
            Console.WriteLine("podaj a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b= ");
            b = Convert.ToInt32(Console.ReadLine());
            calkowita = a / b;
            reszta = a % b;
            Console.WriteLine("calkowita={0}", calkowita);
            Console.WriteLine("reszta={0}", reszta);
            Console.ReadKey(true);

        }
    }
}
