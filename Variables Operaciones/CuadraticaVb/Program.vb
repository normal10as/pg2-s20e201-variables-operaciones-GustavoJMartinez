Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de la X")
        Console.WriteLine("")

        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2

        Dim x As Double = Math.Pow(b, 2) - 4 * a * c
        x = x / 2 * a

        Console.WriteLine("X = " & x)
    End Sub
End Module
