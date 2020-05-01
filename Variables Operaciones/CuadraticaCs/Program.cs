using System;

namespace CuadraticaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de la X");
            Console.WriteLine("");
            int a = 1;
            int b = 5;
            int c = 2;

            double x = Math.Pow(b, 2) - 4 * a * c;
            x = x / 2 * a;


            Console.WriteLine("X = " + x);
        }
    }
}
