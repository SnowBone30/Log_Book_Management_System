<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeafaultDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvLogEntries = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSignInName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.dtpSignIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLogID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.dtpSignOut = New System.Windows.Forms.DateTimePicker()
        Me.txtSignOutName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLogEntries
        '
        Me.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogEntries.Location = New System.Drawing.Point(18, 100)
        Me.dgvLogEntries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLogEntries.Name = "dgvLogEntries"
        Me.dgvLogEntries.RowHeadersWidth = 62
        Me.dgvLogEntries.Size = New System.Drawing.Size(1072, 298)
        Me.dgvLogEntries.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Name:"
        '
        'txtSignInName
        '
        Me.txtSignInName.Location = New System.Drawing.Point(120, 29)
        Me.txtSignInName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSignInName.Name = "txtSignInName"
        Me.txtSignInName.Size = New System.Drawing.Size(374, 26)
        Me.txtSignInName.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnSignIn)
        Me.GroupBox1.Controls.Add(Me.dtpSignIn)
        Me.GroupBox1.Controls.Add(Me.cmbRole)
        Me.GroupBox1.Controls.Add(Me.txtSignInName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 409)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(522, 209)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign In Section"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(374, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 39)
        Me.Panel1.TabIndex = 9
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(357, 164)
        Me.btnSignIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(137, 35)
        Me.btnSignIn.TabIndex = 8
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'dtpSignIn
        '
        Me.dtpSignIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignIn.Location = New System.Drawing.Point(120, 118)
        Me.dtpSignIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSignIn.Name = "dtpSignIn"
        Me.dtpSignIn.Size = New System.Drawing.Size(180, 26)
        Me.dtpSignIn.TabIndex = 10
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(120, 77)
        Me.cmbRole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(180, 28)
        Me.cmbRole.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Role:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LogiTrack"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(94, 60)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(290, 26)
        Me.txtSearch.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLogID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnSignOut)
        Me.GroupBox2.Controls.Add(Me.dtpSignOut)
        Me.GroupBox2.Controls.Add(Me.txtSignOutName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(570, 409)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(520, 209)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sign Out Section"
        '
        'txtLogID
        '
        Me.txtLogID.Location = New System.Drawing.Point(120, 40)
        Me.txtLogID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.Size = New System.Drawing.Size(75, 26)
        Me.txtLogID.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "log ID:"
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(357, 164)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(137, 35)
        Me.btnSignOut.TabIndex = 8
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'dtpSignOut
        '
        Me.dtpSignOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignOut.Location = New System.Drawing.Point(120, 118)
        Me.dtpSignOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSignOut.Name = "dtpSignOut"
        Me.dtpSignOut.Size = New System.Drawing.Size(180, 26)
        Me.dtpSignOut.TabIndex = 10
        '
        'txtSignOutName
        '
        Me.txtSignOutName.Location = New System.Drawing.Point(120, 76)
        Me.txtSignOutName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSignOutName.Name = "txtSignOutName"
        Me.txtSignOutName.Size = New System.Drawing.Size(374, 26)
        Me.txtSignOutName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Full Name:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Location = New System.Drawing.Point(18, 635)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1072, 52)
        Me.Panel2.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 7)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 35)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DeafaultDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 699)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvLogEntries)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DeafaultDashboard"
        Me.Text = "DeafaultDashboard"
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLogEntries As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSignInName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpSignIn As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLogID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents dtpSignOut As DateTimePicker
    Friend WithEvents txtSignOutName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
End Class
