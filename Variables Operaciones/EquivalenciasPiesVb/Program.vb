Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Calculo de equivalencia en pies")
        Console.WriteLine("")

        Console.Write("Ingrese distancia en pies: ")
        Dim pies As Double = Convert.ToDouble(Console.ReadLine())

        Dim pulgadas As Double = pies * 12
        Dim yardas As Double = pies * 0.33
        Dim metro As Double = pies * 0.305
        Dim centimetros As Double = pies * 30.48

        Console.WriteLine(pies & " pies son " & pulgadas & " pulgadas, " & yardas & " yardas, " & metro & " metros, " & centimetros & " centimetros.")
    End Sub
End Module
