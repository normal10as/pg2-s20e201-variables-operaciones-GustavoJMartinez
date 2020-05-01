Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Conventir a Fahrenheit")
        Console.WriteLine("")

        Console.Write("Ingrese temperatura en Celsius: ")
        Dim temcelsius As Double = Convert.ToDouble(Console.ReadLine())

        Dim temfahren As Double = 9 / 5 * temcelsius + 32


        Console.WriteLine("La temperatura en fahrenheit es: " & temfahren)
    End Sub
End Module
