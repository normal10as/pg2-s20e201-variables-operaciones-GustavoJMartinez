using System;

namespace CotizacionTerrenoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorcostos = 3.5;
            int costofijo = 10700;
            double costo;
            Console.Write("Ingrese descripción de producto: ");
            string descripcion = Console.ReadLine();
            Console.Write("Ingrese número de unidades: ");
            int numuni = Convert.ToInt32(Console.ReadLine());
            costo = numuni * factorcostos + costofijo;
            Console.WriteLine("El producto " + descripcion + " tiene un costo de producción de: " + costo);
        }
    }
}
