Public Class Class1


    '''para los arrewglos es necesario el () arreglo vacio como parametro
    '''Declarar la propiedad
    Private Dato As Int16

    Public Property PDato As Int16 '''Propiedad
        Get
            Return Dato
        End Get
        Set(value As Int16)
            Dato = value
        End Set
    End Property



    Function PromDatos(ByRef arreglo() As Int16, ByVal ene As Int16) As Decimal
        Dim cuatro As Decimal
        Dim suma, ciclo As Int16

        For ciclo = 0 To ene * 3
            suma += arreglo(ciclo)
        Next
        cuatro = suma / ene * 3
        Return (cuatro)
    End Function

    Sub MuestraRespuesta(ByVal cinco As Decimal)
        Console.WriteLine("La respuesta es {0}", cinco)
        Console.ReadLine()
    End Sub
End Class
