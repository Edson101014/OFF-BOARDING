Imports MySql.Data.MySqlClient
Public Class ViewFinance
    Dim apdb As New ApprovalDB
    'Dim dbs As New db
    'Dim adapter As New MySqlDataAdapter
    'Dim table As New DataTable

    Dim inserthistory As String
    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    'Dim insertchecker As String
    'Dim check As Integer
    Dim checkcash As String = "Unchecked"
    Dim checkothers As String = "Unchecked"

    Dim FinanceNameAccept As String
    Dim FinanceStatAccept As String
    Dim FinanceCommentAccept As String
    Dim FinanceDateAccept As Date

    Dim FinanceOthersComment As String


    Function verf() As Boolean
        Dim checker As Integer = 0

        If CheckBoxCash.Checked = False Then
            CheckBoxCash.BackColor = Color.Red
            checker += 1
        End If

        If CheckBoxOthers.Checked = False Then
            CheckBoxOthers.BackColor = Color.Red
        End If

        If txtboxOther.Enabled = True Then
            If txtboxOther.Text.Trim() = "" Then
                txtboxOther.BackColor = Color.Red
                checker += 1
            End If
        End If

        If CheckBoxCash.Checked = True And CheckBoxOthers.Checked = False Then
            If MsgBox("CheckBox Others is UNCHECKED. Are You Sure You Want To Procced?", MsgBoxStyle.YesNo, "Finance Dept") = MsgBoxResult.Yes Then
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

    'ACCEPT
    Private Sub btnMarketingDeptApp_Click(sender As Object, e As EventArgs) Handles btnFinanceDeptApp.Click
        If verf() = True Then
            FinanceStatAccept = "Approve"

            FinanceNameAccept = LabelFinanceName.Text

            FinanceCommentAccept = txtboxFinanceDept.Text

            FinanceOthersComment = txtboxOther.Text

            FinanceDateAccept = Date.Today

            LabelFinanceDeptApp.Text = FinanceStatAccept

            LabelDateFinanceDept.Text = FinanceDateAccept

            LabelFinanceDeptComment.Text = txtboxFinanceDept.Text

            'statusNextflow = "Pending"
            'check = 1


            inserthistory = "INSERT INTO `Financedepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FinanceDeptName`, `FinanceDeptStatus`, `FinanceDeptDate`, `FinanceDeptComment`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment, @checkcash, @checkothers, @checkotherscomment)"
            updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"

            apdb.insertFinance(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, inserthistory)
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)


            'If verfFINANCEIfEmpty() = True Then
            '    insertchecker = "UPDATE `checkergroup` SET `Finance`=@check WHERE empid='" & LabelEmpID.Text & "'"
            '    apdb.updatechecker(check, insertchecker)

            '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
            '    If updated AndAlso verfGroupIfComplete() = True Then
            '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
            '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
            '    End If
            'End If



            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)


            btnFinanceDeptApp.Visible = False
            btnFinanceDeptReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxCash.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelFinanceDeptComment.Visible = True

            txtboxFinanceDept.Visible = False
            txtboxFinanceDept.Text = ""
            txtboxOther.Enabled = False
        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Finance Dept")
        End If

    End Sub


    'END OF ACCEPT





    'REJECT



    Private Sub btnFinanceDeptReject_Click(sender As Object, e As EventArgs) Handles btnFinanceDeptReject.Click

        FinanceStatAccept = "Reject"

            FinanceNameAccept = LabelFinanceName.Text

            FinanceCommentAccept = txtboxFinanceDept.Text

            FinanceOthersComment = txtboxOther.Text

            FinanceDateAccept = Date.Today

            LabelFinanceDeptApp.Text = FinanceStatAccept

            LabelDateFinanceDept.Text = FinanceDateAccept

            LabelFinanceDeptComment.Text = txtboxFinanceDept.Text

            'statusNextflow = "Pending"
            'check = 1


            inserthistory = "INSERT INTO `Financedepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FinanceDeptName`, `FinanceDeptStatus`, `FinanceDeptDate`, `FinanceDeptComment`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment, @checkcash, @checkothers, @checkotherscomment)"
            updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"


            apdb.insertFinance(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, inserthistory)
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)


            'If verfFINANCEIfEmpty() = True Then
            '    insertchecker = "UPDATE `checkergroup` SET `Finance`=@check WHERE empid='" & LabelEmpID.Text & "'"
            '    apdb.updatechecker(check, insertchecker)

            '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
            '    If updated AndAlso verfGroupIfComplete() = True Then
            '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
            '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
            '    End If
            'End If

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)


            btnFinanceDeptApp.Visible = False
            btnFinanceDeptReject.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxCash.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelFinanceDeptComment.Visible = True

            txtboxFinanceDept.Visible = False
            txtboxFinanceDept.Text = ""
            txtboxOther.Enabled = False

    End Sub

    'END OF REJECT






    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click

        If verf() = True Then
            FinanceStatAccept = "Approve"

            FinanceNameAccept = LabelFinanceName.Text

            FinanceCommentAccept = txtboxFinanceDept.Text

            FinanceOthersComment = txtboxOther.Text

            FinanceDateAccept = Date.Today

            LabelFinanceDeptApp.Text = FinanceStatAccept

            LabelDateFinanceDept.Text = FinanceDateAccept

            LabelFinanceDeptComment.Text = txtboxFinanceDept.Text


            updateHistory = "UPDATE `financedepthistory` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)

            updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)






            ButtonEdit.Visible = True
            ButtonEditApprove.Visible = False
            ButtonEditReject.Visible = False
            ButtonEditCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxCash.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelFinanceDeptComment.Visible = True

            txtboxFinanceDept.Visible = False
            txtboxFinanceDept.Text = ""
            txtboxOther.Enabled = False

        Else
            MsgBox("Please fill out all the items", MsgBoxStyle.Exclamation, "Finance Dept")
        End If

    End Sub

    'END OF EDIT APPROVE







    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click

        FinanceStatAccept = "Reject"

            FinanceNameAccept = LabelFinanceName.Text

            FinanceCommentAccept = txtboxFinanceDept.Text

            FinanceOthersComment = txtboxOther.Text

            FinanceDateAccept = Date.Today

            LabelFinanceDeptApp.Text = FinanceStatAccept

            LabelDateFinanceDept.Text = FinanceDateAccept

            LabelFinanceDeptComment.Text = txtboxFinanceDept.Text


            updateHistory = "UPDATE `financedepthistory` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)

            updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDate`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `FinanceDeptOthers`=@checkothers, `FinanceDeptOtherComment`=@checkotherscomment WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkcash, checkothers, FinanceOthersComment, updateHistory)





            ButtonEdit.Visible = True
            ButtonEditApprove.Visible = False
            ButtonEditReject.Visible = False
            ButtonEditCancel.Visible = False
            ButtonClose.Visible = True

            CheckBoxCash.Enabled = False
            CheckBoxOthers.Enabled = False

            LabelFinanceDeptComment.Visible = True

            txtboxFinanceDept.Visible = False
            txtboxFinanceDept.Text = ""
            txtboxOther.Enabled = False


    End Sub

    'END OF EDIT REJECT





    Private Sub LabelFinanceDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelFinanceDeptApp.TextChanged
        If LabelFinanceDeptApp.Text = "Pending" Then
            LabelFinanceDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelFinanceDeptApp.Text = "Approve" Then
            LabelFinanceDeptApp.BackColor = Color.Lime
        Else
            LabelFinanceDeptApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub CheckBoxCash_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCash.CheckedChanged
        If CheckBoxCash.Checked = True Then
            checkcash = "Checked"
            CheckBoxCash.BackColor = Color.Lime
        ElseIf CheckBoxCash.Checked = False Then
            CheckBoxCash.BackColor = Color.Gray
            checkcash = "Unchecked"
        End If
    End Sub

    Private Sub CheckBoxOthers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOthers.CheckedChanged
        If CheckBoxOthers.Checked = True Then
            checkothers = "Checked"
            CheckBoxOthers.BackColor = Color.Lime
            txtboxOther.Enabled = True
        ElseIf CheckBoxOthers.Checked = False Then
            CheckBoxOthers.BackColor = Color.Gray
            checkothers = "Unchecked"
            txtboxOther.Enabled = False
            txtboxOther.Text = ""
        End If
    End Sub


    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        CheckBoxCash.Enabled = True
        CheckBoxOthers.Enabled = True

        If CheckBoxOthers.Checked = True Then
            txtboxOther.Enabled = True
        Else
            txtboxOther.Enabled = False
        End If

        txtboxFinanceDept.Visible = True
        txtboxFinanceDept.Text = LabelFinanceDeptComment.Text
        LabelFinanceDeptComment.Visible = False

    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        CheckBoxCash.Enabled = False
        CheckBoxOthers.Enabled = False

        txtboxOther.Enabled = False
        txtboxFinanceDept.Visible = False
        txtboxFinanceDept.Text = LabelFinanceDeptComment.Text
        LabelFinanceDeptComment.Visible = True

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnFinanceDeptApp.Visible = True
        btnFinanceDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxCash.Checked = False
        CheckBoxOthers.Checked = False
        CheckBoxCash.Enabled = True
        CheckBoxOthers.Enabled = True

        LabelFinanceDeptApp.Text = "Pending"
        LabelFinanceDeptComment.Text = ""
        LabelFinanceDeptComment.Visible = False

        txtboxFinanceDept.Visible = True
        txtboxFinanceDept.Text = ""
        LabelDateFinanceDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""
        txtboxOther.BackColor = SystemColors.Window
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnFinanceDeptApp.Visible = True
        btnFinanceDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxCash.Checked = False
        CheckBoxOthers.Checked = False
        CheckBoxCash.Enabled = True
        CheckBoxOthers.Enabled = True

        LabelFinanceDeptApp.Text = "Pending"
        LabelFinanceDeptComment.Text = ""
        LabelDateFinanceDept.Text = ""
        LabelFinanceDeptComment.Visible = False

        txtboxFinanceDept.Visible = True
        txtboxFinanceDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""
        txtboxOther.BackColor = SystemColors.Window
        Me.Close()
    End Sub


    '    Public Function verfGroupIfComplete() As Boolean
    '        Dim query = "SELECT `empID`, `BDG`, `SDG`, `ITOPS`, `PMG`, `MARKETING`, `FINANCE`, `SDGHead`, `FinanceHead`
    'FROM `checkergroup` 
    'WHERE `empID`='" & LabelEmpID.Text & "'
    'AND `BDG` IS NOT NULL 
    'AND `SDG` IS NOT NULL 
    'AND `ITOPS` IS NOT NULL 
    'AND `PMG` IS NOT NULL 
    'AND `MARKETING` IS NOT NULL 
    'AND `FINANCE` IS NOT NULL 
    'AND `SDGHead` IS NOT NULL 
    'AND `FinanceHead` IS NOT NULL "
    '        Dim command As New MySqlCommand(query, dbs.getconn)
    '        dbs.opencon()

    '        Dim scalarResult As Object = command.ExecuteScalar()
    '        If scalarResult IsNot Nothing Then
    '            Return True

    '            ' ...
    '        Else
    '            ' ... handle the case where scalarResult is null ...
    '            Return False

    '        End If

    '    End Function

    '    Private Function verfFINANCEIfEmpty() As Boolean
    '        Dim query As String
    '        query = "select FINANCE from checkergroup where empID='" & LabelEmpID.Text & "'"
    '        Dim command As New MySqlCommand(query, dbs.getconn)
    '        adapter.SelectCommand = command
    '        adapter.Fill(table)

    '        If table.Rows.Count = 0 Then
    '            Return False
    '            Exit Function
    '        Else
    '            Return True
    '            Exit Function
    '        End If
    '    End Function

    Private Sub ViewFinance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        btnFinanceDeptApp.Visible = True
        btnFinanceDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        CheckBoxCash.Checked = False
        CheckBoxOthers.Checked = False
        CheckBoxCash.Enabled = True
        CheckBoxOthers.Enabled = True
        CheckBoxCash.BackColor = Color.Gray
        CheckBoxOthers.BackColor = Color.Gray

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        LabelFinanceDeptApp.Text = "Pending"
        LabelFinanceDeptComment.Text = ""
        LabelDateFinanceDept.Text = ""
        LabelFinanceDeptComment.Visible = False

        txtboxFinanceDept.Visible = True
        txtboxFinanceDept.Text = ""
        txtboxOther.Enabled = False
        txtboxOther.Text = ""
        txtboxOther.BackColor = SystemColors.Window

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
        txtboxOther.BackColor = SystemColors.Window
    End Sub







End Class