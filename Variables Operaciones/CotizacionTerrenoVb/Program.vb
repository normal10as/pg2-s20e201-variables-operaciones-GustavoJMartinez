Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculo de Cotización de un Terreno")
        Console.WriteLine("")

        Console.Write("Ingrese el ancho en metros: ")
        Dim ancho As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el Largo en metros: ")
        Dim largo As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el costo del metro cuadrado: ")
        Dim costometro As Double = Convert.ToDouble(Console.ReadLine())

        Dim cotizacion As Double = ancho * largo * costometro

        Console.WriteLine("La cotizacion del terreno es de: " & cotizacion)
    End Sub
End Module
