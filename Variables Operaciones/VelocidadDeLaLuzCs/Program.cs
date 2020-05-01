using System;

namespace VelocidadDeLaLuzCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de la Velocidad de la luz");
            Console.WriteLine("");

            Console.Write("Ingrese cantidad de segundos: ");
            int segundos = Convert.ToInt16(Console.ReadLine());

            int distancia = segundos * 300000;


            Console.WriteLine("Son " + distancia + " kilómetros por segundo");
        }
    }
}
