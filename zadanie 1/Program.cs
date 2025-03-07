

using System;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest liczba parzysta, czy też nieparzysta.
            int a;
            Console.WriteLine("podaj liczbę całkowitą");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)

                Console.WriteLine("liczba jest parzysta", a);
            else
                Console.WriteLine("liczba jest nieparzysta", a);
            Console.ReadKey(true);

        }
    }
}
