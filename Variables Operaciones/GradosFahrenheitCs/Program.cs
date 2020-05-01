using System;

namespace GradosFahrenheitCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conventir a Fahrenheit");
            Console.WriteLine("");

            Console.Write("Ingrese temperatura en Celsius: ");
            double temcelsius = Convert.ToDouble(Console.ReadLine());

            double temfahren = 9 / 5 * temcelsius + 32;



            Console.WriteLine("La temperatura en fahrenheit es: " + temfahren);
        }
    }
}
