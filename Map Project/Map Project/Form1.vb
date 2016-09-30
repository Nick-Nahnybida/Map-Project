Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblDirections.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplayDirections_Click(sender As Object, e As EventArgs) Handles btnDisplayDirections.Click
        lblDirections.Visible = True

    End Sub
End Class
