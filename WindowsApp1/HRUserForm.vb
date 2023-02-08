'Imports MySql.Data.MySqlClient
'Public Class HRUserForm
'    Dim dbs As New db
'    Dim apdb As New ApprovalDB
'    Dim query As New MySqlCommand()
'    Private Sub HRUserForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
'        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy` FROM `request`"
'        fillGridDashboard(query)
'        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `IMSuperStatus`, `IMSuperDateApprove` FROM `historyrequest`"
'        fillGridHistory(query)
'        query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login`"
'        fillGridHR(query)
'    End Sub

'    Sub fillGridDashboard(ByVal command As MySqlCommand)
'        Dashboard.DataGridView1.ReadOnly = True
'        Dashboard.DataGridView1.DataSource = apdb.getemployee(command)
'        Dashboard.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'        Dashboard.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None


'        Dashboard.DataGridView1.Columns(1).HeaderText = "Employee Name"
'        Dashboard.DataGridView1.Columns(2).HeaderText = "Employee ID"
'        Dashboard.DataGridView1.Columns(3).HeaderText = "Department"
'        Dashboard.DataGridView1.Columns(4).HeaderText = "Employee Position"
'        Dashboard.DataGridView1.Columns(5).HeaderText = "Clearance Purpose"
'        Dashboard.DataGridView1.Columns(6).HeaderText = "Employee Status"
'        Dashboard.DataGridView1.Columns(7).HeaderText = "Seperation Date"
'    End Sub
'    Sub fillGridHistory(ByVal command As MySqlCommand)
'        Dashboard.DataGridHistory.ReadOnly = True
'        Dashboard.DataGridHistory.DataSource = apdb.getemployee(command)
'        Dashboard.DataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'        Dashboard.DataGridHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None


'        Dashboard.DataGridHistory.Columns(1).HeaderText = "Employee Name"
'        Dashboard.DataGridHistory.Columns(2).HeaderText = "Employee ID"
'        Dashboard.DataGridHistory.Columns(3).HeaderText = "Department"
'        Dashboard.DataGridHistory.Columns(4).HeaderText = "Employee Position"
'        Dashboard.DataGridHistory.Columns(5).HeaderText = "Clearance Purpose"
'        Dashboard.DataGridHistory.Columns(6).HeaderText = "Employee Status"
'        Dashboard.DataGridHistory.Columns(7).HeaderText = "Seperation Date"
'        Dashboard.DataGridHistory.Columns(8).HeaderText = "Status"
'        Dashboard.DataGridHistory.Columns(9).HeaderText = "Approve Date"

'    End Sub
'    Sub fillGridHR(ByVal command As MySqlCommand)
'        Dashboard.DataGridHR.ReadOnly = True
'        Dashboard.DataGridHR.DataSource = apdb.getemployee(command)
'        Dashboard.DataGridHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'        Dashboard.DataGridHR.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None


'        Dashboard.DataGridHR.Columns(0).HeaderText = "Username"
'        Dashboard.DataGridHR.Columns(1).HeaderText = "Password"
'        Dashboard.DataGridHR.Columns(2).HeaderText = "Name"
'        Dashboard.DataGridHR.Columns(3).HeaderText = "Email"
'        Dashboard.DataGridHR.Columns(4).HeaderText = "Title"
'        Dashboard.DataGridHR.Columns(5).HeaderText = "Department"
'        Dashboard.LabelTotalHR.Text = Dashboard.DataGridHR.Rows.Count
'    End Sub

'    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
'        Dim user As String = TextBoxUsername.Text
'        Dim pass As String = TextBoxPassword.Text
'        Dim name As String = TextBoxName.Text
'        Dim email As String = TextBoxEmail.Text
'        Dim title As String = ComboBoxTitle.SelectedItem
'        Dim dept As String = ComboBoxDept.SelectedItem
'        Dim cmdInsert As String = "INSERT INTO `login`(`user`, `pass`, `name`, `email`, `title`, `department`) VALUES (@user, @pass, @name, @email, @title, @dept)"

'        If apdb.insertHRUser(user, pass, name, email, title, dept, cmdInsert) Then
'            TextBoxUsername.Clear()
'            TextBoxPassword.Clear()
'            TextBoxName.Clear()
'            TextBoxEmail.Clear()
'            ComboBoxTitle.SelectedIndex = -1
'            ComboBoxDept.SelectedIndex = -1
'            MsgBox("Successful Add User", MsgBoxStyle.Information, "ADD")
'            Me.Close()
'        End If
'    End Sub

'    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
'        Me.Close()
'    End Sub

'    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
'        Dim user As String = TextBoxUsername.Text
'        If apdb.deleteHRUser(user) Then
'            TextBoxUsername.Clear()
'            TextBoxPassword.Clear()
'            TextBoxName.Clear()
'            TextBoxEmail.Clear()
'            ComboBoxTitle.SelectedIndex = -1
'            ComboBoxDept.SelectedIndex = -1
'            MsgBox("Successful Delete User", MsgBoxStyle.Information, "DELETE")
'            Me.Close()

'        End If
'    End Sub

'    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
'        Dim user As String = TextBoxUsername.Text
'        Dim pass As String = TextBoxPassword.Text
'        Dim name As String = TextBoxName.Text
'        Dim email As String = TextBoxEmail.Text
'        Dim title As String = ComboBoxTitle.SelectedItem
'        Dim dept As String = ComboBoxDept.SelectedItem
'        Dim cmdUpdate As String = "UPDATE `login` SET `user`=@user, `pass`=@pass, `name`=@name, `email`=@email, `title`=@title, `department`=@dept WHERE user='" & TextBoxUsername.Text & "'"

'        If apdb.UpdateHRUser(user, pass, name, email, title, dept, cmdUpdate) Then
'            TextBoxUsername.Clear()
'            TextBoxPassword.Clear()
'            TextBoxName.Clear()
'            TextBoxEmail.Clear()
'            ComboBoxTitle.SelectedIndex = -1
'            ComboBoxDept.SelectedIndex = -1
'            MsgBox("Successful Update User", MsgBoxStyle.Information, "Update")
'            Me.Close()
'        End If
'    End Sub
'End Class