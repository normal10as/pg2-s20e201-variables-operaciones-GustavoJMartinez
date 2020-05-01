using System;

namespace CotizacionDolarCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Cotización del Dólar");
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad de dólares a comprar: ");
            double dolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de cotización: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double cambio = dolar * valor;

            Console.WriteLine("Por la cantidad de U$S" + dolar + " se debe pagar $" + cambio);

        }
    }
}
