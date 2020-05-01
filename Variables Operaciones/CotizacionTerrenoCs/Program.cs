using System;

namespace CotizacionTerrenoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Cotización de un Terreno");
            Console.WriteLine("");

            Console.Write("Ingrese el ancho en metros: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el Largo en metros: ");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el costo del metro cuadrado: ");
            double costometro = Convert.ToDouble(Console.ReadLine());

            double cotizacion = ancho * largo * costometro;

            Console.WriteLine("La cotizacion del terreno es de: " + cotizacion);
        }
    }
}
