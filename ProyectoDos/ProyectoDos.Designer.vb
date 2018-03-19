<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProyectoDos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblDatoUno = New System.Windows.Forms.Label()
        Me.LblDatoDos = New System.Windows.Forms.Label()
        Me.LblDatoTres = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblKuantas = New System.Windows.Forms.Label()
        Me.TxbCuantos = New System.Windows.Forms.TextBox()
        Me.BtnIf = New System.Windows.Forms.Button()
        Me.LblNVeces = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblDatoUno
        '
        Me.LblDatoUno.AutoSize = True
        Me.LblDatoUno.Location = New System.Drawing.Point(85, 92)
        Me.LblDatoUno.Name = "LblDatoUno"
        Me.LblDatoUno.Size = New System.Drawing.Size(39, 13)
        Me.LblDatoUno.TabIndex = 0
        Me.LblDatoUno.Text = "Dato 1"
        '
        'LblDatoDos
        '
        Me.LblDatoDos.AutoSize = True
        Me.LblDatoDos.Location = New System.Drawing.Point(85, 147)
        Me.LblDatoDos.Name = "LblDatoDos"
        Me.LblDatoDos.Size = New System.Drawing.Size(39, 13)
        Me.LblDatoDos.TabIndex = 1
        Me.LblDatoDos.Text = "Dato 2"
        '
        'LblDatoTres
        '
        Me.LblDatoTres.AutoSize = True
        Me.LblDatoTres.Location = New System.Drawing.Point(85, 200)
        Me.LblDatoTres.Name = "LblDatoTres"
        Me.LblDatoTres.Size = New System.Drawing.Size(39, 13)
        Me.LblDatoTres.TabIndex = 2
        Me.LblDatoTres.Text = "Dato 3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(175, 193)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(498, 62)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblKuantas
        '
        Me.LblKuantas.AutoSize = True
        Me.LblKuantas.Location = New System.Drawing.Point(130, 37)
        Me.LblKuantas.Name = "LblKuantas"
        Me.LblKuantas.Size = New System.Drawing.Size(52, 13)
        Me.LblKuantas.TabIndex = 10
        Me.LblKuantas.Text = "Kuantas?"
        '
        'TxbCuantos
        '
        Me.TxbCuantos.Location = New System.Drawing.Point(205, 29)
        Me.TxbCuantos.Name = "TxbCuantos"
        Me.TxbCuantos.Size = New System.Drawing.Size(100, 20)
        Me.TxbCuantos.TabIndex = 11
        '
        'BtnIf
        '
        Me.BtnIf.Location = New System.Drawing.Point(452, 241)
        Me.BtnIf.Name = "BtnIf"
        Me.BtnIf.Size = New System.Drawing.Size(75, 23)
        Me.BtnIf.TabIndex = 12
        Me.BtnIf.Text = "BtnIf"
        Me.BtnIf.UseVisualStyleBackColor = True
        '
        'LblNVeces
        '
        Me.LblNVeces.AutoSize = True
        Me.LblNVeces.Location = New System.Drawing.Point(546, 246)
        Me.LblNVeces.Name = "LblNVeces"
        Me.LblNVeces.Size = New System.Drawing.Size(0, 13)
        Me.LblNVeces.TabIndex = 13
        '
        'ProyectoDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 297)
        Me.Controls.Add(Me.LblNVeces)
        Me.Controls.Add(Me.BtnIf)
        Me.Controls.Add(Me.TxbCuantos)
        Me.Controls.Add(Me.LblKuantas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblDatoTres)
        Me.Controls.Add(Me.LblDatoDos)
        Me.Controls.Add(Me.LblDatoUno)
        Me.Name = "ProyectoDos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDatoUno As Label
    Friend WithEvents LblDatoDos As Label
    Friend WithEvents LblDatoTres As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblKuantas As Label
    Friend WithEvents TxbCuantos As TextBox
    Friend WithEvents BtnIf As Button
    Friend WithEvents LblNVeces As Label
End Class
