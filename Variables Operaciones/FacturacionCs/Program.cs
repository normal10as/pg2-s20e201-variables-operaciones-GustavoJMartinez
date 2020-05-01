using System;

namespace FacturacionCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de la Facturación");
            Console.WriteLine("");

            Console.Write("Ingrese descripción de producto: ");
            string descripcion = Console.ReadLine();

            Console.Write("Ingrese costo de unidades: ");
            double costo = Convert.ToDouble(Console.ReadLine());


            double utilidad = 1.50 * costo;
            double impuesto = 0.21 * costo;
            double preventa = costo + utilidad + impuesto;

            Console.WriteLine("El producto " + descripcion + " tiene una utilidad de $" + utilidad + ", un impuesto de $" + impuesto + " ,un precio de venta de $" + preventa);

        }
    }
}
