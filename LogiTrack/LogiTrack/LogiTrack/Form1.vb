Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = Module1.username) And (txtPassword.Text = Module1.password) Then
            Dim adminDashboard As New AdminDashboard
            adminDashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If


    End Sub
End Class

