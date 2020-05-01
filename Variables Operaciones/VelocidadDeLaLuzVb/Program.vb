Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de la Velocidad de la luz")
        Console.WriteLine("")

        Console.Write("Ingrese cantidad de segundos: ")
        Dim segundos As Integer = Convert.ToInt16(Console.ReadLine())

        Dim distancia As Integer = segundos * 300000

        Console.WriteLine("Son " & distancia & " kilómetros por segundo")
    End Sub
End Module
