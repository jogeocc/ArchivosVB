Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Text



Public Class ArchivosVB
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtCuantos_TextChanged(sender As Object, e As EventArgs) Handles txtCuantos.TextChanged

    End Sub

    Private Sub txtMatricula_TextChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtCal1_TextChanged(sender As Object, e As EventArgs) Handles txtCal1.TextChanged

    End Sub

    Private Sub txtCal2_TextChanged(sender As Object, e As EventArgs) Handles txtCal2.TextChanged

    End Sub

    Private Sub txtCal3_TextChanged(sender As Object, e As EventArgs) Handles txtCal3.TextChanged

    End Sub

    Private Sub txtCal4_TextChanged(sender As Object, e As EventArgs) Handles txtCal4.TextChanged

    End Sub

    Private Sub txtCred1_TextChanged(sender As Object, e As EventArgs) Handles txtCred1.TextChanged

    End Sub

    Private Sub txtCred2_TextChanged(sender As Object, e As EventArgs) Handles txtCred2.TextChanged

    End Sub

    Private Sub txtCred3_TextChanged(sender As Object, e As EventArgs) Handles txtCred3.TextChanged

    End Sub

    Private Sub txtCred4_TextChanged(sender As Object, e As EventArgs) Handles txtCred4.TextChanged

    End Sub

    Private Sub BtnIrARespuestas_Click(sender As Object, e As EventArgs) Handles BtnIrARespuestas.Click
        LeerArchB()
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        'Grabar
        GenTexto()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

    End Sub

    Private Sub Total1_Click(sender As Object, e As EventArgs) Handles Total1.Click

    End Sub

    Private Sub Total2_Click(sender As Object, e As EventArgs) Handles Total2.Click

    End Sub


    Public Sub GenTexto()

        'GRABAR

        Dim reg As New StreamWriter("C:\VS2015\U_2\Archivos\DatosMios.txt", True)
        reg.WriteLine(txtNombre.Text)
        reg.WriteLine(txtMatricula.Text)
        reg.WriteLine(txtCal1.Text)
        reg.WriteLine(txtCal2.Text)
        reg.WriteLine(txtCal3.Text)
        reg.WriteLine(txtCal4.Text)
        reg.WriteLine(txtCred1.Text)
        reg.WriteLine(txtCred2.Text)
        reg.WriteLine(txtCred3.Text)
        reg.WriteLine(txtCred4.Text)

        reg.Close()
    End Sub

    Public Sub LeerArchB()
        Dim reg As New StreamReader("C:\VS2015\U_2\Archivos\DatosMios.txt")

        Do Until (reg.EndOfStream)
            txtNombre.Text = reg.ReadLine()
            txtMatricula.Text = reg.ReadLine()
            txtCal1.Text = reg.ReadLine()
            txtCal2.Text = reg.ReadLine()
            txtCal3.Text = reg.ReadLine()
            txtCal4.Text = reg.ReadLine()
            txtCred1.Text = reg.ReadLine()
            txtCred2.Text = reg.ReadLine()
            txtCred3.Text = reg.ReadLine()
            txtCred4.Text = reg.ReadLine()

            MessageBox.Show("Pause.....")

        Loop

        reg.Close()

    End Sub


    Public Sub GenBinario()
        Dim regdos As Stream = File.Open("C:\VS2015\U_2\Archivos\DatosBinarios.bin", FileMode.Append, FileAccess.Write)
        Dim dato As New BinaryWriter(regdos)

        dato.Write(txtNombre.Text)
        dato.Write(txtMatricula.Text)
        dato.Write(txtCal1.Text)
        dato.Write(txtCal2.Text)
        dato.Write(txtCal3.Text)
        dato.Write(txtCal4.Text)
        dato.Write(txtCred1.Text)
        dato.Write(txtCred2.Text)
        dato.Write(txtCred3.Text)
        dato.Write(txtCred4.Text)

        dato.Close()
    End Sub

    Private Sub BtnGrabBin_Click(sender As Object, e As EventArgs) Handles BtnGrabBin.Click
        GenBinario()
    End Sub

    Public Sub LeeBinario()
        Dim regdos As Stream = File.Open("C:\VS2015\U_2\Archivos\DatosBinarios.bin", FileMode.Open, FileAccess.Read)
        Dim dato As New BinaryReader(regdos)

        Do Until (dato.PeekChar = -1)
            txtNombre.Text = dato.ReadString()
            txtMatricula.Text = dato.ReadString()
            txtCal1.Text = dato.ReadString()
            txtCal2.Text = dato.ReadString()
            txtCal3.Text = dato.ReadString()
            txtCal4.Text = dato.ReadString()
            txtCred1.Text = dato.ReadString()
            txtCred2.Text = dato.ReadString()
            txtCred3.Text = dato.ReadString()
            txtCred4.Text = dato.ReadString()

            MessageBox.Show("Pause.....")

        Loop

        dato.Close()
    End Sub

    Private Sub btnLeerDatosBin_Click(sender As Object, e As EventArgs) Handles btnLeerDatosBin.Click
        LeeBinario()

    End Sub
End Class
