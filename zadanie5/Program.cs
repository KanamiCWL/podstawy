using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, v, pc;
            Console.WriteLine("podaj r= ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj h= ");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            v = 1.0 / 3 * Math.PI * r * r * h;
            pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("V={0}", v);
            Console.WriteLine("pc={0}", pc);
            Console.ReadKey(true);


        }
    }
}
