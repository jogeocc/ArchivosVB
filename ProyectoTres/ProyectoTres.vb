Public Class ProyectoTres
    Dim copia As Decimal
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Dim obj As New ProyectoDos.ProyectoDos
        Me.Hide()
        obj.Show()
    End Sub

    Private Sub BtnDesplegar_Click(sender As Object, e As EventArgs) Handles BtnDesplegar.Click
        TextBox1.Text = CType(copia, String)
    End Sub

    Public Sub RecibeDatos(ByVal valor As Decimal)
        copia = valor
    End Sub
End Class
