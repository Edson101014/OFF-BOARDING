Imports MySql.Data.MySqlClient
Public Class HRUser
    Dim dbs As New db
    Dim apdb As New ApprovalDB
    Dim query As New MySqlCommand()

    Dim user As String
    Dim pass As String
    Dim names As String
    Dim email As String
    Dim title As String
    Dim dept As String
    Dim cmdInsert As String

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        user = TextBoxUsername.Text
        pass = TextBoxPassword.Text
        names = TextBoxName.Text
        email = TextBoxEmail.Text
        title = ComboBoxTitle.SelectedItem
        dept = ComboBoxDepartment.SelectedItem

        cmdInsert = "INSERT INTO `login`(`user`, `pass`, `name`, `email`, `title`, `department`) VALUES (@user, @pass, @name, @email, @title, @dept)"
        apdb.insertHRUser(user, pass, names, email, title, dept, cmdInsert)

        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxName.Clear()
        TextBoxEmail.Clear()
        ComboBoxTitle.SelectedIndex = -1
        ComboBoxDepartment.SelectedIndex = -1

        MsgBox("Successful Add User", MsgBoxStyle.Information, "ADD")
        Me.Close()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        user = TextBoxUsername.Text
        cmdInsert = "DELETE FROM `login` WHERE `user`='" & TextBoxUsername.Text & "'"

        apdb.deleteHRuser(user, cmdInsert)
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxName.Clear()
        TextBoxEmail.Clear()
        ComboBoxTitle.SelectedIndex = -1
        ComboBoxDepartment.SelectedIndex = -1
        MsgBox("Successful Delete User", MsgBoxStyle.Information, "Delete")
        Me.Close()

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        user = TextBoxUsername.Text
        pass = TextBoxPassword.Text
        names = TextBoxName.Text
        email = TextBoxEmail.Text
        title = ComboBoxTitle.SelectedItem
        dept = ComboBoxDepartment.SelectedItem

        cmdInsert = "UPDATE `login` SET `user`=@user, `pass`=@pass, `name`=@name, `email`=@email, `title`=@title, `department`=@dept WHERE id='" & labelID.Text & "'"
        apdb.updateHRUser(user, pass, names, email, title, dept, cmdInsert)
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxName.Clear()
        TextBoxEmail.Clear()
        ComboBoxTitle.SelectedIndex = -1
        ComboBoxDepartment.SelectedIndex = -1
        MsgBox("Successful Update User", MsgBoxStyle.Information, "Delete")
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub HRUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        ButtonADD.Visible = False
        ButtonEdit.Visible = False
        ButtonDelete.Visible = False

        TextBoxName.Enabled = False
        TextBoxUsername.Enabled = False
        TextBoxPassword.Enabled = False
        TextBoxEmail.Enabled = False
        ComboBoxtitle.Enabled = False
        ComboBoxDepartment.Enabled = False

        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxName.Clear()
        TextBoxEmail.Clear()
        ComboBoxTitle.SelectedIndex = -1
        ComboBoxDepartment.SelectedIndex = -1

        If Login.flag = "Finance Dept Head" Then
            ShowFinanceData()

        ElseIf Login.flag = "SYSADMIN" Then
            ShowSysAdminData()

        ElseIf Login.flag = "ADMIN" Then
            ShowAdminData()

        ElseIf Login.flag = "HR" Then
            ShowHRData()
        ElseIf Login.flag = "HR Interview" Then
            ShowHRInterviewData()

        ElseIf Login.flag = "HR Head" Then
            ShowHRHeadData()
        Else
            ShowData()
        End If

    End Sub

    Private Sub TextBoxName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
            Case Keys.A To Keys.Z
            Case Keys.Left, Keys.Right, Keys.Back

            Case Else : e.SuppressKeyPress = True


        End Select
    End Sub

    Private Sub ComboBoxTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTitle.SelectedIndexChanged
        If ComboBoxTitle.SelectedItem = "Dept Head" Then
            ComboBoxDepartment.SelectedItem = "Admin"
            ComboBoxDepartment.Items.Clear()

            ComboBoxDepartment.Items.Add("Admin")
            ComboBoxDepartment.SelectedItem = "Admin"
            ComboBoxDepartment.Items.Add("BDG")
            ComboBoxDepartment.Items.Add("Finance")
            ComboBoxDepartment.Items.Add("ITOPS")
            ComboBoxDepartment.Items.Add("Marketing")
            ComboBoxDepartment.Items.Add("PMG")
            ComboBoxDepartment.Items.Add("System Admin")
            ComboBoxDepartment.Items.Add("HR")
        ElseIf ComboBoxTitle.SelectedItem = "Supervisor" Then
            ComboBoxDepartment.SelectedItem = "Admin"
            ComboBoxDepartment.Items.Clear()
            ComboBoxDepartment.Items.Add("Admin")
            ComboBoxDepartment.SelectedItem = "Admin"
            ComboBoxDepartment.Items.Add("Finance")
            ComboBoxDepartment.Items.Add("SDG")
            ComboBoxDepartment.Items.Add("System Admin")
            ComboBoxDepartment.Items.Add("HR")
        ElseIf ComboBoxTitle.SelectedItem = "Interview" Then
            ComboBoxDepartment.SelectedItem = "HR"
            ComboBoxDepartment.Items.Clear()

            ComboBoxDepartment.Items.Add("HR")
            ComboBoxDepartment.SelectedItem = "HR"
        End If
    End Sub
End Class