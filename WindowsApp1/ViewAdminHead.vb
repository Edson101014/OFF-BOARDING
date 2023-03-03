Imports MySql.Data.MySqlClient
Public Class ViewAdminHead
    Dim apdb As New ApprovalDB
    Dim dbs As New db


    Dim inserthistory As String
    'Dim insertNextFlow As String
    Dim updateHistory As String
    'Dim statusNextflow As String
    'Dim updatechecker As String
    'Dim check As Integer

    Dim AdminHeadNameAccept As String
    Dim AdminHeadStatAccept As String
    Dim AdminHeadCommentAccept As String
    Dim AdminHeadDateAccept As String

    'ACCEPT
    Private Sub btnAdminHeadApp_Click(sender As Object, e As EventArgs) Handles btnAdminHeadApp.Click

        AdminHeadStatAccept = "Approve"

        AdminHeadNameAccept = LabelAdminHeadName.Text

        AdminHeadCommentAccept = txtboxAdminHead.Text

        AdminHeadDateAccept = Date.Today

        LabelAdminHeadApp.Text = AdminHeadStatAccept

        LabelDateAdminHead.Text = AdminHeadDateAccept

        LabelAdminHeadComment.Text = txtboxAdminHead.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `admingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @comment, @dateapp)"
        updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"


        'updatechecker = "UPDATE `checker` SET `AdminHead`=@check WHERE empID='" & LabelEmpID.Text & "'"
        'apdb.updatechecker(check, updatechecker)


        'Dim updated As Boolean = apdb.updatechecker(check, updatechecker)
        'If updated AndAlso verfCheckerComplete() = True Then
        '    insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '    apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        'End If

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, inserthistory)
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnAdminHeadApp.Visible = False
        btnAdminHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelAdminHeadComment.Visible = True
        LabelDateAdminHead.Visible = True
        txtboxAdminHead.Visible = False
        txtboxAdminHead.Text = ""

    End Sub


    'END OF ACCEPT





    'REJECT
    Private Sub btnAdminHeadReject_Click(sender As Object, e As EventArgs) Handles btnAdminHeadReject.Click
        AdminHeadStatAccept = "Reject"

        AdminHeadNameAccept = LabelAdminHeadName.Text

        AdminHeadCommentAccept = txtboxAdminHead.Text

        AdminHeadDateAccept = Date.Today

        LabelAdminHeadApp.Text = AdminHeadStatAccept

        LabelDateAdminHead.Text = AdminHeadDateAccept

        LabelAdminHeadComment.Text = txtboxAdminHead.Text
        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `admingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDateApprove`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @comment, @dateapp)"
        updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDateApprove`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"


        'updatechecker = "UPDATE `checker` SET `AdminHead`=@check WHERE empID='" & LabelEmpID.Text & "'"
        'apdb.updatechecker(check, updatechecker)


        'Dim updated As Boolean = apdb.updatechecker(check, updatechecker)
        'If updated AndAlso verfCheckerComplete() = True Then
        '    insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '    apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        'End If


        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, inserthistory)
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnAdminHeadApp.Visible = False
        btnAdminHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelAdminHeadComment.Visible = True

        txtboxAdminHead.Visible = False
        txtboxAdminHead.Text = ""
    End Sub


    'END OF REJECT






    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click

        AdminHeadStatAccept = "Approve"

        AdminHeadNameAccept = LabelAdminHeadName.Text

        AdminHeadCommentAccept = txtboxAdminHead.Text

        AdminHeadDateAccept = Date.Today

        LabelAdminHeadApp.Text = AdminHeadStatAccept

        LabelDateAdminHead.Text = AdminHeadDateAccept

        LabelAdminHeadComment.Text = txtboxAdminHead.Text

        updateHistory = "UPDATE `admingroupheadhistory` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)


        updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)




        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelAdminHeadComment.Visible = True
        LabelDateAdminHead.Visible = True
        txtboxAdminHead.Visible = False
        txtboxAdminHead.Text = ""

    End Sub

    'END OF EDIT APPROVE






    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click

        AdminHeadStatAccept = "Reject"

        AdminHeadNameAccept = LabelAdminHeadName.Text

        AdminHeadCommentAccept = txtboxAdminHead.Text

        AdminHeadDateAccept = Date.Today

        LabelAdminHeadApp.Text = AdminHeadStatAccept

        LabelDateAdminHead.Text = AdminHeadDateAccept

        LabelAdminHeadComment.Text = txtboxAdminHead.Text


        updateHistory = "UPDATE `admingroupheadhistory` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)




        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelAdminHeadComment.Visible = True
        LabelDateAdminHead.Visible = True
        txtboxAdminHead.Visible = False
        txtboxAdminHead.Text = ""

    End Sub

    'END OF EDIT REJECT




    'Private Function verfCheckerComplete() As Boolean
    '    Dim query As String
    '    query = "SELECT `AdminHead`, `SysAdminHead` FROM `checker` WHERE `empID`='" & LabelEmpID.Text & "' AND `AdminHead` IS NOT NULL AND `SysAdminHead` IS NOT NULL"
    '    Dim command As New MySqlCommand(query, dbs.getconn)

    '    dbs.opencon()

    '    Dim scalarResult As Object = command.ExecuteScalar()
    '    Debug.WriteLine("scalarResult: " & scalarResult)
    '    If scalarResult IsNot Nothing Then
    '        Debug.WriteLine("Returning True")
    '        Return True

    '    Else
    '        Debug.WriteLine("Returning False")
    '        Return False

    '    End If
    'End Function

    Private Sub LabelAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminHeadApp.TextChanged
        If LabelAdminHeadApp.Text = "Pending" Then
            LabelAdminHeadApp.BackColor = Color.PowderBlue
        ElseIf LabelAdminHeadApp.Text = "Approve" Then
            LabelAdminHeadApp.BackColor = Color.Lime
        Else
            LabelAdminHeadApp.BackColor = Color.Firebrick

        End If
    End Sub


    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxAdminHead.Visible = True
        txtboxAdminHead.Text = LabelAdminHeadComment.Text
        LabelAdminHeadComment.Visible = False

    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxAdminHead.Visible = False
        txtboxAdminHead.Text = LabelAdminHeadComment.Text
        LabelAdminHeadComment.Visible = True

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnAdminHeadApp.Visible = True
        btnAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelAdminHeadApp.Text = "Pending"
        LabelAdminHeadComment.Text = ""
        LabelDateAdminHead.Text = ""
        LabelAdminHeadComment.Visible = False

        txtboxAdminHead.Visible = True
        txtboxAdminHead.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnAdminHeadApp.Visible = True
        btnAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelAdminHeadApp.Text = "Pending"
        LabelAdminHeadComment.Text = ""
        LabelDateAdminHead.Text = ""
        LabelAdminHeadComment.Visible = False

        txtboxAdminHead.Visible = True
        txtboxAdminHead.Text = ""
        Me.Close()
    End Sub



    Private Sub ViewAdminHead_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        btnAdminHeadApp.Visible = True
        btnAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        LabelAdminHeadApp.Text = "Pending"
        LabelAdminHeadComment.Text = ""
        LabelDateAdminHead.Text = ""
        LabelAdminHeadComment.Visible = False

        txtboxAdminHead.Visible = True
        txtboxAdminHead.Text = ""


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