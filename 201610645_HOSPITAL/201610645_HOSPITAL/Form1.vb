Public Class Form1
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If fila < 6 Then

            existeesta = True
            buscaresta()

            If Not existeesta Then
                MsgBox("NIT Repetido")
                Exit Sub
            End If

            matriz(fila, 0) = TextBox1.Text
            matriz(fila, 1) = TextBox2.Text
            matriz(fila, 2) = TextBox3.Text


            Dim precio, desc As Double
            precio = 0
            Select Case ComboBox1.SelectedIndex
                Case 0
                    matriz(fila, 3) = "Privada"
                    precio = 350 * Val(matriz(fila, 2))
                Case 1
                    matriz(fila, 3) = "Semi privada"
                    precio = 250 * Val(matriz(fila, 2))
                Case 2
                    matriz(fila, 3) = "No privada"
                    precio = 150 * Val(matriz(fila, 2))
                Case Else
                    MsgBox("No selecciono Habitacion")
                    Exit Sub
            End Select

            matriz(fila, 5) = Str(Val(TextBox4.Text) + precio)

            desc = 0
            Select Case ComboBox2.SelectedIndex
                Case 0
                    matriz(fila, 4) = "Efectivo"
                    desc = Val(matriz(fila, 5)) * 0.1
                Case 1
                    matriz(fila, 4) = "Transferencia"
                    desc = Val(matriz(fila, 5)) * 0.08
                Case 2 : matriz(fila, 4) = "deposito"
                Case 3 : matriz(fila, 4) = "Tarjeta"
                    desc = Val(matriz(fila, 5)) * -0.015
                Case 4 : matriz(fila, 4) = "Seguro"
                Case Else
                    MsgBox("No selecciono Pago")
                    Exit Sub
            End Select

            matriz(fila, 6) = Str(desc)
            matriz(fila, 7) = Str(Val(matriz(fila, 5)) - Val(matriz(fila, 6)))

            fila = fila + 1
            MsgBox("Agregado")
            limpiar_entradas()
            mostrar_matriz()
        Else
            MsgBox("Matriz llena ")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matrices()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        limpiar_data()

        Dim existe As Boolean = True

        Dim I As Byte = 0

        While (I < 6) And (existe)

            If (matriz(I, 1) = (TextBox5.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While

        If Not (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = matriz(I, 0)
            TextBox2.Text = matriz(I, 1)
            TextBox3.Text = matriz(I, 2)

            DataGridView1.Rows.Add(matriz(I, 0), matriz(I, 1), matriz(I, 2), matriz(I, 3), matriz(I, 4), matriz(I, 5), matriz(I, 6), matriz(I, 7))

        Else
            MsgBox("No NIT no encontrado")
            TextBox5.Focus()
        End If
    End Sub

    Dim existeesta As Boolean
    Sub buscaresta()
        Dim I As Byte = 0

        While (I < 6) And (existeesta)

            If (matriz(I, 1) = (TextBox2.Text)) Then
                existeesta = False
            Else
                I = I + 1
            End If
        End While
    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        Dim estadiscica1 As Integer = 0
        Dim estadiscica2 As Integer = 0
        Dim estadiscica3 As Integer = 0

        Dim I As Double = 0
        While (matriz(I, 0) <> Nothing And I < 6)

            If matriz(I, 3) = "Privada" Then
                estadiscica1 = estadiscica1 + 1
            End If

            I = I + 1
        End While

        TextBox6.Text = Str(estadiscica1)


        I = 0
        While (matriz(I, 0) <> Nothing And I < 6)

            If matriz(I, 4) = "Transferencia" Then
                estadiscica2 = estadiscica2 + Val(matriz(I, 7))
            End If

            I = I + 1
        End While
        TextBox7.Text = Str(estadiscica2)


        I = 0
        While (matriz(I, 0) <> Nothing And I < 6)

            If matriz(I, 3) = "No privada" Then
                estadiscica3 = estadiscica3 + Val(matriz(I, 2))
            End If

            I = I + 1
        End While
        TextBox8.Text = Str(estadiscica3)

    End Sub
End Class
