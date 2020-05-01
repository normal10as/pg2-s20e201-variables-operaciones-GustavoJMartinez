using System;

namespace EquivalenciasHorasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Equivalencias de Horas");
            Console.WriteLine("");

            Console.Write("Ingrese cantidad de horas: ");
            int horas = Convert.ToInt16(Console.ReadLine());

            int min = horas * 60;
            int seg = horas * 3600;
            int dia = horas / 24;

            Console.WriteLine("Son " + min + " minutos, " + seg + " segundos, " + dia + " dias." );
        }
    }
}
