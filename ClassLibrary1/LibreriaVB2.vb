Public Class LibreriaVB2
    Inherits .
    '''HERENCIA


    Private Dato2 As Int16

    Public Property PDato2 As Int16 '''Propiedad
        Get
            Return Dato2
        End Get
        Set(value As Int16)
            Dato2 = value
        End Set
    End Property


    Function PromDatos2(ByRef arreglo() As Int16, ByVal ene As Int16) As Decimal
        Dim cuatro As Decimal
        Dim suma, ciclo As Int16

        For ciclo = 0 To ene * 3
            suma += arreglo(ciclo)
        Next
        cuatro = suma / ene * 3 + PDato


        Return (cuatro)
    End Function


End Class
