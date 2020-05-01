using System;

namespace EquivalenciasPiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de equivalencia en pies");
            Console.WriteLine("");

            Console.Write("Ingrese distancia en pies: ");
            double pies = Convert.ToDouble(Console.ReadLine());

            double pulgadas = pies * 12;
            double yardas = pies * 0.33;
            double metro = pies * 0.305;
            double centimetros = pies * 30.48;

            Console.WriteLine(pies + " pies son " + pulgadas + " pulgadas, " + yardas + " yardas, " + metro + " metros, " + centimetros + " centimetros.");
        }
    }
    
}
