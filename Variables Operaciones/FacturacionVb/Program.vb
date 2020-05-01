Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de la Facturación")
        Console.WriteLine("")

        Console.Write("Ingrese descripción de producto: ")
        Dim descripcion As String = Console.ReadLine()

        Console.Write("Ingrese costo de unidades: ")
        Dim costo As Double = Convert.ToDouble(Console.ReadLine())

        Dim utilidad As Double = 1.5 * costo
        Dim impuesto As Double = 0.21 * costo
        Dim preventa As Double = costo + utilidad + impuesto

        Console.WriteLine("El producto " & descripcion & " tiene una utilidad de $" & utilidad & ", un impuesto de $" & impuesto & " ,un precio de venta de $" & preventa)
    End Sub
End Module
