Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de Cotizaci�n del D�lar")
        Console.WriteLine("")

        Console.Write("Ingrese la cantidad de d�lares a comprar: ")
        Dim dolar As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el valor de cotizaci�n: ")
        Dim valor As Double = Convert.ToDouble(Console.ReadLine())

        Dim cambio As Double = dolar * valor

        Console.WriteLine("Por la cantidad de U$S" & dolar & " se debe pagar $" & cambio)
    End Sub
End Module
