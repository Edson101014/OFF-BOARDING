Imports MySql.Data.MySqlClient
Public Class ViewSDGSuper
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    'Dim adapter As New MySqlDataAdapter
    'Dim table As New DataTable

    Dim inserthistory As String
    Dim insertDeptHead As String
    'Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    'Dim insertchecker As String
    'Dim check As Integer

    Dim SDGSuperNameAccept As String
    Dim SDGSuperStatAccept As String
    Dim SDGSuperCommentAccept As String
    Dim SDGSuperDateAccept As String

    'ACCEPT
    Private Sub btnSDGSuperApp_Click(sender As Object, e As EventArgs) Handles btnSDGSuperApp.Click
        SDGSuperStatAccept = "Approve"

        SDGSuperNameAccept = LabelSDGSuperName.Text

        SDGSuperCommentAccept = txtboxSDGSuper.Text

        SDGSuperDateAccept = Date.Today

        LabelSDGSuperApp.Text = SDGSuperStatAccept

        LabelDateSDGSuper.Text = SDGSuperDateAccept

        LabelSDGSuperComment.Text = txtboxSDGSuper.Text

        statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `sdgsuperhistory` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperDate`,  `SDGSuperComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday,@name, @status, @dateapp, @comment)"
        insertDeptHead = "INSERT INTO `sdgdepthead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptStatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, inserthistory)

        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertDeptHead)

        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)



        'If verfSDGHeadIfEmpty = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `sdghead`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If





        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnSDGSuperApp.Visible = False
        btnSDGSuperReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGSuperComment.Visible = True

        txtboxSDGSuper.Visible = False
        txtboxSDGSuper.Text = ""

    End Sub

    'END OF ACCEPT




    'REJECT
    Private Sub btnSDGSuperReject_Click(sender As Object, e As EventArgs) Handles btnSDGSuperReject.Click
        SDGSuperStatAccept = "Reject"

        SDGSuperNameAccept = LabelSDGSuperName.Text

        SDGSuperCommentAccept = txtboxSDGSuper.Text

        SDGSuperDateAccept = Date.Today

        LabelSDGSuperApp.Text = SDGSuperStatAccept

        LabelDateSDGSuper.Text = SDGSuperDateAccept

        LabelSDGSuperComment.Text = txtboxSDGSuper.Text

        statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `sdgsuperhistory` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperDate`,  `SDGSuperComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday,@name, @status, @dateapp, @comment)"
        insertDeptHead = "INSERT INTO `sdgdepthead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptStatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, inserthistory)

        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertDeptHead)

        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)


        'If verfSDGHeadIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `sdghead`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnSDGSuperApp.Visible = False
        btnSDGSuperReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGSuperComment.Visible = True

        txtboxSDGSuper.Visible = False
        txtboxSDGSuper.Text = ""

    End Sub


    'END OF REJECT






    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click
        SDGSuperStatAccept = "Approve"

        SDGSuperNameAccept = LabelSDGSuperName.Text

        SDGSuperCommentAccept = txtboxSDGSuper.Text

        SDGSuperDateAccept = Date.Today

        LabelSDGSuperApp.Text = SDGSuperStatAccept

        LabelDateSDGSuper.Text = SDGSuperDateAccept

        LabelSDGSuperComment.Text = txtboxSDGSuper.Text

        statusNextflow = "Pending"


        updateHistory = "UPDATE `sdgsuperhistory` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)



        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGSuperComment.Visible = True

        txtboxSDGSuper.Visible = False
        txtboxSDGSuper.Text = ""

    End Sub

    'END OF EDIT APPROVE





    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        SDGSuperStatAccept = "Reject"

        SDGSuperNameAccept = LabelSDGSuperName.Text

        SDGSuperCommentAccept = txtboxSDGSuper.Text

        SDGSuperDateAccept = Date.Today

        LabelSDGSuperApp.Text = SDGSuperStatAccept

        LabelDateSDGSuper.Text = SDGSuperDateAccept

        LabelSDGSuperComment.Text = txtboxSDGSuper.Text

        statusNextflow = "Pending"


        updateHistory = "UPDATE `sdgsuperhistory` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDate`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(SDGSuperNameAccept, SDGSuperStatAccept, SDGSuperDateAccept, SDGSuperCommentAccept, updateHistory)



        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelSDGSuperComment.Visible = True

        txtboxSDGSuper.Visible = False
        txtboxSDGSuper.Text = ""

    End Sub

    'END OF EDIT REJECT



    'Private Function verfSDGHeadIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select SDGhead from checkergroup where empID='" & LabelEmpID.Text & "'"
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

    Private Sub LabelSDGSuperApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSDGSuperApp.TextChanged
        If LabelSDGSuperApp.Text = "Pending" Then
            LabelSDGSuperApp.BackColor = Color.PowderBlue
        ElseIf LabelSDGSuperApp.Text = "Approve" Then
            LabelSDGSuperApp.BackColor = Color.Lime
        Else
            LabelSDGSuperApp.BackColor = Color.Firebrick

        End If
    End Sub



    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxSDGSuper.Visible = True
        txtboxSDGSuper.Text = LabelSDGSuperComment.Text
        LabelSDGSuperComment.Visible = False

    End Sub


    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxSDGSuper.Visible = False
        txtboxSDGSuper.Text = LabelSDGSuperComment.Text
        LabelSDGSuperComment.Visible = True

    End Sub



    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnSDGSuperApp.Visible = True
        btnSDGSuperReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSDGSuperApp.Text = "Pending"
        LabelSDGSuperComment.Text = ""
        LabelDateSDGSuper.Text = ""
        LabelSDGSuperComment.Visible = False

        txtboxSDGSuper.Visible = True
        txtboxSDGSuper.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnSDGSuperApp.Visible = True
        btnSDGSuperReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSDGSuperApp.Text = "Pending"
        LabelSDGSuperComment.Text = ""
        LabelDateSDGSuper.Text = ""
        LabelSDGSuperComment.Visible = False

        txtboxSDGSuper.Visible = True
        txtboxSDGSuper.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewSDGSuper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        btnSDGSuperApp.Visible = True
        btnSDGSuperReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        LabelSDGSuperApp.Text = "Pending"
        LabelSDGSuperComment.Text = ""
        LabelDateSDGSuper.Text = ""
        LabelSDGSuperComment.Visible = False

        txtboxSDGSuper.Visible = True
        txtboxSDGSuper.Text = ""

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