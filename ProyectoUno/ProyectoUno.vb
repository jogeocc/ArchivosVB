Module ProyectoUno

    Dim a, b, c As Int16
    Dim d As Decimal
    Public Class ProyectoUno
        Sub New()

        End Sub
    End Class


    'Function SumaDatos(uno As Int16, dos As Int16, tres As Int16) As Decimal
    'Dim cuatro As Decimal
    'cuatro = ((uno + dos) / tres)
    'Return (cuatro)
    'End Function

    'Sub MuestraRespuesta(Cinco As Decimal)
    ' Console.WriteLine("La respuesta es {0}", Cinco)
    'Console.ReadLine()
    'End Sub

    Sub Main()

        Dim obj As New ProyectoUno
        Dim aux As New LibreriaVB.Class1

        Console.WriteLine("Dar el dato 1: ")
        a = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine("Dar el dato 2: ")
        b = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine("Dar el dato 3: ")
        c = CType(Console.ReadLine(), Int16)

        'd = aux.SumaDatos(a, b, c)
        aux.MuestraRespuesta(d)


    End Sub

End Module
