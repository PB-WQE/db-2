Public Class frmTeam
    Private Sub btnHideMe_Click(sender As Object, e As EventArgs) Handles btnHideMe.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub frmTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub
End Class