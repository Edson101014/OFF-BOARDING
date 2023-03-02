
Public Class ViewPMG
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

    Dim PMGNameAccept As String
    Dim PMGStatAccept As String
    Dim PMGCommentAccept As String
    Dim PMGDateAccept As String


    'ACCEPT
    Private Sub btnPMGDeptApp_Click(sender As Object, e As EventArgs) Handles btnPMGDeptApp.Click
        PMGStatAccept = "Approve"

        PMGNameAccept = LabelPMGName.Text

        PMGCommentAccept = txtboxPMGDept.Text

        PMGDateAccept = Date.Today

        LabelPMGDeptApp.Text = PMGStatAccept

        LabelDatePMGDept.Text = PMGDateAccept

        LabelPMGDeptComment.Text = txtboxPMGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `pmgdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptDate`, `PMGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, inserthistory)
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)


        'If verfPMGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `pmg`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If





        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnPMGDeptApp.Visible = False
        btnPMGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelPMGDeptComment.Visible = True

        txtboxPMGDept.Visible = False
        txtboxPMGDept.Text = ""
    End Sub

    'END OF ACCEPT





    'REJECT

    Private Sub btnPMGDeptReject_Click(sender As Object, e As EventArgs) Handles btnPMGDeptReject.Click
        PMGStatAccept = "Reject"

        PMGNameAccept = LabelPMGName.Text

        PMGCommentAccept = txtboxPMGDept.Text

        PMGDateAccept = Date.Today

        LabelPMGDeptApp.Text = PMGStatAccept

        LabelDatePMGDept.Text = PMGDateAccept

        LabelPMGDeptComment.Text = txtboxPMGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `pmgdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptDate`, `PMGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, inserthistory)
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)


        'If verfPMGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `pmg`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnPMGDeptApp.Visible = False
        btnPMGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelPMGDeptComment.Visible = True

        txtboxPMGDept.Visible = False
        txtboxPMGDept.Text = ""
    End Sub



    'END OF REJECT





    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click
        PMGStatAccept = "Approve"

        PMGNameAccept = LabelPMGName.Text

        PMGCommentAccept = txtboxPMGDept.Text

        PMGDateAccept = Date.Today

        LabelPMGDeptApp.Text = PMGStatAccept

        LabelDatePMGDept.Text = PMGDateAccept

        LabelPMGDeptComment.Text = txtboxPMGDept.Text


        updateHistory = "UPDATE `pmgdepthistory` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)



        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelPMGDeptComment.Visible = True

        txtboxPMGDept.Visible = False
        txtboxPMGDept.Text = ""

    End Sub


    'END OF EDIT APPROVE



    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        PMGStatAccept = "Reject"

        PMGNameAccept = LabelPMGName.Text

        PMGCommentAccept = txtboxPMGDept.Text

        PMGDateAccept = Date.Today

        LabelPMGDeptApp.Text = PMGStatAccept

        LabelDatePMGDept.Text = PMGDateAccept

        LabelPMGDeptComment.Text = txtboxPMGDept.Text


        updateHistory = "UPDATE `pmgdepthistory` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDate`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)




        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelPMGDeptComment.Visible = True

        txtboxPMGDept.Visible = False
        txtboxPMGDept.Text = ""

    End Sub

    'END OF EDIT REJECT


    'Private Function verfPMGIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select PMG from checkergroup where empID='" & LabelEmpID.Text & "'"
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


    Private Sub LabelPMGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelPMGDeptApp.TextChanged
        If LabelPMGDeptApp.Text = "Pending" Then
            LabelPMGDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelPMGDeptApp.Text = "Approve" Then
            LabelPMGDeptApp.BackColor = Color.Lime
        Else
            LabelPMGDeptApp.BackColor = Color.Firebrick

        End If
    End Sub


    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxPMGDept.Visible = True
        txtboxPMGDept.Text = LabelPMGDeptComment.Text
        LabelPMGDeptComment.Visible = False

    End Sub


    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxPMGDept.Visible = False
        txtboxPMGDept.Text = LabelPMGDeptComment.Text
        LabelPMGDeptComment.Visible = True


    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnPMGDeptApp.Visible = True
        btnPMGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelPMGDeptApp.Text = "Pending"
        LabelPMGDeptComment.Text = ""
        LabelDatePMGDept.Text = ""
        LabelPMGDeptComment.Visible = False

        txtboxPMGDept.Visible = True
        txtboxPMGDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnPMGDeptApp.Visible = True
        btnPMGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelPMGDeptApp.Text = "Pending"
        LabelPMGDeptComment.Text = ""
        LabelDatePMGDept.Text = ""
        LabelPMGDeptComment.Visible = False

        txtboxPMGDept.Visible = True
        txtboxPMGDept.Text = ""
        Me.Close()

    End Sub

    Private Sub ViewPMG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        btnPMGDeptApp.Visible = True
        btnPMGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False


        LabelPMGDeptApp.Text = "Pending"
        LabelPMGDeptComment.Text = ""
        LabelDatePMGDept.Text = ""
        LabelPMGDeptComment.Visible = False

        txtboxPMGDept.Visible = True
        txtboxPMGDept.Text = ""

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