Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        salir()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        errorr = False
        verificar()
        If errorr = True Then
            Exit Sub
        End If

        Dim yardas, precio As Double
        If RadioButton1.Checked Then
            yardas = 3
            precio = 65.5
        ElseIf RadioButton2.Checked Then
            yardas = 5
            precio = 85.99
        ElseIf RadioButton3.Checked Then
            yardas = 6
            precio = 99.99
        ElseIf RadioButton4.Checked Then
            yardas = 7
            precio = 39.99
        End If

        Dim tempo1, tempo2, tempo3, tempo4, tempototal As Double
        Dim yaradatempo1, yaradatempo2, yaradatempo3, yaradatempo4, yaradatempototal As Double

        If CheckBox1.Checked Then
            tempo1 = Val(TextBox7.Text)
            yaradatempo1 = 15 * tempo1
        End If

        If CheckBox2.Checked Then
            tempo2 = Val(TextBox8.Text)
            yaradatempo2 = 23.99 * tempo2
        End If

        If CheckBox3.Checked Then
            tempo3 = Val(TextBox9.Text)
            yaradatempo3 = 30.99 * tempo3
        End If

        If CheckBox4.Checked Then
            tempo4 = Val(TextBox10.Text)
            yaradatempo4 = 39.99 * tempo4
        End If

        tempototal = tempo1 + tempo2 + tempo3 + tempo4
        yaradatempototal = yaradatempo1 + yaradatempo2 + yaradatempo3 + yaradatempo4

        If yardas <> tempototal Then
            MsgBox("la cantidad de Yardas no es igual a la requerida para el tamaño de cubre camas, yardas necesarias:  " & yardas)
            Exit Sub
        End If

        Dim preciocosto, precioventa, tempoprecio As Double
        preciocosto = precio + yaradatempototal

        tempoprecio = preciocosto * 0.65

        precioventa = preciocosto + tempoprecio


        TextBox1.Text = preciocosto
        TextBox2.Text = precioventa
        TextBox3.Text = yaradatempo1
        TextBox4.Text = yaradatempo2
        TextBox5.Text = yaradatempo3
        TextBox6.Text = yaradatempo4

    End Sub
End Class
