Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()

    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        lblMensaje.Text = "Hola Mani"
    End Sub

    Private Sub btnCambiar2_Click(sender As Object, e As EventArgs) Handles btnCambiar2.Click
        lblMensaje2.Text = "Hola Tío, ya no vayas :v x2"
    End Sub
End Class
