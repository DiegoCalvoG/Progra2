Module Module1
    Public nolicencia, nombre, nit As String
    Public dias, totalkilometros, preciokml, kmrecorrido, parcial, resultado As Double
    Public errorr As Boolean

    Sub limpiar()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox10.Clear()

        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False

        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.CheckBox4.Checked = False
    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar()
        End If
    End Sub

    Sub verificar()

        If Form1.RadioButton1.Checked = False And Form1.RadioButton2.Checked = False And Form1.RadioButton3.Checked = False And Form1.RadioButton4.Checked = False Then
            MsgBox("No selecciono Tipo de cubrecama")
            errorr = True
            Exit Sub
        End If

        If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = False And Form1.CheckBox3.Checked = False And Form1.CheckBox4.Checked = False Then
            MsgBox("No selecciono Tipo de tela")
            errorr = True
            Exit Sub
        End If
    End Sub
End Module
