Imports MySql.Data.MySqlClient

Public Class ReportForm

    Private connectionString As String = "Server=localhost;Database=logbookdb;Uid=root;Pwd=;"

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all log entries on form load
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            Dim query As String = "SELECT log_id, name, role, sign_in_time, sign_out_time FROM log_entries " &
                                  "WHERE sign_in_time BETWEEN @start_date AND @end_date " &
                                  "AND (name LIKE @search OR role LIKE @search)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@start_date", dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00"))
                    cmd.Parameters.AddWithValue("@end_date", dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59"))
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvReports.DataSource = dt
                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLoadReport_Click(sender As Object, e As EventArgs) Handles btnLoadReport.Click
        LoadReport()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadReport()
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        LoadReport()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        LoadReport()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim exitForm As New AdminDashboard
        exitForm.Show()
        Me.Hide()
    End Sub


End Class