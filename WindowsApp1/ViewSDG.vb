Imports MySql.Data.MySqlClient
Public Class ViewSDG
    Dim apdb As New ApprovalDB
    'Dim dbs As New db
    'Dim adapter As New MySqlDataAdapter
    'Dim table As New DataTable

    Dim inserthistory As String
    'Dim insertNextFlow As String
    Dim updateHistory As String
    'Dim statusNextflow As String
    'Dim insertchecker As String
    'Dim check As Integer

    Dim SDGNameAccept As String
    Dim SDGStatAccept As String
    Dim SDGCommentAccept As String
    Dim SDGDateAccept As Date


    'ACCEPT
    Private Sub btnSDGDeptApp_Click(sender As Object, e As EventArgs) Handles btnSDGDeptApp.Click
        SDGStatAccept = "Approve"

        SDGNameAccept = LabelSDGDeptName.Text

        SDGCommentAccept = txtboxSDGDept.Text

        SDGDateAccept = Date.Today

        LabelSDGDeptApp.Text = SDGStatAccept

        LabelDateSDGDept.Text = SDGDateAccept

        LabelSDGDeptComment.Text = txtboxSDGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `SDGdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptDate`, `SDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, inserthistory)
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)


        'If verfSDGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `sdg`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If



        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnSDGDeptApp.Visible = False
        btnSDGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGDeptComment.Visible = True


        txtboxSDGDept.Visible = False
        txtboxSDGDept.Text = ""
    End Sub

    'END OF  ACCEPT




    'REJECT
    Private Sub btnSDGDeptReject_Click(sender As Object, e As EventArgs) Handles btnSDGDeptReject.Click
        SDGStatAccept = "Reject"

        SDGNameAccept = LabelSDGDeptName.Text

        SDGCommentAccept = txtboxSDGDept.Text

        SDGDateAccept = Date.Today

        LabelSDGDeptApp.Text = SDGStatAccept

        LabelDateSDGDept.Text = SDGDateAccept

        LabelSDGDeptComment.Text = txtboxSDGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `SDGdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptDate`, `SDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, inserthistory)
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)


        'If verfSDGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `sdg`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnSDGDeptApp.Visible = False
        btnSDGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGDeptComment.Visible = True


        txtboxSDGDept.Visible = False
        txtboxSDGDept.Text = ""
    End Sub

    'END OF REJECT




    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click
        SDGStatAccept = "Approve"

        SDGNameAccept = LabelSDGDeptName.Text

        SDGCommentAccept = txtboxSDGDept.Text

        SDGDateAccept = Date.Today

        LabelSDGDeptApp.Text = SDGStatAccept

        LabelDateSDGDept.Text = SDGDateAccept

        LabelSDGDeptComment.Text = txtboxSDGDept.Text


        updateHistory = "UPDATE `sdgdepthistory` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGDeptComment.Visible = True

        txtboxSDGDept.Visible = False
        txtboxsDGDept.Text = ""

    End Sub


    'END OF EDIT APPROVE



    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        SDGStatAccept = "Reject"

        SDGNameAccept = LabelSDGDeptName.Text

        SDGCommentAccept = txtboxSDGDept.Text

        SDGDateAccept = Date.Today

        LabelSDGDeptApp.Text = SDGStatAccept

        LabelDateSDGDept.Text = SDGDateAccept

        LabelSDGDeptComment.Text = txtboxSDGDept.Text


        updateHistory = "UPDATE `sdgdepthistory` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDate`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGDeptComment.Visible = True

        txtboxSDGDept.Visible = False
        txtboxSDGDept.Text = ""

    End Sub

    'END OF EDIT REJECT



    'Private Function verfSDGIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select SDG from checkergroup where empID='" & LabelEmpID.Text & "'"
    '    Dim command As New MySqlCommand(query, dbs.getconn)
    '    adapter.SelectCommand = command
    '    adapter.Fill(table)

    '    If table.Rows.Count = 0 Then
    '        Return False
    '        Exit Function
    '    Else
    '        Return True
    '        Exit Function
    '    End If
    'End Function

    '    Private Function verfGroupIfComplete() As Boolean
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

    Private Sub LabelSDGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSDGDeptApp.TextChanged
        If LabelSDGDeptApp.Text = "Pending" Then
            LabelSDGDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelSDGDeptApp.Text = "Approve" Then
            LabelSDGDeptApp.BackColor = Color.Lime
        Else
            LabelSDGDeptApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxSDGDept.Visible = True
        txtboxSDGDept.Text = LabelSDGDeptComment.Text
        LabelSDGDeptComment.Visible = False

    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxSDGDept.Visible = False
        txtboxSDGDept.Text = LabelSDGDeptComment.Text
        LabelSDGDeptComment.Visible = True

    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnSDGDeptApp.Visible = True
        btnSDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSDGDeptApp.Text = "Pending"
        LabelSDGDeptComment.Text = ""
        LabelDateSDGDept.Text = ""
        LabelSDGDeptComment.Visible = False


        txtboxSDGDept.Visible = True
        txtboxSDGDept.Text = ""
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnSDGDeptApp.Visible = True
        btnSDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSDGDeptApp.Text = "Pending"
        LabelSDGDeptComment.Text = ""
        LabelDateSDGDept.Text = ""
        LabelSDGDeptComment.Visible = False


        txtboxSDGDept.Visible = True
        txtboxSDGDept.Text = ""
        Me.Close()

    End Sub

    Private Sub ViewSDG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnSDGDeptApp.Visible = True
        btnSDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSDGDeptApp.Text = "Pending"
        LabelSDGDeptComment.Text = ""
        LabelDateSDGDept.Text = ""
        LabelSDGDeptComment.Visible = False


        txtboxSDGDept.Visible = True
        txtboxSDGDept.Text = ""

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