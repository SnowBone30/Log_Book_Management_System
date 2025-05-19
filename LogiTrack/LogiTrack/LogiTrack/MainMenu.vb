Public Class MainMenu
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim dashboard As New DeafaultDashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogAdmin_Click(sender As Object, e As EventArgs) Handles btnlogAdmin.Click
        Dim defaultAdmin As New Form1
        defaultAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class