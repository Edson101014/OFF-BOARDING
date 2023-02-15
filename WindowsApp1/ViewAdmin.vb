Public Class ViewAdmin
    Dim apdb As New ApprovalDB



    Dim checkteleco As String = "Unchecked"
    Dim checktools As String = "Unchecked"
    Dim checkphone As String = "Unchecked"
    Dim checktable As String = "Unchecked"
    Dim checkothers As String = "Unchecked"


    Dim inserthistory As String
    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String


    Dim AdminNameAccept As String
    Dim AdminStatAccept As String
    Dim AdminCommentAccept As String
    Dim AdminDateAccept As String
    Dim AdminOthersComment As String


    Function verf() As Boolean
        Dim checker As Integer = 0



        If CheckBoxTelco.Checked = False Then
            CheckBoxTelco.BackColor = Color.Firebrick
        End If

        If CheckBoxTools.Checked = False Then
            CheckBoxTools.BackColor = Color.Firebrick
        End If

        If CheckBoxPhone.Checked = False Then
            CheckBoxPhone.BackColor = Color.Firebrick
        End If

        If CheckBoxTable.Checked = False Then
            CheckBoxTable.BackColor = Color.Firebrick
        End If

        If CheckBoxOthers.Checked = False Then
            CheckBoxOthers.BackColor = Color.Firebrick
        End If

        If txtboxOther.Enabled = True Then
            If txtboxOther.Text.Trim() = "" Then
                txtboxOther.BackColor = Color.Firebrick
                checker += 1
            End If
        End If

        If CheckBoxOthers.Checked = False Or CheckBoxTelco.Checked = False Or CheckBoxTools.Checked = False Or CheckBoxPhone.Checked = False Or CheckBoxTable.Checked = False Then
            If MsgBox("Other CheckBox is UNCHECKED. Are You Sure You Want To Proceed?", MsgBoxStyle.YesNo, "Admin Group") = MsgBoxResult.Yes Then
                checker += 0
            Else
                checker += 1
            End If
        End If

        If checker > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Accept
    Private Sub btnAdminDeptApp_Click(sender As Object, e As EventArgs) Handles btnAdminDeptApp.Click

        If verf() = True Then

            AdminStatAccept = "Approve"

            AdminNameAccept = LabelAdminName.Text

            AdminCommentAccept = txtboxAdminDept.Text

            AdminOthersComment = txtboxOther.Text

            AdminDateAccept = Date.Today

            LabelAdminDeptApp.Text = AdminStatAccept

            LabelDateAdminDept.Text = AdminDateAccept

            LabelAdminDeptComment.Text = txtboxAdminDept.Text

            LabelOthers.Text = txtboxOther.Text

            statusNextflow = "Pending"


            inserthistory = "INSERT INTO `admingrouphistory`( `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @lblname, @stats, @comment, @dateapp, @checkteleco, @checktools, @checkphone, @checktable, @checkothers, @checkotherscomment)"

            updateHistory = "UPDATE `historyrequest` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"


            apdb.insertAdminhistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, inserthistory)

            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)


            insertNextFlow = "INSERT INTO `admingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `adminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)

            btnAdminDeptApp.Visible = False
            btnAdminDeptReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxTelco.Enabled = False
            CheckBoxTools.Enabled = False
            CheckBoxPhone.Enabled = False
            CheckBoxTable.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelAdminDeptComment.Visible = True
            LabelOthers.Visible = True

            txtboxAdminDept.Visible = False
            txtboxAdminDept.Text = ""
            txtboxOther.Enabled = False
        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Admin Dept")
        End If


    End Sub

    'END OF ACCEPT







    'REJECT



    Private Sub btnAdminDeptReject_Click(sender As Object, e As EventArgs) Handles btnAdminDeptReject.Click


        AdminStatAccept = "Reject"

            AdminNameAccept = LabelAdminName.Text

            AdminCommentAccept = txtboxAdminDept.Text

            AdminOthersComment = txtboxOther.Text

            AdminDateAccept = Date.Today

            LabelAdminDeptApp.Text = AdminStatAccept

            LabelDateAdminDept.Text = AdminDateAccept

            LabelAdminDeptComment.Text = txtboxAdminDept.Text

            LabelOthers.Text = txtboxOther.Text

            statusNextflow = "Pending"


            inserthistory = "INSERT INTO `admingrouphistory`( `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @lblname, @stats, @comment, @dateapp, @checkteleco, @checktools, @checkphone, @checktable, @checkothers, @checkotherscomment)"

            updateHistory = "UPDATE `historyrequest` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"


            apdb.insertAdminhistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, inserthistory)

            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)

            insertNextFlow = "INSERT INTO `admingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `adminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)

            btnAdminDeptApp.Visible = False
            btnAdminDeptReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True


            CheckBoxTelco.Enabled = False
            CheckBoxTools.Enabled = False
            CheckBoxPhone.Enabled = False
            CheckBoxTable.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelAdminDeptComment.Visible = True
            LabelOthers.Visible = True

            txtboxAdminDept.Visible = False
            txtboxAdminDept.Text = ""
            txtboxOther.Enabled = False



    End Sub



    'END OF REJECT




    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click

        If verf() = True Then
            AdminStatAccept = "Approve"

            AdminNameAccept = LabelAdminName.Text

            AdminCommentAccept = txtboxAdminDept.Text

            AdminOthersComment = txtboxOther.Text

            AdminDateAccept = Date.Today

            LabelAdminDeptApp.Text = AdminStatAccept

            LabelDateAdminDept.Text = AdminDateAccept

            LabelAdminDeptComment.Text = txtboxAdminDept.Text

            LabelOthers.Text = txtboxOther.Text

            updateHistory = "UPDATE `admingrouphistory` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)

            updateHistory = "UPDATE `historyrequest` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)



            ButtonEdit.Visible = True
            ButtonEditApprove.Visible = False
            ButtonEditReject.Visible = False
            ButtonEditCancel.Visible = False
            ButtonClose.Visible = True


            CheckBoxTelco.Enabled = False
            CheckBoxTools.Enabled = False
            CheckBoxPhone.Enabled = False
            CheckBoxTable.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelAdminDeptComment.Visible = True
            LabelOthers.Visible = True

            txtboxAdminDept.Visible = False
            txtboxAdminDept.Text = ""
            txtboxOther.Enabled = False
            txtboxOther.Visible = False

        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Admin Dept")
        End If

    End Sub

    'END OF EDIT APPROVE





    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click


        AdminStatAccept = "Reject"

            AdminNameAccept = LabelAdminName.Text

            AdminCommentAccept = txtboxAdminDept.Text

            AdminOthersComment = txtboxOther.Text

            AdminDateAccept = Date.Today

            LabelAdminDeptApp.Text = AdminStatAccept

            LabelDateAdminDept.Text = AdminDateAccept

            LabelAdminDeptComment.Text = txtboxAdminDept.Text

            LabelOthers.Text = txtboxOther.Text


            updateHistory = "UPDATE `admingrouphistory` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)

            updateHistory = "UPDATE `historyrequest` SET `AdminGroupName`=@lblname, `AdminGroupStatus`=@stats, `AdminGroupComment`=@comment, `AdminGroupDate`=@dateapp, `CheckTeleco`=@checkteleco, `CheckTools`=@checktools, `CheckPhone`=@checkphone, `CheckTable`=@checktable, `CheckOthers`=@checkothers, `CheckOthersComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateAdmin(AdminNameAccept, AdminStatAccept, AdminCommentAccept, AdminDateAccept, checkteleco, checktools, checkphone, checktable, checkothers, AdminOthersComment, updateHistory)




            ButtonEdit.Visible = True
            ButtonEditApprove.Visible = False
            ButtonEditReject.Visible = False
            ButtonEditCancel.Visible = False
            ButtonClose.Visible = True


            CheckBoxTelco.Enabled = False
            CheckBoxTools.Enabled = False
            CheckBoxPhone.Enabled = False
            CheckBoxTable.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelAdminDeptComment.Visible = True
            LabelOthers.Visible = True

            txtboxAdminDept.Visible = False
            txtboxAdminDept.Text = ""
            txtboxOther.Enabled = False
            txtboxOther.Visible = False



    End Sub

    'END OF EDIT REJECT





    Private Sub LabelAdminDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminDeptApp.TextChanged
        If LabelAdminDeptApp.Text = "Pending" Then
            LabelAdminDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelAdminDeptApp.Text = "Approve" Then
            LabelAdminDeptApp.BackColor = Color.Lime
        Else
            LabelAdminDeptApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        CheckBoxTelco.Enabled = True
        CheckBoxTools.Enabled = True
        CheckBoxPhone.Enabled = True
        CheckBoxTable.Enabled = True
        CheckBoxOthers.Enabled = True

        txtboxAdminDept.Visible = True
        txtboxAdminDept.Text = LabelAdminDeptComment.Text
        LabelAdminDeptComment.Visible = False
        txtboxOther.Visible = True
        txtboxOther.Text = LabelOthers.Text
        LabelOthers.Visible = False
    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        CheckBoxTelco.Enabled = False
        CheckBoxTools.Enabled = False
        CheckBoxPhone.Enabled = False
        CheckBoxTable.Enabled = False
        CheckBoxOthers.Enabled = False



        txtboxAdminDept.Visible = False
        txtboxAdminDept.Text = LabelAdminDeptComment.Text
        LabelAdminDeptComment.Visible = True
        txtboxOther.Visible = False
        txtboxOther.Text = LabelOthers.Text
        LabelOthers.Visible = True

    End Sub


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnAdminDeptApp.Visible = True
        btnAdminDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False


        CheckBoxTelco.Checked = False
        CheckBoxTools.Checked = False
        CheckBoxPhone.Checked = False
        CheckBoxTable.Checked = False
        CheckBoxOthers.Checked = False

        CheckBoxTelco.Enabled = True
        CheckBoxTools.Enabled = True
        CheckBoxPhone.Enabled = True
        CheckBoxTable.Enabled = True
        CheckBoxOthers.Enabled = True


        LabelAdminDeptApp.Text = "Pending"
        LabelAdminDeptComment.Text = ""
        LabelDateAdminDept.Text = ""
        LabelAdminDeptComment.Visible = False
        LabelOthers.Visible = False
        LabelOthers.Text = ""


        txtboxAdminDept.Visible = True
        txtboxAdminDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnAdminDeptApp.Visible = True
        btnAdminDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False



        CheckBoxTelco.Checked = False
        CheckBoxTools.Checked = False
        CheckBoxPhone.Checked = False
        CheckBoxTable.Checked = False
        CheckBoxOthers.Checked = False

        CheckBoxTelco.Enabled = True
        CheckBoxTools.Enabled = True
        CheckBoxPhone.Enabled = True
        CheckBoxTable.Enabled = True
        CheckBoxOthers.Enabled = True

        LabelAdminDeptApp.Text = "Pending"
        LabelAdminDeptComment.Text = ""
        LabelDateAdminDept.Text = ""
        LabelAdminDeptComment.Visible = False
        LabelOthers.Visible = False
        LabelOthers.Text = ""

        txtboxAdminDept.Visible = True
        txtboxAdminDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""
        Me.Close()
    End Sub



    Private Sub CheckBoxTelco_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTelco.CheckedChanged
        If CheckBoxTelco.Checked = True Then
            checkteleco = "Checked"
            CheckBoxTelco.BackColor = Color.Green
        ElseIf CheckBoxTelco.Checked = False Then
            CheckBoxTelco.BackColor = Color.Gray
            checkteleco = "Unchecked"
        End If
    End Sub

    Private Sub CheckBoxTools_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTools.CheckedChanged
        If CheckBoxTools.Checked = True Then
            checktools = "Checked"
            CheckBoxTools.BackColor = Color.Green
        ElseIf CheckBoxTools.Checked = False Then
            CheckBoxTools.BackColor = Color.Gray
            checktools = "Unchecked"
        End If
    End Sub

    Private Sub CheckBoxPhone_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPhone.CheckedChanged
        If CheckBoxPhone.Checked = True Then
            checkphone = "Checked"
            CheckBoxPhone.BackColor = Color.Green
        ElseIf CheckBoxPhone.Checked = False Then
            CheckBoxPhone.BackColor = Color.Gray
            checkphone = "Unchecked"
        End If
    End Sub

    Private Sub CheckBoxTable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTable.CheckedChanged
        If CheckBoxTable.Checked = True Then
            checktable = "Checked"
            CheckBoxTable.BackColor = Color.Green
        ElseIf CheckBoxTable.Checked = False Then
            CheckBoxTable.BackColor = Color.Gray
            checktable = "Unchecked"
        End If
    End Sub

    Private Sub CheckBoxOthers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOthers.CheckedChanged
        If CheckBoxOthers.Checked = True Then
            checkothers = "Checked"
            CheckBoxOthers.BackColor = Color.Green
            txtboxOther.Enabled = True
            txtboxOther.BackColor = SystemColors.Window
        ElseIf CheckBoxOthers.Checked = False Then
            CheckBoxOthers.BackColor = Color.Gray
            checkothers = "Unchecked"
            txtboxOther.Enabled = False
            txtboxOther.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub ViewAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnAdminDeptApp.Visible = True
        btnAdminDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        CheckBoxTelco.Checked = False
        CheckBoxTools.Checked = False
        CheckBoxPhone.Checked = False
        CheckBoxTable.Checked = False
        CheckBoxOthers.Checked = False

        CheckBoxTelco.Enabled = True
        CheckBoxTools.Enabled = True
        CheckBoxPhone.Enabled = True
        CheckBoxTable.Enabled = True
        CheckBoxOthers.Enabled = True

        LabelAdminDeptApp.Text = "Pending"
        LabelAdminDeptComment.Text = ""
        LabelDateAdminDept.Text = ""
        LabelAdminDeptComment.Visible = False
        LabelOthers.Visible = False
        LabelOthers.Text = ""

        txtboxAdminDept.Visible = True
        txtboxAdminDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""


        CheckBoxTelco.BackColor = Color.Gray
        CheckBoxTools.BackColor = Color.Gray
        CheckBoxPhone.BackColor = Color.Gray
        CheckBoxTable.BackColor = Color.Gray
        CheckBoxOthers.BackColor = Color.Gray

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

    Private Sub txtboxOther_MouseClick(sender As Object, e As MouseEventArgs) Handles txtboxOther.MouseClick
        txtboxOther.BackColor = SystemColors.Control
    End Sub





End Class