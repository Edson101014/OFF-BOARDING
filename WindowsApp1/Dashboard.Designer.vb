<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelTotalDash = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBoxByDepartment = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxByPurpose = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearchDash = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.viewBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckHistoryByRejected = New System.Windows.Forms.CheckBox()
        Me.CheckHistoryByApprove = New System.Windows.Forms.CheckBox()
        Me.LabelTotalHistory = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckHistoryByDepartment = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckHistoryByPurpose = New System.Windows.Forms.CheckBox()
        Me.CheckHistoryByName = New System.Windows.Forms.CheckBox()
        Me.CheckHistoryByID = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearchHistory = New System.Windows.Forms.TextBox()
        Me.DataGridHistory = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LabelTotalComplete = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridViewComplete = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LabelTotalHR = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.CheckHRByDepartment = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckHRByEmail = New System.Windows.Forms.CheckBox()
        Me.CheckHRByName = New System.Windows.Forms.CheckBox()
        Me.CheckHRByUser = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSearchHR = New System.Windows.Forms.TextBox()
        Me.DataGridHR = New System.Windows.Forms.DataGridView()
        Me.ButtonLogOut = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridHR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(10, 41)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1043, 455)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelTotalDash)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.CheckBoxByDepartment)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CheckBoxByPurpose)
        Me.TabPage1.Controls.Add(Me.CheckBoxByName)
        Me.TabPage1.Controls.Add(Me.CheckBoxByID)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBoxSearchDash)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1035, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dashboard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelTotalDash
        '
        Me.LabelTotalDash.AutoSize = True
        Me.LabelTotalDash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalDash.Location = New System.Drawing.Point(913, 399)
        Me.LabelTotalDash.Name = "LabelTotalDash"
        Me.LabelTotalDash.Size = New System.Drawing.Size(110, 20)
        Me.LabelTotalDash.TabIndex = 19
        Me.LabelTotalDash.Text = "LABELTOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(762, 399)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "TOTAL REQUEST:"
        '
        'CheckBoxByDepartment
        '
        Me.CheckBoxByDepartment.AutoSize = True
        Me.CheckBoxByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByDepartment.Location = New System.Drawing.Point(902, 24)
        Me.CheckBoxByDepartment.Name = "CheckBoxByDepartment"
        Me.CheckBoxByDepartment.Size = New System.Drawing.Size(64, 20)
        Me.CheckBoxByDepartment.TabIndex = 7
        Me.CheckBoxByDepartment.Text = "Group"
        Me.CheckBoxByDepartment.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sort  By:"
        '
        'CheckBoxByPurpose
        '
        Me.CheckBoxByPurpose.AutoSize = True
        Me.CheckBoxByPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByPurpose.Location = New System.Drawing.Point(734, 23)
        Me.CheckBoxByPurpose.Name = "CheckBoxByPurpose"
        Me.CheckBoxByPurpose.Size = New System.Drawing.Size(143, 20)
        Me.CheckBoxByPurpose.TabIndex = 5
        Me.CheckBoxByPurpose.Text = "Clearance Purpose"
        Me.CheckBoxByPurpose.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByName.Location = New System.Drawing.Point(645, 23)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(64, 20)
        Me.CheckBoxByName.TabIndex = 4
        Me.CheckBoxByName.Text = "Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Checked = True
        Me.CheckBoxByID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxByID.Location = New System.Drawing.Point(570, 22)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(40, 20)
        Me.CheckBoxByID.TabIndex = 3
        Me.CheckBoxByID.Text = "ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH:"
        '
        'TextBoxSearchDash
        '
        Me.TextBoxSearchDash.Location = New System.Drawing.Point(79, 23)
        Me.TextBoxSearchDash.Name = "TextBoxSearchDash"
        Me.TextBoxSearchDash.Size = New System.Drawing.Size(395, 20)
        Me.TextBoxSearchDash.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.viewBtn})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1017, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'viewBtn
        '
        Me.viewBtn.HeaderText = "View"
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.ReadOnly = True
        Me.viewBtn.Text = "view"
        Me.viewBtn.UseColumnTextForButtonValue = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CheckHistoryByRejected)
        Me.TabPage2.Controls.Add(Me.CheckHistoryByApprove)
        Me.TabPage2.Controls.Add(Me.LabelTotalHistory)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.CheckHistoryByDepartment)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.CheckHistoryByPurpose)
        Me.TabPage2.Controls.Add(Me.CheckHistoryByName)
        Me.TabPage2.Controls.Add(Me.CheckHistoryByID)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBoxSearchHistory)
        Me.TabPage2.Controls.Add(Me.DataGridHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1035, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckHistoryByRejected
        '
        Me.CheckHistoryByRejected.AutoSize = True
        Me.CheckHistoryByRejected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByRejected.Location = New System.Drawing.Point(835, 13)
        Me.CheckHistoryByRejected.Name = "CheckHistoryByRejected"
        Me.CheckHistoryByRejected.Size = New System.Drawing.Size(82, 20)
        Me.CheckHistoryByRejected.TabIndex = 23
        Me.CheckHistoryByRejected.Text = "Rejected"
        Me.CheckHistoryByRejected.UseVisualStyleBackColor = True
        '
        'CheckHistoryByApprove
        '
        Me.CheckHistoryByApprove.AutoSize = True
        Me.CheckHistoryByApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByApprove.Location = New System.Drawing.Point(741, 12)
        Me.CheckHistoryByApprove.Name = "CheckHistoryByApprove"
        Me.CheckHistoryByApprove.Size = New System.Drawing.Size(79, 20)
        Me.CheckHistoryByApprove.TabIndex = 22
        Me.CheckHistoryByApprove.Text = "Approve"
        Me.CheckHistoryByApprove.UseVisualStyleBackColor = True
        '
        'LabelTotalHistory
        '
        Me.LabelTotalHistory.AutoSize = True
        Me.LabelTotalHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalHistory.Location = New System.Drawing.Point(923, 398)
        Me.LabelTotalHistory.Name = "LabelTotalHistory"
        Me.LabelTotalHistory.Size = New System.Drawing.Size(110, 20)
        Me.LabelTotalHistory.TabIndex = 21
        Me.LabelTotalHistory.Text = "LABELTOTAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(772, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "TOTAL REQUEST:"
        '
        'CheckHistoryByDepartment
        '
        Me.CheckHistoryByDepartment.AutoSize = True
        Me.CheckHistoryByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByDepartment.Location = New System.Drawing.Point(671, 13)
        Me.CheckHistoryByDepartment.Name = "CheckHistoryByDepartment"
        Me.CheckHistoryByDepartment.Size = New System.Drawing.Size(64, 20)
        Me.CheckHistoryByDepartment.TabIndex = 12
        Me.CheckHistoryByDepartment.Text = "Group"
        Me.CheckHistoryByDepartment.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sort  By:"
        '
        'CheckHistoryByPurpose
        '
        Me.CheckHistoryByPurpose.AutoSize = True
        Me.CheckHistoryByPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByPurpose.Location = New System.Drawing.Point(564, 5)
        Me.CheckHistoryByPurpose.Name = "CheckHistoryByPurpose"
        Me.CheckHistoryByPurpose.Size = New System.Drawing.Size(92, 36)
        Me.CheckHistoryByPurpose.TabIndex = 10
        Me.CheckHistoryByPurpose.Text = "Clearance " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purpose"
        Me.CheckHistoryByPurpose.UseVisualStyleBackColor = True
        '
        'CheckHistoryByName
        '
        Me.CheckHistoryByName.AutoSize = True
        Me.CheckHistoryByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByName.Location = New System.Drawing.Point(494, 12)
        Me.CheckHistoryByName.Name = "CheckHistoryByName"
        Me.CheckHistoryByName.Size = New System.Drawing.Size(64, 20)
        Me.CheckHistoryByName.TabIndex = 9
        Me.CheckHistoryByName.Text = "Name"
        Me.CheckHistoryByName.UseVisualStyleBackColor = True
        '
        'CheckHistoryByID
        '
        Me.CheckHistoryByID.AutoSize = True
        Me.CheckHistoryByID.Checked = True
        Me.CheckHistoryByID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckHistoryByID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHistoryByID.Location = New System.Drawing.Point(429, 13)
        Me.CheckHistoryByID.Name = "CheckHistoryByID"
        Me.CheckHistoryByID.Size = New System.Drawing.Size(40, 20)
        Me.CheckHistoryByID.TabIndex = 8
        Me.CheckHistoryByID.Text = "ID"
        Me.CheckHistoryByID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SEARCH:"
        '
        'TextBoxSearchHistory
        '
        Me.TextBoxSearchHistory.Location = New System.Drawing.Point(80, 13)
        Me.TextBoxSearchHistory.Name = "TextBoxSearchHistory"
        Me.TextBoxSearchHistory.Size = New System.Drawing.Size(262, 20)
        Me.TextBoxSearchHistory.TabIndex = 3
        '
        'DataGridHistory
        '
        Me.DataGridHistory.AllowUserToAddRows = False
        Me.DataGridHistory.AllowUserToDeleteRows = False
        Me.DataGridHistory.AllowUserToResizeColumns = False
        Me.DataGridHistory.AllowUserToResizeRows = False
        Me.DataGridHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn2})
        Me.DataGridHistory.Location = New System.Drawing.Point(11, 49)
        Me.DataGridHistory.Name = "DataGridHistory"
        Me.DataGridHistory.ReadOnly = True
        Me.DataGridHistory.RowHeadersVisible = False
        Me.DataGridHistory.Size = New System.Drawing.Size(1012, 346)
        Me.DataGridHistory.TabIndex = 1
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.HeaderText = "View"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.ReadOnly = True
        Me.DataGridViewButtonColumn2.Text = "OPEN"
        Me.DataGridViewButtonColumn2.UseColumnTextForButtonValue = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LabelTotalComplete)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.DataGridViewComplete)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1035, 429)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "Complete History Request "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LabelTotalComplete
        '
        Me.LabelTotalComplete.AutoSize = True
        Me.LabelTotalComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalComplete.Location = New System.Drawing.Point(919, 396)
        Me.LabelTotalComplete.Name = "LabelTotalComplete"
        Me.LabelTotalComplete.Size = New System.Drawing.Size(110, 20)
        Me.LabelTotalComplete.TabIndex = 23
        Me.LabelTotalComplete.Text = "LABELTOTAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(768, 396)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "TOTAL REQUEST:"
        '
        'DataGridViewComplete
        '
        Me.DataGridViewComplete.AllowUserToAddRows = False
        Me.DataGridViewComplete.AllowUserToDeleteRows = False
        Me.DataGridViewComplete.AllowUserToResizeColumns = False
        Me.DataGridViewComplete.AllowUserToResizeRows = False
        Me.DataGridViewComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewComplete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn1})
        Me.DataGridViewComplete.Location = New System.Drawing.Point(6, 47)
        Me.DataGridViewComplete.Name = "DataGridViewComplete"
        Me.DataGridViewComplete.ReadOnly = True
        Me.DataGridViewComplete.RowHeadersVisible = False
        Me.DataGridViewComplete.Size = New System.Drawing.Size(1023, 334)
        Me.DataGridViewComplete.TabIndex = 1
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "View"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "view"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LabelTotalHR)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.ButtonDelete)
        Me.TabPage4.Controls.Add(Me.ButtonEdit)
        Me.TabPage4.Controls.Add(Me.ButtonAdd)
        Me.TabPage4.Controls.Add(Me.CheckHRByDepartment)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.CheckHRByEmail)
        Me.TabPage4.Controls.Add(Me.CheckHRByName)
        Me.TabPage4.Controls.Add(Me.CheckHRByUser)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.TextBoxSearchHR)
        Me.TabPage4.Controls.Add(Me.DataGridHR)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1035, 429)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "USER Maintenance"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LabelTotalHR
        '
        Me.LabelTotalHR.AutoSize = True
        Me.LabelTotalHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalHR.Location = New System.Drawing.Point(915, 388)
        Me.LabelTotalHR.Name = "LabelTotalHR"
        Me.LabelTotalHR.Size = New System.Drawing.Size(110, 20)
        Me.LabelTotalHR.TabIndex = 21
        Me.LabelTotalHR.Text = "LABELTOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(764, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "TOTAL REQUEST:"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Location = New System.Drawing.Point(380, 389)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Enabled = False
        Me.ButtonEdit.Location = New System.Drawing.Point(279, 389)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 14
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(183, 389)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'CheckHRByDepartment
        '
        Me.CheckHRByDepartment.AutoSize = True
        Me.CheckHRByDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHRByDepartment.Location = New System.Drawing.Point(899, 18)
        Me.CheckHRByDepartment.Name = "CheckHRByDepartment"
        Me.CheckHRByDepartment.Size = New System.Drawing.Size(64, 20)
        Me.CheckHRByDepartment.TabIndex = 12
        Me.CheckHRByDepartment.Text = "Group"
        Me.CheckHRByDepartment.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sort  By:"
        '
        'CheckHRByEmail
        '
        Me.CheckHRByEmail.AutoSize = True
        Me.CheckHRByEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHRByEmail.Location = New System.Drawing.Point(801, 18)
        Me.CheckHRByEmail.Name = "CheckHRByEmail"
        Me.CheckHRByEmail.Size = New System.Drawing.Size(61, 20)
        Me.CheckHRByEmail.TabIndex = 10
        Me.CheckHRByEmail.Text = "Email"
        Me.CheckHRByEmail.UseVisualStyleBackColor = True
        '
        'CheckHRByName
        '
        Me.CheckHRByName.AutoSize = True
        Me.CheckHRByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHRByName.Location = New System.Drawing.Point(694, 16)
        Me.CheckHRByName.Name = "CheckHRByName"
        Me.CheckHRByName.Size = New System.Drawing.Size(64, 20)
        Me.CheckHRByName.TabIndex = 9
        Me.CheckHRByName.Text = "Name"
        Me.CheckHRByName.UseVisualStyleBackColor = True
        '
        'CheckHRByUser
        '
        Me.CheckHRByUser.AutoSize = True
        Me.CheckHRByUser.Checked = True
        Me.CheckHRByUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckHRByUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckHRByUser.Location = New System.Drawing.Point(567, 16)
        Me.CheckHRByUser.Name = "CheckHRByUser"
        Me.CheckHRByUser.Size = New System.Drawing.Size(90, 20)
        Me.CheckHRByUser.TabIndex = 8
        Me.CheckHRByUser.Text = "Username"
        Me.CheckHRByUser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SEARCH:"
        '
        'TextBoxSearchHR
        '
        Me.TextBoxSearchHR.Location = New System.Drawing.Point(81, 17)
        Me.TextBoxSearchHR.Name = "TextBoxSearchHR"
        Me.TextBoxSearchHR.Size = New System.Drawing.Size(395, 20)
        Me.TextBoxSearchHR.TabIndex = 3
        '
        'DataGridHR
        '
        Me.DataGridHR.AllowUserToAddRows = False
        Me.DataGridHR.AllowUserToDeleteRows = False
        Me.DataGridHR.AllowUserToResizeColumns = False
        Me.DataGridHR.AllowUserToResizeRows = False
        Me.DataGridHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHR.Location = New System.Drawing.Point(3, 59)
        Me.DataGridHR.Name = "DataGridHR"
        Me.DataGridHR.ReadOnly = True
        Me.DataGridHR.RowHeadersVisible = False
        Me.DataGridHR.Size = New System.Drawing.Size(1022, 324)
        Me.DataGridHR.TabIndex = 1
        '
        'ButtonLogOut
        '
        Me.ButtonLogOut.BackColor = System.Drawing.Color.SpringGreen
        Me.ButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLogOut.Location = New System.Drawing.Point(947, 2)
        Me.ButtonLogOut.Name = "ButtonLogOut"
        Me.ButtonLogOut.Size = New System.Drawing.Size(90, 35)
        Me.ButtonLogOut.TabIndex = 178
        Me.ButtonLogOut.Text = "LOGOUT"
        Me.ButtonLogOut.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 506)
        Me.Controls.Add(Me.ButtonLogOut)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewComplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridHR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents viewBtn As DataGridViewButtonColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearchDash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearchHistory As TextBox
    Friend WithEvents DataGridHistory As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSearchHR As TextBox
    Friend WithEvents DataGridHR As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxByPurpose As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByDepartment As CheckBox
    Friend WithEvents CheckHistoryByDepartment As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckHistoryByPurpose As CheckBox
    Friend WithEvents CheckHistoryByName As CheckBox
    Friend WithEvents CheckHistoryByID As CheckBox
    Friend WithEvents CheckHRByDepartment As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckHRByEmail As CheckBox
    Friend WithEvents CheckHRByName As CheckBox
    Friend WithEvents LabelTotalDash As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelTotalHistory As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelTotalHR As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents CheckHRByUser As CheckBox
    Friend WithEvents CheckHistoryByRejected As CheckBox
    Friend WithEvents CheckHistoryByApprove As CheckBox
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridViewComplete As DataGridView
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents LabelTotalComplete As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonLogOut As Button
End Class
