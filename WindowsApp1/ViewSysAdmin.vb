
Public Class ViewSysAdmin
    Dim apdb As New ApprovalDB

    Dim checklaptop As String = "Unchecked"
    Dim checkemail As String = "Unchecked"
    Dim checkcomputer As String = "Unchecked"



    Dim inserthistory As String
    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String


    Dim SysAdminNameAccept As String
    Dim SysAdminStatAccept As String
    Dim SysAdminCommentAccept As String
    Dim SysAdminDateAccept As String


    Function verf() As Boolean
        Dim checker As Integer = 0

        If CheckBoxLaptop.Checked = False Then
            CheckBoxLaptop.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxEmail.Checked = False Then
            CheckBoxEmail.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxComputer.Checked = False Then
            CheckBoxComputer.BackColor = Color.DarkRed
            checker += 1
        End If

        If checker > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    'ACCEPT
    Private Sub btnSysAdminApp_Click(sender As Object, e As EventArgs) Handles btnSysAdminApp.Click
        If verf() = True Then

            SysAdminStatAccept = "Approve"

            SysAdminNameAccept = LabelSysAdminName.Text

            SysAdminCommentAccept = txtboxSysAdmin.Text

            SysAdminDateAccept = Date.Today

            LabelSysAdminApp.Text = SysAdminStatAccept

            LabelDateSysAdmin.Text = SysAdminDateAccept

            LabelSysAdminComment.Text = txtboxSysAdmin.Text

            statusNextflow = "Pending"

            inserthistory = "INSERT INTO `sysadminhistory`( `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @lblname, @stats, @comment, @dateapp, @checklaptop, @checkemail, @checkcom)"

            updateHistory = "UPDATE `historyrequest` SET `SysAdminName`=@lblname, `SysAdminStatus`=@stats, `SysAdminComment`=@comment, `SysAdminDate`=@dateapp, `CheckLaptop`=@checklaptop, `CheckEmail`=@checkemail, `CheckCom`=@checkcom WHERE empID = '" & LabelEmpID.Text & "'"

            apdb.insertSysAdminhistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SysAdminNameAccept, SysAdminStatAccept, SysAdminCommentAccept, SysAdminDateAccept, checklaptop, checkemail, checkcomputer, inserthistory)

            apdb.updateSysAdmin(SysAdminNameAccept, SysAdminStatAccept, SysAdminCommentAccept, SysAdminDateAccept, checklaptop, checkemail, checkcomputer, updateHistory)


            insertNextFlow = "INSERT INTO `sysadmingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `sysadminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)

            btnSysAdminApp.Visible = False
            btnsysAdminReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxEmail.Enabled = False
            CheckBoxComputer.Enabled = False
            CheckBoxLaptop.Enabled = False

            LabelSysAdminComment.Visible = True


            txtboxSysAdmin.Visible = False
            txtboxSysAdmin.Text = ""

        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Admin Dept")
        End If

    End Sub

    'END OF REJECT




    'REJECT
    Private Sub btnSysAdminReject_Click(sender As Object, e As EventArgs) Handles btnSysAdminReject.Click
        If verf() = True Then

            SysAdminStatAccept = "REJECT"

            SysAdminNameAccept = LabelSysAdminName.Text

            SysAdminCommentAccept = txtboxSysAdmin.Text

            SysAdminDateAccept = Date.Today

            LabelSysAdminApp.Text = SysAdminStatAccept

            LabelDateSysAdmin.Text = SysAdminDateAccept

            LabelSysAdminComment.Text = txtboxSysAdmin.Text

            statusNextflow = "Pending"

            inserthistory = "INSERT INTO `sysadminhistory`( `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @lblname, @stats, @comment, @dateapp, @checklaptop, @checkemail, @checkcom)"

            updateHistory = "UPDATE `historyrequest` SET `SysAdminName`=@lblname, `SysAdminStatus`=@stats, `SysAdminComment`=@comment, `SysAdminDate`=@dateapp, `CheckLaptop`=@checklaptop, `CheckEmail`=@checkemail, `CheckCom`=@checkcom WHERE empID = '" & LabelEmpID.Text & "'"

            apdb.insertSysAdminhistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SysAdminNameAccept, SysAdminStatAccept, SysAdminCommentAccept, SysAdminDateAccept, checklaptop, checkemail, checkcomputer, inserthistory)

            apdb.updateSysAdmin(SysAdminNameAccept, SysAdminStatAccept, SysAdminCommentAccept, SysAdminDateAccept, checklaptop, checkemail, checkcomputer, updateHistory)


            insertNextFlow = "INSERT INTO `sysadmingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `sysadminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)

            btnSysAdminApp.Visible = False
            btnSysAdminReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxEmail.Enabled = False
            CheckBoxComputer.Enabled = False
            CheckBoxLaptop.Enabled = False

            LabelSysAdminComment.Visible = True


            txtboxSysAdmin.Visible = False
            txtboxSysAdmin.Text = ""

        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Admin Dept")
        End If
    End Sub

    'END OF REJECT




    Private Sub LabelSysAdminApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminApp.TextChanged
        If LabelSysAdminApp.Text = "Pending" Then
            LabelSysAdminApp.BackColor = Color.PowderBlue
        ElseIf LabelSysAdminApp.Text = "Approve" Then
            LabelSysAdminApp.BackColor = Color.Lime
        Else
            LabelSysAdminApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        btnSysAdminApp.Visible = True
        btnSysAdminReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxLaptop.Enabled = True
        CheckBoxEmail.Enabled = True
        CheckBoxComputer.Enabled = True
        CheckBoxEmail.Checked = False
        CheckBoxComputer.Checked = False
        CheckBoxLaptop.Checked = False

        LabelSysAdminApp.Text = "Pending"
        LabelSysAdminComment.Visible = False
        LabelSysAdminComment.Text = ""
        LabelDateSysAdmin.Text = ""

        txtboxSysAdmin.Visible = True
        txtboxSysAdmin.Text = ""

        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        btnSysAdminApp.Visible = True
        btnSysAdminReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxLaptop.Enabled = True
        CheckBoxEmail.Enabled = True
        CheckBoxComputer.Enabled = True
        CheckBoxEmail.Checked = False
        CheckBoxComputer.Checked = False
        CheckBoxLaptop.Checked = False

        LabelSysAdminApp.Text = "Pending"
        LabelSysAdminComment.Visible = False
        LabelSysAdminComment.Text = ""
        LabelDateSysAdmin.Text = ""

        txtboxSysAdmin.Visible = True
        txtboxSysAdmin.Text = ""

        Me.Close()
    End Sub



    Private Sub CheckBoxEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmail.CheckedChanged

        If CheckBoxEmail.Checked = True Then
            checkemail = "Checked"
            CheckBoxEmail.BackColor = Color.Green
        ElseIf CheckBoxEmail.Checked = False Then
            CheckBoxEmail.BackColor = Color.Gray
            checkemail = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxComputer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxComputer.CheckedChanged

        If CheckBoxComputer.Checked = True Then
            checkcomputer = "Checked"
            CheckBoxComputer.BackColor = Color.Green
        ElseIf CheckBoxComputer.Checked = False Then
            CheckBoxComputer.BackColor = Color.Gray
            checkcomputer = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxLaptop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLaptop.CheckedChanged

        If CheckBoxLaptop.Checked = True Then
            checklaptop = "Checked"
            CheckBoxLaptop.BackColor = Color.Green
        ElseIf CheckBoxLaptop.Checked = False Then
            CheckBoxLaptop.BackColor = Color.Gray
            checklaptop = "Unchecked"
        End If

    End Sub

    Private Sub ViewSysAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        btnSysAdminApp.Visible = True
        btnSysAdminReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxLaptop.Enabled = True
        CheckBoxEmail.Enabled = True
        CheckBoxComputer.Enabled = True
        CheckBoxEmail.Checked = False
        CheckBoxComputer.Checked = False
        CheckBoxLaptop.Checked = False

        LabelSysAdminApp.Text = "Pending"
        LabelSysAdminComment.Visible = False
        LabelSysAdminComment.Text = ""
        LabelDateSysAdmin.Text = ""

        txtboxSysAdmin.Visible = True
        txtboxSysAdmin.Text = ""


        CheckBoxEmail.BackColor = Color.Gray
        CheckBoxComputer.BackColor = Color.Gray

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


End Class