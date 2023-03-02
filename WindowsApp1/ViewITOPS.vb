
Public Class ViewITOPS
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

    Dim ITOPSNameAccept As String
    Dim ITOPSStatAccept As String
    Dim ITOPSCommentAccept As String
    Dim ITOPSDateAccept As String

    'ACCEPT
    Private Sub btnITOPSDeptApp_Click(sender As Object, e As EventArgs) Handles btnITOPSDeptApp.Click
        ITOPSStatAccept = "Approve"

        ITOPSNameAccept = LabelITOPSDeptName.Text

        ITOPSCommentAccept = txtboxITOPSDept.Text

        ITOPSDateAccept = Date.Today

        LabelITOPSDeptApp.Text = ITOPSStatAccept

        LabelDateITOPSDept.Text = ITOPSDateAccept

        LabelITOPSDeptComment.Text = txtboxITOPSDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `itopsdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptDate`, `ITOPSDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, inserthistory)
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)


        'If verfITOPSIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `itops`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If




        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnITOPSDeptApp.Visible = False
        btnITOPSDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelITOPSDeptComment.Visible = True

        txtboxITOPSDept.Visible = False
        txtboxITOPSDept.Text = ""
    End Sub

    'END OF ACCEPT






    'REJECT

    Private Sub btnITOPSDeptReject_Click(sender As Object, e As EventArgs) Handles btnITOPSDeptReject.Click
        ITOPSStatAccept = "Reject"

        ITOPSNameAccept = LabelITOPSDeptName.Text

        ITOPSCommentAccept = txtboxITOPSDept.Text

        ITOPSDateAccept = Date.Today

        LabelITOPSDeptApp.Text = ITOPSStatAccept

        LabelDateITOPSDept.Text = ITOPSDateAccept

        LabelITOPSDeptComment.Text = txtboxITOPSDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `itopsdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptDate`, `ITOPSDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, inserthistory)
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)


        'If verfITOPSIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `itops`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnITOPSDeptApp.Visible = False
        btnITOPSDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelITOPSDeptComment.Visible = True

        txtboxITOPSDept.Visible = False
        txtboxITOPSDept.Text = ""
    End Sub



    'END OF REJECT




    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click
        ITOPSStatAccept = "Approve"

        ITOPSNameAccept = LabelITOPSDeptName.Text

        ITOPSCommentAccept = txtboxITOPSDept.Text

        ITOPSDateAccept = Date.Today

        LabelITOPSDeptApp.Text = ITOPSStatAccept

        LabelDateITOPSDept.Text = ITOPSDateAccept

        LabelITOPSDeptComment.Text = txtboxITOPSDept.Text


        updateHistory = "UPDATE `itopsdepthistory` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)



        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelITOPSDeptComment.Visible = True

        txtboxITOPSDept.Visible = False
        txtboxITOPSDept.Text = ""

    End Sub

    'END OF EDIT APPROVE






    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        ITOPSStatAccept = "Reject"

        ITOPSNameAccept = LabelITOPSDeptName.Text

        ITOPSCommentAccept = txtboxITOPSDept.Text

        ITOPSDateAccept = Date.Today

        LabelITOPSDeptApp.Text = ITOPSStatAccept

        LabelDateITOPSDept.Text = ITOPSDateAccept

        LabelITOPSDeptComment.Text = txtboxITOPSDept.Text

        updateHistory = "UPDATE `itopsdepthistory` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDate`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)




        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelITOPSDeptComment.Visible = True

        txtboxITOPSDept.Visible = False
        txtboxITOPSDept.Text = ""

    End Sub

    'END OF EDIT REJECT



    'Private Function verfITOPSIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select ITOPS from checkergroup where empID='" & LabelEmpID.Text & "'"
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

    Private Sub LabelITOPSDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelITOPSDeptApp.TextChanged
        If LabelITOPSDeptApp.Text = "Pending" Then
            LabelITOPSDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelITOPSDeptApp.Text = "Approve" Then
            LabelITOPSDeptApp.BackColor = Color.Lime
        Else
            LabelITOPSDeptApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxITOPSDept.Visible = True
        txtboxITOPSDept.Text = LabelITOPSDeptComment.Text
        LabelITOPSDeptComment.Visible = False

    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxITOPSDept.Visible = False
        txtboxITOPSDept.Text = LabelITOPSDeptComment.Text
        LabelITOPSDeptComment.Visible = True

    End Sub



    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnITOPSDeptApp.Visible = True
        btnITOPSDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelITOPSDeptApp.Text = "Pending"
        LabelITOPSDeptComment.Text = ""
        LabelDateITOPSDept.Text = ""
        LabelITOPSDeptComment.Visible = False

        txtboxITOPSDept.Visible = True
        txtboxITOPSDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnITOPSDeptApp.Visible = True
        btnITOPSDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelITOPSDeptApp.Text = "Pending"
        LabelITOPSDeptComment.Text = ""
        LabelDateITOPSDept.Text = ""
        LabelITOPSDeptComment.Visible = False

        txtboxITOPSDept.Visible = True
        txtboxITOPSDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewITOPS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnITOPSDeptApp.Visible = True
        btnITOPSDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False


        LabelITOPSDeptApp.Text = "Pending"
        LabelITOPSDeptComment.Text = ""
        LabelDateITOPSDept.Text = ""
        LabelITOPSDeptComment.Visible = False

        txtboxITOPSDept.Visible = True
        txtboxITOPSDept.Text = ""

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