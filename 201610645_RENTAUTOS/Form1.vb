Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_listas()
        limpiar_vectores()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_vectores()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (fila <= 4) Then


            nit(fila) = TextBox1.Text
            placa(fila) = TextBox2.Text
            cantidad(fila) = TextBox3.Text
            efectivo(fila) = TextBox5.Text
            tarjeta(fila) = TextBox6.Text

            Dim rec1, rec2, rec3 As Double

            If CheckBox1.Checked Then
                rec1 = Val(TextBox5.Text)
            End If

            If CheckBox2.Checked Then
                rec2 = Val(TextBox6.Text)
            End If

            If (rec1 + rec2 <> 100) Then
                MsgBox("El porcentaje de pago debe que 100%")
                Exit Sub
            End If

            marca(fila) = ""
            If ComboBox1.SelectedIndex = 0 Then
                rec3 = 250
                marca(fila) = "Honda"
            ElseIf ComboBox1.SelectedIndex = 1 Then
                rec3 = 450
                marca(fila) = "Mercedez Benz"
            ElseIf ComboBox1.SelectedIndex = 2 Then
                rec3 = 325
                marca(fila) = "Toyota"
            ElseIf ComboBox1.SelectedIndex = 3 Then
                rec3 = 300
                marca(fila) = "Mazda"
            End If

            parcial(fila) = Str(rec3 * Val(cantidad(fila)))

            descuentos(fila) = "0"
            If Val(efectivo(fila)) = 100 Then
                descuentos(fila) = Str(Round(Val(parcial(fila)) * 0.05, 2))
            ElseIf Val(tarjeta(fila)) = 100 Then
                descuentos(fila) = Str(Round(-1 * (Val(parcial(fila)) * 0.025), 2))
            End If

            total(fila) = Str(Round(Val(parcial(fila)) - Val(descuentos(fila)), 2))

            mostrar_vectores()
            limpiar_entradas()
            MsgBox("Agregado")
            fila = fila + 1
        Else
            MsgBox("vectores llenos")
        End If
    End Sub
End Class
