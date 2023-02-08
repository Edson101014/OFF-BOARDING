Imports MySql.Data.MySqlClient
Public Class ViewSysAdminHead
    Dim apdb As New ApprovalDB
    'Dim dbs As New db


    Dim inserthistory As String
    'Dim insertNextFlow As String
    Dim updateHistory As String
    'Dim statusNextflow As String

    'Dim updatechecker As String
    'Dim check As Integer

    Dim SysAdminHeadNameAccept As String
    Dim SysAdminHeadStatAccept As String
    Dim SysAdminHeadCommentAccept As String
    Dim SysAdminHeadDateAccept As String


    'ACCEPT
    Private Sub btnSysAdminHeadApp_Click(sender As Object, e As EventArgs) Handles btnSysAdminHeadApp.Click
        SysAdminHeadStatAccept = "Approve"

        SysAdminHeadNameAccept = LabelSysAdminHeadName.Text

        SysAdminHeadCommentAccept = txtboxSysAdminHead.Text

        SysAdminHeadDateAccept = Date.Today

        LabelSysAdminHeadApp.Text = SysAdminHeadStatAccept

        LabelDateSysAdminHead.Text = SysAdminHeadDateAccept

        LabelSysAdminHeadComment.Text = txtboxSysAdminHead.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `Sysadmingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @comment, @dateapp)"
        updateHistory = "UPDATE `historyrequest` SET `SysAdminHeadName`=@name, `SysAdminHeadStatus`=@status, `SysAdminHeadComment`=@comment, `SysAdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"


        'updatechecker = "UPDATE `checker` SET `SysAdminHead`=@check WHERE empID='" & LabelEmpID.Text & "'"
        'apdb.updatechecker(check, updatechecker)


        'Dim updated As Boolean = apdb.updatechecker(check, updatechecker)
        'If updated AndAlso verfCheckerComplete() = True Then

        '    insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '    apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        'End If


        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, inserthistory)
        apdb.updateHistory(SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, updateHistory)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnSysAdminHeadApp.Visible = False
        btnSysAdminHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSysAdminHeadComment.Visible = True

        txtboxSysAdminHead.Visible = False
        txtboxSysAdminHead.Text = ""

    End Sub


    'END OF ACCEPT





    'REJECT
    Private Sub btnSysAdminHeadReject_Click(sender As Object, e As EventArgs) Handles btnSysAdminHeadReject.Click
        SysAdminHeadStatAccept = "Reject"

        SysAdminHeadNameAccept = LabelSysAdminHeadName.Text

        SysAdminHeadCommentAccept = txtboxSysAdminHead.Text

        SysAdminHeadDateAccept = Date.Today

        LabelSysAdminHeadApp.Text = SysAdminHeadStatAccept

        LabelDateSysAdminHead.Text = SysAdminHeadDateAccept

        LabelSysAdminHeadComment.Text = txtboxSysAdminHead.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `Sysadmingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @comment, @dateapp)"
        updateHistory = "UPDATE `historyrequest` SET `SysAdminHeadName`=@name, `SysAdminHeadStatus`=@status, `SysAdminHeadComment`=@comment, `SysAdminHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"


        'updatechecker = "UPDATE `checker` SET `SysAdminHead`=@check WHERE empID='" & LabelEmpID.Text & "'"
        'apdb.updatechecker(check, updatechecker)


        'Dim updated As Boolean = apdb.updatechecker(check, updatechecker)
        'If updated AndAlso verfCheckerComplete() = True Then

        '    insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '    apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        'End If


        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, inserthistory)
        apdb.updateHistory(SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, updateHistory)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnSysAdminHeadApp.Visible = False
        btnSysAdminHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelSysAdminHeadComment.Visible = True

        txtboxSysAdminHead.Visible = False
        txtboxSysAdminHead.Text = ""

    End Sub



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


    Private Sub LabelSysAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminHeadApp.TextChanged
        If LabelSysAdminHeadApp.Text = "Pending" Then
            LabelSysAdminHeadApp.BackColor = Color.PowderBlue
        ElseIf LabelSysAdminHeadApp.Text = "Approve" Then
            LabelSysAdminHeadApp.BackColor = Color.Lime
        Else
            LabelSysAdminHeadApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        btnSysAdminHeadApp.Visible = True
        btnSysAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSysAdminHeadApp.Text = "Pending"
        LabelSysAdminHeadComment.Text = ""
        LabelDateSysAdminHead.Text = ""
        LabelSysAdminHeadComment.Visible = False

        txtboxSysAdminHead.Visible = True
        txtboxSysAdminHead.Text = ""
        Me.Close()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        btnSysAdminHeadApp.Visible = True
        btnSysAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSysAdminHeadApp.Text = "Pending"
        LabelSysAdminHeadComment.Text = ""
        LabelDateSysAdminHead.Text = ""
        LabelSysAdminHeadComment.Visible = False

        txtboxSysAdminHead.Visible = True
        txtboxSysAdminHead.Text = ""
        Me.Close()

    End Sub

    Private Sub ViewSysAdminHead_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        btnSysAdminHeadApp.Visible = True
        btnSysAdminHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelSysAdminHeadApp.Text = "Pending"
        LabelSysAdminHeadComment.Text = ""
        LabelDateSysAdminHead.Text = ""
        LabelSysAdminHeadComment.Visible = False

        txtboxSysAdminHead.Visible = True
        txtboxSysAdminHead.Text = ""


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