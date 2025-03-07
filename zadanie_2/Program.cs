using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.
            int a;
            Console.WriteLine("podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) 
                Console.WriteLine("liczba jest dodatnia", a);
            else if (a < 0)
                Console.WriteLine("liczba jest ujemna", a);
            else
                Console.WriteLine("liczba jest równa zero", a);
            Console.ReadKey(true);
        }
    }
}
