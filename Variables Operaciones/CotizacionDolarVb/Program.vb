Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de Cotización del Dólar")
        Console.WriteLine("")

        Console.Write("Ingrese la cantidad de dólares a comprar: ")
        Dim dolar As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el valor de cotización: ")
        Dim valor As Double = Convert.ToDouble(Console.ReadLine())

        Dim cambio As Double = dolar * valor

        Console.WriteLine("Por la cantidad de U$S" & dolar & " se debe pagar $" & cambio)
    End Sub
End Module
