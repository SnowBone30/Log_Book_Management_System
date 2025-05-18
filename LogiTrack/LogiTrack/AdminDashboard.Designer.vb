<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtLogID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpSignOut = New System.Windows.Forms.DateTimePicker()
        Me.txtSignOutName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btmEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpSignIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSLogID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateSignIn = New System.Windows.Forms.Button()
        Me.txtSignInName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLogEntries = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(12, 15)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 35)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtLogID
        '
        Me.txtLogID.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogID.Location = New System.Drawing.Point(113, 39)
        Me.txtLogID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.Size = New System.Drawing.Size(75, 29)
        Me.txtLogID.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "log ID:"
        '
        'dtpSignOut
        '
        Me.dtpSignOut.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSignOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignOut.Location = New System.Drawing.Point(113, 117)
        Me.dtpSignOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSignOut.Name = "dtpSignOut"
        Me.dtpSignOut.Size = New System.Drawing.Size(180, 29)
        Me.dtpSignOut.TabIndex = 10
        '
        'txtSignOutName
        '
        Me.txtSignOutName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignOutName.ForeColor = System.Drawing.Color.White
        Me.txtSignOutName.Location = New System.Drawing.Point(113, 75)
        Me.txtSignOutName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSignOutName.Name = "txtSignOutName"
        Me.txtSignOutName.Size = New System.Drawing.Size(374, 29)
        Me.txtSignOutName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Full Name:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btmEdit)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(28, 631)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1072, 52)
        Me.Panel2.TabIndex = 16
        '
        'btmEdit
        '
        Me.btmEdit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btmEdit.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btmEdit.ForeColor = System.Drawing.Color.White
        Me.btmEdit.Location = New System.Drawing.Point(562, 9)
        Me.btmEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btmEdit.Name = "btmEdit"
        Me.btmEdit.Size = New System.Drawing.Size(156, 35)
        Me.btmEdit.TabIndex = 14
        Me.btmEdit.Text = "Edit"
        Me.btmEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDelete.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(890, 9)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(156, 35)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(726, 9)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(156, 35)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(338, 164)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(156, 35)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.txtLogID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpSignOut)
        Me.GroupBox2.Controls.Add(Me.txtSignOutName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(580, 405)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(520, 209)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sign Out Section"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(104, 56)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(383, 29)
        Me.txtSearch.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "LogiTrack"
        '
        'Panel1
        '
        Me.Panel1.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(374, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 39)
        Me.Panel1.TabIndex = 9
        '
        'dtpSignIn
        '
        Me.dtpSignIn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSignIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSignIn.Location = New System.Drawing.Point(125, 152)
        Me.dtpSignIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSignIn.Name = "dtpSignIn"
        Me.dtpSignIn.Size = New System.Drawing.Size(180, 29)
        Me.dtpSignIn.TabIndex = 10
        '
        'cmbRole
        '
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(125, 114)
        Me.cmbRole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(180, 29)
        Me.cmbRole.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSLogID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnUpdateSignIn)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dtpSignIn)
        Me.GroupBox1.Controls.Add(Me.cmbRole)
        Me.GroupBox1.Controls.Add(Me.txtSignInName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 405)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(522, 209)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign In Section"
        '
        'txtSLogID
        '
        Me.txtSLogID.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLogID.Location = New System.Drawing.Point(125, 42)
        Me.txtSLogID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSLogID.Name = "txtSLogID"
        Me.txtSLogID.Size = New System.Drawing.Size(75, 29)
        Me.txtSLogID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "log ID:"
        '
        'btnUpdateSignIn
        '
        Me.btnUpdateSignIn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdateSignIn.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.btnUpdateSignIn.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSignIn.Location = New System.Drawing.Point(338, 164)
        Me.btnUpdateSignIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateSignIn.Name = "btnUpdateSignIn"
        Me.btnUpdateSignIn.Size = New System.Drawing.Size(156, 35)
        Me.btnUpdateSignIn.TabIndex = 14
        Me.btnUpdateSignIn.Text = "Update"
        Me.btnUpdateSignIn.UseVisualStyleBackColor = False
        '
        'txtSignInName
        '
        Me.txtSignInName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignInName.Location = New System.Drawing.Point(125, 78)
        Me.txtSignInName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSignInName.Name = "txtSignInName"
        Me.txtSignInName.Size = New System.Drawing.Size(374, 29)
        Me.txtSignInName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(68, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Role:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Name:"
        '
        'dgvLogEntries
        '
        Me.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogEntries.Location = New System.Drawing.Point(28, 96)
        Me.dgvLogEntries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLogEntries.Name = "dgvLogEntries"
        Me.dgvLogEntries.RowHeadersWidth = 62
        Me.dgvLogEntries.Size = New System.Drawing.Size(1072, 298)
        Me.dgvLogEntries.TabIndex = 10
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1167, 695)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvLogEntries)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtLogID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpSignOut As DateTimePicker
    Friend WithEvents txtSignOutName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpSignIn As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSignInName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLogEntries As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btmEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdateSignIn As Button
    Friend WithEvents txtSLogID As TextBox
    Friend WithEvents Label5 As Label
End Class
