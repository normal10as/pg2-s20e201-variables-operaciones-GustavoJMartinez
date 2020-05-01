using System;

namespace AreaCirculoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del Área de un circulo");
            Console.WriteLine("");

            Console.Write("Ingrese el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = 3.1415 * Math.Pow(radio, 2);
            Console.WriteLine("El Área del circulo es: " + area);

        }
    }
}
