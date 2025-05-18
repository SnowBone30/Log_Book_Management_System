Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class DeafaultDashboard

    Private connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
    Private Sub dtpSignIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpSignIn.ValueChanged
        Dim selectedDateTime As String = dtpSignIn.Value.ToString("yyyy-MM-dd HH:mm:ss")
        MessageBox.Show("Selected Date and Time: " & selectedDateTime)

    End Sub

    Private Sub dtpSignOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpSignOut.ValueChanged
        Dim selectedDateTime As String = dtpSignOut.Value.ToString("yyyy-MM-dd HH:mm:ss")
        MessageBox.Show("Selected Date and Time: " & selectedDateTime)
    End Sub

    Private Sub LoadLogEntries()

        Try
            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "SELECT log_id, name, role, sign_in_time,sign_out_time FROM log_entries"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Fill DataGridView
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvLogEntries.DataSource = dt

                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DeafaultDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogEntries()

        cmbRole.Items.AddRange(New String() {"Visitor", "Staff"})

    End Sub

    Private Sub dgvLogEntries_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogEntries.CellContentClick
        Try
            ' Get the selected row
            Dim rowIndex As Integer = e.RowIndex
            If rowIndex >= 0 Then
                ' Populate the Sign Out Section
                txtLogID.Text = dgvLogEntries.Rows(rowIndex).Cells(0).Value.ToString()
                txtSignOutName.Text = dgvLogEntries.Rows(rowIndex).Cells(1).Value.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Try
            ' Validate all required fields
            If txtSignInName.Text.Trim() = "" OrElse cmbRole.SelectedIndex = -1 OrElse dtpSignIn.Value = Nothing Then
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "INSERT INTO log_entries (name, role, sign_in_time) VALUES (@name, @role, @sign_in_time)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Prepare the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtSignInName.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@sign_in_time", dtpSignIn.Value.ToString("yyyy-MM-dd HH:mm:ss"))

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sign In successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                conn.Close()
            End Using

            ' Refresh the DataGridView
            LoadLogEntries()

            If dgvLogEntries.Rows.Count > 0 Then
                dgvLogEntries.ClearSelection()
                dgvLogEntries.Rows(dgvLogEntries.Rows.Count - 1).Selected = True
                dgvLogEntries.FirstDisplayedScrollingRowIndex = dgvLogEntries.Rows.Count - 1
            End If

            ' Clear input fields
            txtSignInName.Clear()
            cmbRole.SelectedIndex = -1
            dtpSignIn.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Error signing in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtLogID_TextChanged(sender As Object, e As EventArgs) Handles txtLogID.TextChanged
        Try
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim searchQuery As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries WHERE log_id LIKE @search OR name LIKE @search"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & txtLogID.Text & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvLogEntries.DataSource = dt
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Try
            If txtLogID.Text.Trim() = "" Then
                MessageBox.Show("Please select a record to sign out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Connection string for XAMPP MySQL
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim query As String = "UPDATE log_entries SET sign_out_time = @sign_out_time WHERE log_id = @log_id"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Prepare the SQL command
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@log_id", txtLogID.Text.Trim())
                    cmd.Parameters.AddWithValue("@name", txtSignOutName.Text.Trim())
                    cmd.Parameters.AddWithValue("@sign_out_time", dtpSignOut.Value.ToString("yyyy-MM-dd HH:mm:ss"))

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sign Out successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                conn.Close()
            End Using

            ' Refresh the DataGridView
            LoadLogEntries()

            If dgvLogEntries.Rows.Count > 0 Then
                dgvLogEntries.ClearSelection()
                dgvLogEntries.Rows(dgvLogEntries.Rows.Count - 1).Selected = True
                dgvLogEntries.FirstDisplayedScrollingRowIndex = dgvLogEntries.Rows.Count - 1
            End If

            ' Clear input fields
            txtLogID.Clear()
            txtSignOutName.Clear()
            dtpSignOut.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Error signing out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSignOutName_TextChanged(sender As Object, e As EventArgs) Handles txtSignOutName.TextChanged
        Try
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim searchQuery As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries WHERE log_id LIKE @search OR name LIKE @search"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & txtSignOutName.Text & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvLogEntries.DataSource = dt
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"
            Dim searchQuery As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries WHERE log_id LIKE @search OR name LIKE @search"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvLogEntries.DataSource = dt
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim mainmenu As New MainMenu
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class