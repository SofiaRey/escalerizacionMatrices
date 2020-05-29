Public Class Form1
    Private Sub Button1_Click(sender As Object, j As EventArgs) Handles btnResult.Click
        'Casillas de matriz ingresada
        'Fila 1
        Dim a As Double = txtbxA.Text
        Dim b As Double = txtbxB.Text
        Dim c As Double = txtbxC.Text
        Dim x As Double = txtbxX.Text
        'Fila 2
        Dim d As Double = txtbxD.Text
        Dim e As Double = txtbxE.Text
        Dim f As Double = txtbxF.Text
        Dim y As Double = txtbxY.Text
        'Fila 3
        Dim g As Double = txtbxG.Text
        Dim h As Double = txtbxH.Text
        Dim i As Double = txtbxI.Text
        Dim z As Double = txtbxZ.Text

        'Columna 1
        'Fila1/a (casilla a = 1)
        b = b / a
        c = c / a
        x = x / a
        a = a / a

        'Fila2 - d(Fila1) (casilla d = 0)
        e = e - (d * b)
        f = f - (d * c)
        y = y - (d * x)
        d = d - (d * a)

        'Fila3 - g(Fila1) (casilla g = 0)
        h = h - (g * b)
        i = i - (g * c)
        z = z - (g * x)
        g = g - (g * a)

        'Columna 2
        'Fila2/e (casilla e = 1)
        d = d / e
        f = f / e
        y = y / e
        e = e / e

        'Fila3 - h(Fila2) (casilla h = 0)
        g = g - (h * d)
        i = i - (h * f)
        z = z - (h * y)
        h = h - (h * e)

        'Fila1 - b(Fila2) (casilla b = 0)
        a = a - (b * d)
        c = c - (b * f)
        x = x - (b * y)
        b = b - (b * e)

        'Columna 3
        'Fila3/i (casilla i = 1)
        g = g / i
        h = h / i
        z = z / i
        i = i / i

        'Fila2 - f(Fila3) (casilla f = 0)
        d = d - (f * g)
        e = e - (f * h)
        y = y - (f * z)
        f = f - (f * i)

        'Fila1 - c(Fila3) (casilla c = 0)
        a = a - (c * g)
        b = b - (c * h)
        x = x - (c * z)
        c = c - (c * i)



        'Mostrar resultados
        lblA.Text = a
        lblB.Text = b
        lblC.Text = c
        lblX.Text = x
        lblD.Text = d
        lblE.Text = e
        lblF.Text = f
        lblY.Text = y
        lblG.Text = g
        lblH.Text = h
        lblI.Text = i
        lblZ.Text = z
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbxE.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtbxF.TextChanged

    End Sub

    Private Sub txtbxA_TextChanged(sender As Object, e As EventArgs) Handles txtbxA.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
