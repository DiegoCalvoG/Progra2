Module Module1
    Public matriz(6, 8) As String
    Public fila As Byte = 0

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
        limpiar_data()
    End Sub

    Sub limpiar_data()
        'limpiar datagrid
        Form1.DataGridView1.Rows.Clear()
    End Sub


    Sub limpiar_matrices()
        Dim I As Integer
        Dim J As Integer

        limpiar_data()

        For J = 0 To 5
            For I = 0 To 7

                If (matriz(J, I) <> Nothing) Then
                    matriz(J, I) = Nothing
                End If

            Next I
        Next J
        fila = 0
    End Sub

    Sub mostrar_matriz()
        limpiar_data()
        Dim p As Integer

        For p = 0 To 5

            If (matriz(p, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(matriz(p, 0), matriz(p, 1), matriz(p, 2), matriz(p, 3), matriz(p, 4), matriz(p, 5), matriz(p, 6), matriz(p, 7))
            End If

        Next p

    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        End If
    End Sub

End Module
