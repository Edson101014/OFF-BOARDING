
Public Class ViewMarketing
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    'Dim adapter As New MySqlDataAdapter
    'Dim table As New DataTable

    Dim inserthistory As String
    'Dim insertNextFlow As String
    Dim updateHistory As String
    'Dim statusNextflow As String
    'Dim insertchecker As String
    'Dim check As Integer

    Dim MarketingNameAccept As String
    Dim MarketingStatAccept As String
    Dim MarketingCommentAccept As String
    Dim MarketingDateAccept As String

    'ACCEPT
    Private Sub btnMarketingDeptApp_Click(sender As Object, e As EventArgs) Handles btnMarketingDeptApp.Click
        MarketingStatAccept = "Approve"

        MarketingNameAccept = LabelMarketingName.Text

        MarketingCommentAccept = txtboxMarketingDept.Text

        MarketingDateAccept = Date.Today

        LabelMarketingDeptApp.Text = MarketingStatAccept

        LabelDateMarketingDept.Text = MarketingDateAccept

        LabelMarketingDeptComment.Text = txtboxMarketingDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `marketingdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `marketingDeptName`, `marketingDeptStatus`, `marketingDeptDate`, `marketingDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, inserthistory)
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)


        'If verfMARKETINGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `Marketing`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If





        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnMarketingDeptApp.Visible = False
        btnMarketingDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelMarketingDeptComment.Visible = True

        txtboxMarketingDept.Visible = False
        txtboxMarketingDept.Text = ""

    End Sub

    'END OF ACCEPT





    'REJECT

    Private Sub btnMarketingDeptReject_Click(sender As Object, e As EventArgs) Handles btnMarketingDeptReject.Click
        MarketingStatAccept = "REJECT"

        MarketingNameAccept = LabelMarketingName.Text

        MarketingCommentAccept = txtboxMarketingDept.Text

        MarketingDateAccept = Date.Today

        LabelMarketingDeptApp.Text = MarketingStatAccept

        LabelDateMarketingDept.Text = MarketingDateAccept

        LabelMarketingDeptComment.Text = txtboxMarketingDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `marketingdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `marketingDeptName`, `marketingDeptStatus`, `marketingDeptDate`, `marketingDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, inserthistory)
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)


        'If verfMARKETINGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `Marketing`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnMarketingDeptApp.Visible = False
        btnMarketingDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelMarketingDeptComment.Visible = True

        txtboxMarketingDept.Visible = False
        txtboxMarketingDept.Text = ""
    End Sub

    'END OF REJECT




    'EDIT APPROVE

    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click
        MarketingStatAccept = "Approve"

        MarketingNameAccept = LabelMarketingName.Text

        MarketingCommentAccept = txtboxMarketingDept.Text

        MarketingDateAccept = Date.Today

        LabelMarketingDeptApp.Text = MarketingStatAccept

        LabelDateMarketingDept.Text = MarketingDateAccept

        LabelMarketingDeptComment.Text = txtboxMarketingDept.Text


        updateHistory = "UPDATE `marketingdepthistory` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)


        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelMarketingDeptComment.Visible = True

        txtboxMarketingDept.Visible = False
        txtboxMarketingDept.Text = ""

    End Sub


    'END OF EDIT APPROVE



    'EDIT REJECT

    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        MarketingStatAccept = "Reject"

        MarketingNameAccept = LabelMarketingName.Text

        MarketingCommentAccept = txtboxMarketingDept.Text

        MarketingDateAccept = Date.Today

        LabelMarketingDeptApp.Text = MarketingStatAccept

        LabelDateMarketingDept.Text = MarketingDateAccept

        LabelMarketingDeptComment.Text = txtboxMarketingDept.Text


        updateHistory = "UPDATE `marketingdepthistory` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDate`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)


        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelMarketingDeptComment.Visible = True

        txtboxMarketingDept.Visible = False
        txtboxMarketingDept.Text = ""

    End Sub

    'END OF EDIT REJECT








    'Private Function verfMARKETINGIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select MARKETING from checkergroup where empID='" & LabelEmpID.Text & "'"
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


    Private Sub LabelMarketingDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelMarketingDeptApp.TextChanged

        If LabelMarketingDeptApp.Text = "Pending" Then
            LabelMarketingDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelMarketingDeptApp.Text = "Approve" Then
            LabelMarketingDeptApp.BackColor = Color.Lime
        Else
            LabelMarketingDeptApp.BackColor = Color.Firebrick

        End If

    End Sub


    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxMarketingDept.Visible = True
        txtboxMarketingDept.Text = LabelMarketingDeptComment.Text
        LabelMarketingDeptComment.Visible = False

    End Sub


    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxMarketingDept.Visible = False
        txtboxMarketingDept.Text = LabelMarketingDeptComment.Text
        LabelMarketingDeptComment.Visible = True

    End Sub


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnMarketingDeptApp.Visible = True
        btnMarketingDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelMarketingDeptApp.Text = "Pending"
        LabelMarketingDeptComment.Text = ""
        LabelDateMarketingDept.Text = ""
        LabelMarketingDeptComment.Visible = False

        txtboxMarketingDept.Visible = True
        txtboxMarketingDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnMarketingDeptApp.Visible = True
        btnMarketingDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelMarketingDeptApp.Text = "Pending"
        LabelMarketingDeptComment.Text = ""
        LabelDateMarketingDept.Text = ""
        LabelMarketingDeptComment.Visible = False

        txtboxMarketingDept.Visible = True
        txtboxMarketingDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewMarketing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        btnMarketingDeptApp.Visible = True
        btnMarketingDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        LabelMarketingDeptApp.Text = "Pending"
        LabelMarketingDeptComment.Text = ""
        LabelDateMarketingDept.Text = ""
        LabelMarketingDeptComment.Visible = False

        txtboxMarketingDept.Visible = True
        txtboxMarketingDept.Text = ""

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