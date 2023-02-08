Imports MySql.Data.MySqlClient
Public Class ViewFinanceHead
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

    Dim FinanceHeadNameAccept As String
    Dim FinanceHeadStatAccept As String
    Dim FinanceHeadCommentAccept As String
    Dim FinanceHeadDateAccept As String



    'ACCEPT
    Private Sub btnFinanceHeadApp_Click(sender As Object, e As EventArgs) Handles btnFinanceHeadApp.Click
        FinanceHeadStatAccept = "Approve"

        FinanceHeadNameAccept = LabelFinanceHeadName.Text

        FinanceHeadCommentAccept = txtboxFinanceHead.Text

        FinanceHeadDateAccept = Date.Today

        LabelFinanceHeadApp.Text = FinanceHeadStatAccept

        LabelDateFinanceHead.Text = FinanceHeadDateAccept

        LabelFinanceHeadComment.Text = txtboxFinanceHead.Text

        statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `financeheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadDate`, `FINANCEHeadComment` ) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `FINANCEHEADName`=@name,`FINANCEHEADStatus`=@status,`FINANCEHEADDate`=@dateapp, `FINANCEHEADComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        insertNextFlow = "INSERT INTO `Financedepthead` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, financedeptStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, inserthistory)

        apdb.updateHistory(FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, updateHistory)

        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)


        'If verfFinanceHeadIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `Financehead`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If





        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnFinanceHeadApp.Visible = False
        btnFinanceHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelFinanceHeadComment.Visible = True

        txtboxFinanceHead.Visible = False
        txtboxFinanceHead.Text = ""
    End Sub

    'END OF ACCEPT






    'REJECT



    Private Sub btnFinanceHeadReject_Click(sender As Object, e As EventArgs) Handles btnFinanceHeadReject.Click
        FinanceHeadStatAccept = "Reject"

        FinanceHeadNameAccept = LabelFinanceHeadName.Text

        FinanceHeadCommentAccept = txtboxFinanceHead.Text

        FinanceHeadDateAccept = Date.Today

        LabelFinanceHeadApp.Text = FinanceHeadStatAccept

        LabelDateFinanceHead.Text = FinanceHeadDateAccept

        LabelFinanceHeadComment.Text = txtboxFinanceHead.Text

        'statusNextflow = "Pending"
        'check = 1

        inserthistory = "INSERT INTO `financeheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadDate`, `FINANCEHeadComment` ) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
        updateHistory = "UPDATE `historyrequest` SET `FINANCEHEADName`=@name,`FINANCEHEADStatus`=@status,`FINANCEHEADDate`=@dateapp, `FINANCEHEADComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
        insertNextFlow = "INSERT INTO `Financedepthead` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, financedeptStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

        apdb.insertHistory(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, inserthistory)

        apdb.updateHistory(FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, updateHistory)

        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

        'If verfFinanceHeadIfEmpty() = True Then
        '    insertchecker = "UPDATE `checkergroup` SET `Financehead`=@check WHERE empid='" & LabelEmpID.Text & "'"
        '    apdb.updatechecker(check, insertchecker)

        '    Dim updated As Boolean = apdb.updatechecker(check, insertchecker)
        '    If updated AndAlso verfGroupIfComplete() = True Then
        '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
        '        apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
        '    End If
        'End If




        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnFinanceHeadApp.Visible = False
        btnFinanceHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelFinanceHeadComment.Visible = True

        txtboxFinanceHead.Visible = False
        txtboxFinanceHead.Text = ""
    End Sub




    'END OF REJECT




    'Private Function verfFinanceHeadIfEmpty() As Boolean
    '    Dim query As String
    '    query = "select FINANCEhead from checkergroup where empID='" & LabelEmpID.Text & "'"
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

    Private Sub LabelFinanceHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelFinanceHeadApp.TextChanged
        If LabelFinanceHeadApp.Text = "Pending" Then
            LabelFinanceHeadApp.BackColor = Color.PowderBlue
        ElseIf LabelFinanceHeadApp.Text = "Approve" Then
            LabelFinanceHeadApp.BackColor = Color.Lime
        Else
            LabelFinanceHeadApp.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnFinanceHeadApp.Visible = True
        btnFinanceHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelFinanceHeadComment.Visible = False
        LabelDateFinanceHead.Text = ""

        txtboxFinanceHead.Visible = True
        txtboxFinanceHead.Text = ""
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnFinanceHeadApp.Visible = True
        btnFinanceHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelFinanceHeadComment.Visible = False
        LabelDateFinanceHead.Text = ""

        txtboxFinanceHead.Visible = True
        txtboxFinanceHead.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewFinanceHead_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnFinanceHeadApp.Visible = True
        btnFinanceHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelFinanceHeadComment.Visible = False
        LabelDateFinanceHead.Text = ""

        txtboxFinanceHead.Visible = True
        txtboxFinanceHead.Text = ""

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