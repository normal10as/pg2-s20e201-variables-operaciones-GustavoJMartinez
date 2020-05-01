Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de Equivalencias de Horas")
        Console.WriteLine("")

        Console.Write("Ingrese cantidad de horas: ")
        Dim horas As Integer = Convert.ToInt16(Console.ReadLine())

        Dim min As Integer = horas * 60
        Dim seg As Integer = horas * 3600
        Dim dia As Integer = horas / 24

        Console.WriteLine("Son " & min & " minutos, " & seg & " segundos, " & dia & " dias.")
    End Sub
End Module
