Module Module1
    Public nit(6) As String
    Public placa(6) As String
    Public marca(6) As String
    Public cantidad(6) As String
    Public efectivo(6) As String
    Public tarjeta(6) As String
    Public parcial(6) As String
    Public descuentos(6) As String
    Public total(6) As String
    Public fila As Byte

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.TextBox1.Focus()
    End Sub

    Sub limpiar_listas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub

    Sub limpiar_vectores()
        Dim J As Integer
        limpiar_listas()

        For J = 0 To 5
            If (nit(J) <> Nothing) Then
                nit(J) = Nothing
                placa(J) = Nothing
                marca(J) = Nothing
                cantidad(J) = Nothing
                efectivo(J) = Nothing
                tarjeta(J) = Nothing
                parcial(J) = Nothing
                descuentos(J) = Nothing
                total(J) = Nothing
            End If
        Next J

        fila = 0
    End Sub

    Sub mostrar_vectores()
        limpiar_listas()
        Dim p As Integer

        For p = 0 To 5

            If (nit(p) <> Nothing) Then
                Form1.ListBox1.Items.Add(nit(p))
                Form1.ListBox2.Items.Add(placa(p))
                Form1.ListBox3.Items.Add(marca(p))
                Form1.ListBox4.Items.Add(cantidad(p))
                Form1.ListBox5.Items.Add(efectivo(p))
                Form1.ListBox6.Items.Add(tarjeta(p))
                Form1.ListBox7.Items.Add(parcial(p))
                Form1.ListBox8.Items.Add(descuentos(p))
                Form1.ListBox9.Items.Add(total(p))
            Else
                Exit For
            End If
        Next p
    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub

End Module
