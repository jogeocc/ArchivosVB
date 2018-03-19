Public Class ProyectoDos

    'Dim dato1 As Int16
    'Dim dato2 As Int16
    'Dim dato3 As Int16
    Dim resultado As Decimal
    Dim kuantos As Int16
    Dim kontador As Int16

    Dim indice As Int16


    Dim aux As New ClassLibrary1.LibreriaVB2


    Dim vector(10) As Int16

    Private Sub ProyectoDos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        indice = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text <> "") Then
            aux.PDato = Convert.ToInt16(TextBox1.Text)



            ''vector(indice) = Convert.ToInt16(TextBox1.Text)
        End If


        TxbCuantos.Enabled = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If (TextBox2.Text <> "") Then
            aux.PDato = Convert.ToInt16(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If (TextBox3.Text <> "") Then
            aux.PDato = Convert.ToInt16(TextBox3.Text)
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        resultado = aux.PromDatos(vector, kuantos)
        'TextBox4.Text = CType(resultado, String)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim otroobj As New ProyectoTres.ProyectoTres
        Me.Hide()
        otroobj.RecibeDatos(resultado)
        otroobj.Show()
    End Sub

    Private Sub TxbCuantos_TextChanged(sender As Object, e As EventArgs) Handles TxbCuantos.TextChanged
        kuantos = CType(TxbCuantos.Text, Int16)

    End Sub

    Private Sub BtnIf_Click(sender As Object, e As EventArgs) Handles BtnIf.Click
        indice += 3
        kontador += 1
        If (kontador = kuantos) Then
            'Mensaje de final de veces
            LblNVeces.Text = "Ya son N veces..."
        Else
            'Limpiar campos

        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class
