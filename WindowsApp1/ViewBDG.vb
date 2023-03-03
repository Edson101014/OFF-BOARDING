Imports MySql.Data.MySqlClient
Public Class ViewBDG
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

    Dim BDGStatAccept As String
    Dim BDGNameAccept As String
    Dim BDGCommentAccept As String
    Dim BDGDateAccept As Date



    'ACCEPT
    Private Sub btnBDGDeptApp_Click(sender As Object, e As EventArgs) Handles btnBDGDeptApp.Click

        BDGStatAccept = "Approve"

        BDGNameAccept = LabelBDGName.Text

        BDGCommentAccept = txtboxBDGDept.Text

        BDGDateAccept = Date.Today

        LabelBDGDeptApp.Text = BDGStatAccept

        LabelDateBDGDept.Text = BDGDateAccept

        LabelBDGDeptComment.Text = txtboxBDGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `bdgdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptDate`, `BDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, inserthistory)
        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)


        ''If verfBDGIfEmpty() = True Then
        ''    insertchecker = "UPDATE `checkergroup` SET `BDG`=@check WHERE empid='" & LabelEmpID.Text & "'"
        ''    apdb.updatechecker(check, insertchecker)

        ''Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        ''    If updated AndAlso verfGroupIfComplete() = True Then
        'insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        'apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        ''    End If
        ''End If


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnBDGDeptApp.Visible = False
        btnBDGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelBDGDeptComment.Visible = True

        txtboxBDGDept.Visible = False
        txtboxBDGDept.Text = ""
    End Sub

    'END OF ACCEPT





    'REJECT

    Private Sub btnBDGDeptReject_Click(sender As Object, e As EventArgs) Handles btnBDGDeptReject.Click
        BDGStatAccept = "Reject"

        BDGNameAccept = LabelBDGName.Text

        BDGCommentAccept = txtboxBDGDept.Text

        BDGDateAccept = Date.Today

        LabelBDGDeptApp.Text = BDGStatAccept

        LabelDateBDGDept.Text = BDGDateAccept

        LabelBDGDeptComment.Text = txtboxBDGDept.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `bdgdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptDate`, `BDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, inserthistory)
        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)


        'If verfBDGIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `BDG`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)


        btnBDGDeptApp.Visible = False
        btnBDGDeptReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelBDGDeptComment.Visible = True

        txtboxBDGDept.Visible = False
        txtboxBDGDept.Text = ""

    End Sub

    'END OF REJECT






    'EDIT APPROVE

    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click

        BDGStatAccept = "Approve"

        BDGNameAccept = LabelBDGName.Text

        BDGCommentAccept = txtboxBDGDept.Text

        BDGDateAccept = Date.Today

        LabelBDGDeptApp.Text = BDGStatAccept

        LabelDateBDGDept.Text = BDGDateAccept

        LabelBDGDeptComment.Text = txtboxBDGDept.Text

        updateHistory = "UPDATE `bdgdepthistory` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)


        updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)

        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelBDGDeptComment.Visible = True

        txtboxBDGDept.Visible = False
        txtboxBDGDept.Text = ""

    End Sub

    'END OF EDIT APPROVE




    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click
        BDGStatAccept = "Reject"

        BDGNameAccept = LabelBDGName.Text

        BDGCommentAccept = txtboxBDGDept.Text

        BDGDateAccept = Date.Today

        LabelBDGDeptApp.Text = BDGStatAccept

        LabelDateBDGDept.Text = BDGDateAccept

        LabelBDGDeptComment.Text = txtboxBDGDept.Text

        updateHistory = "UPDATE `bdgdepthistory` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)

        updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDate`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

        apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)



        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        LabelBDGDeptComment.Visible = True

        txtboxBDGDept.Visible = False
        txtboxBDGDept.Text = ""

    End Sub

    'END OF EDIT REJECT



    'Private Function verfBDGIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select BDG from checkergroup where empID='" & LabelEmpID.Text & "'"
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

    '        Else
    '            Return False

    '        End If

    '    End Function

    Private Sub LabelBDGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelBDGDeptApp.TextChanged
        If LabelBDGDeptApp.Text = "Pending" Then
            LabelBDGDeptApp.BackColor = Color.PowderBlue
        ElseIf LabelBDGDeptApp.Text = "Approve" Then
            LabelBDGDeptApp.BackColor = Color.Lime
        Else
            LabelBDGDeptApp.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        txtboxBDGDept.Visible = True
        txtboxBDGDept.Text = LabelBDGDeptComment.Text
        LabelBDGDeptComment.Visible = False

    End Sub

    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click


        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        txtboxBDGDept.Visible = False
        txtboxBDGDept.Text = LabelBDGDeptComment.Text
        LabelBDGDeptComment.Visible = True

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnBDGDeptApp.Visible = True
        btnBDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelBDGDeptApp.Text = "Pending"
        LabelBDGDeptComment.Text = ""
        LabelDateBDGDept.Text = ""
        LabelBDGDeptComment.Visible = False


        txtboxBDGDept.Visible = True
        txtboxBDGDept.Text = ""
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnBDGDeptApp.Visible = True
        btnBDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelBDGDeptApp.Text = "Pending"
        LabelBDGDeptComment.Text = ""
        LabelDateBDGDept.Text = ""
        LabelBDGDeptComment.Visible = False

        txtboxBDGDept.Visible = True
        txtboxBDGDept.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewBDG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        btnBDGDeptApp.Visible = True
        btnBDGDeptReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        LabelBDGDeptApp.Text = "Pending"
        LabelBDGDeptComment.Text = ""
        LabelDateBDGDept.Text = ""
        LabelBDGDeptComment.Visible = False

        txtboxBDGDept.Visible = True
        txtboxBDGDept.Text = ""

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