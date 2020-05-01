Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo del Área de un circulo")
        Console.WriteLine("")

        Console.Write("Ingrese el radio del circulo: ")
        Dim radio As Double = Convert.ToDouble(Console.ReadLine())

        Dim area As Double = 3.1415 * Math.Pow(radio, 2)

        Console.WriteLine("El Área del circulo es: " & area)

    End Sub
End Module
