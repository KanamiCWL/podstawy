
using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.Write("podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("witaj {0}!", imie);
            Console.ReadKey(true);

        }
    }
}
