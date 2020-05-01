Imports System

Namespace CostosCs
    Module Program
        Sub Main(args As String())
            Dim factorcostos As Double = 3.5
            Dim costofijo As Integer = 10700
            Dim costo As Double

            Console.Write("Ingrese descripción de producto: ")
            Dim descripcion As String = Console.ReadLine()

            Console.Write("Ingrese número de unidades: ")
            Dim numuni As Integer = Convert.ToInt32(Console.ReadLine())

            costo = numuni * factorcostos + costofijo

            Console.WriteLine("El producto " & descripcion & " tiene un costo de producción de: $" & costo)
        End Sub
    End Module
End Namespace
