'Imports MySql.Data.MySqlClient
'Public Class ViewRequest
'    Dim query As String
'    Dim dbs As New db
'    Dim apdb As New ApprovalDB
'    Dim adapter As New MySqlDataAdapter
'    Dim table As New DataTable
'    Dim reader As MySqlDataReader
'    Dim command As New MySqlCommand(query, dbs.getconn)

'    Dim updategrouphistory As String
'    Dim updateHistory As String

'    Private Sub ViewRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Label3.Select()

'        If Login.flag = "Supervisor" Then
'            ShowSuperButton()


'        ElseIf Login.flag = "BDG Dept Head" Then

'            ShowBDGButton()


'        ElseIf Login.flag = "SDG Dept Head" Then

'            ShowSDGButton()
'            LabelDateSDGDept.Text = Date.Today

'        ElseIf Login.flag = "ITOPS Dept Head" Then

'            ShowITOPSButton()
'            LabelDateITOPSDept.Text = Date.Today

'        ElseIf Login.flag = "PMG Dept Head" Then

'            ShowPMGButton()
'            LabelDatePMGDept.Text = Date.Today

'        ElseIf Login.flag = "Marketing Dept Head" Then

'            ShowMarketingButton()
'            LabelDateMarketingDept.Text = Date.Today

'        ElseIf Login.flag = "Finance Dept Head" Then

'            ShowFinanceButton()
'            LabelDateFinanceDept.Text = Date.Today

'        ElseIf Login.flag = "Finance Head" Then

'            ShowFinanceheadButton()
'            LabelDateFinanceHead.Text = Date.Today

'        ElseIf Login.flag = "ADMIN" Then

'            ShowAdminButton()


'        ElseIf Login.flag = "ADMIN HEAD" Then

'            ShowAdminHeadButton()
'            LabelDateAdminHead.Text = Date.Today

'        ElseIf Login.flag = "SYSADMIN" Then

'            ShowSysAdminButton()


'        ElseIf Login.flag = "SYS ADMIN HEAD" Then

'            ShowSysAdminHeadButton()
'            LabelDateSysAdminHead.Text = Date.Today

'        ElseIf Login.flag = "HR Interview" Then

'            ShowHRInterviewButton()


'        ElseIf Login.flag = "HR" Then

'            ShowHRButton()


'        ElseIf Login.flag = "HR Head" Then

'            ShowHRHeadButton()
'            LabelDateHRHead.Text = Date.Today

'        End If

'    End Sub

'    Private Sub btnIMSupervisorApp_Click(sender As Object, e As EventArgs) Handles btnIMSupervisorApp.Click

'        'updategrouphistory = "UPDATE `sdgsuperhistory` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDateApprove`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDateApprove`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

'        'If verfResendHistory() Then

'        '    apdb.updateHistory(IMNameAccept, IMStatAccept, IMDateAccept, IMCommentAccept, updateHistory)
'        '    apdb.updateHistory(IMNameAccept, IMStatAccept, IMDateAccept, IMCommentAccept, updategrouphistory)

'        'Else


'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "APPROVE")

'        'End If
'        Me.Close()
'    End Sub

'    Private Sub btnBDGDeptApp_Click(sender As Object, e As EventArgs) Handles btnBDGDeptApp.Click
'        'updategrouphistory = "UPDATE `bdgdepthistory` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDateApprove`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDateApprove`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

'        'If verfResendHistory() = True Then

'        '    apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)
'        '    apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updategrouphistory)

'        'Else

'        'BDGDeptApp()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "Approve")

'        'End If
'        Me.Close()
'    End Sub

'    Private Sub btnSDGDeptApp_Click(sender As Object, e As EventArgs) Handles btnSDGDeptApp.Click
'        'updategrouphistory = "UPDATE `sdgdepthistory` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDateApprove`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDateApprove`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"


'        'If verfResendHistory() Then

'        '    apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)
'        '    apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updategrouphistory)

'        'Else

'        'SDGDeptApp()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "Approve")

'        'End If
'        Me.Close()

'    End Sub

'    Private Sub btnITOPSDeptApp_Click(sender As Object, e As EventArgs) Handles btnITOPSDeptApp.Click
'        'updategrouphistory = "UPDATE `ITOPSdepthistory` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDateApprove`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDateApprove`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"


'        'If verfResendHistory() Then

'        '    apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)
'        '    apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updategrouphistory)

'        'Else

'        'ITOPSDeptApp()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "Approve")

'        'End If
'        Me.Close()

'    End Sub

'    Private Sub btnPMGDeptApp_Click(sender As Object, e As EventArgs) Handles btnPMGDeptApp.Click
'        'updategrouphistory = "UPDATE `PMGdepthistory` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDateApprove`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDateApprove`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"


'        'If verfResendHistory() Then
'        '    apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)
'        '    apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updategrouphistory)
'        'Else

'        'PMGDeptApp()
'        MsgBox("You Successful Approve!", MsgBoxStyle.Information, "APPROVE")

'        'End If
'        Me.Close()

'    End Sub

'    Private Sub btnMARKETDeptApp_Click(sender As Object, e As EventArgs) Handles btnMARKETDeptApp.Click
'        'updategrouphistory = "UPDATE `marketingdepthistory` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDateApprove`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDateApprove`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"


'        'If verfResendHistory() Then
'        '    apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)
'        '    apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updategrouphistory)
'        'Else
'        'MarketingDeptApp()
'        MsgBox("You Successful Approve!", MsgBoxStyle.Information, "APPROVE")
'        'End If
'        Me.Close()
'    End Sub




'    Private Sub btnFINANCEDeptApp_Click(sender As Object, e As EventArgs) Handles btnFINANCEDeptApp.Click
'        'updategrouphistory = "UPDATE `financedepthistory` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDateApprove`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvanceCheck`=@checkcash, `CashAdvanceCheckBy`=@checkcashby WHERE empID = '" & LabelEmpID.Text & "'"
'        'updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDateApprove`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvanceCheck`=@checkcash, `CashAdvanceCheckBy`=@checkcashby WHERE empID = '" & LabelEmpID.Text & "'"


'        'If verfResendHistory() Then
'        '    apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkCash, FinanceCashAdvanced, updateHistory)
'        '    apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkCash, FinanceCashAdvanced, updategrouphistory)

'        'Else
'        FinanceDeptApp()
'            MsgBox("You Successful Approve!", MsgBoxStyle.Information, "APPROVE")
'        'End If
'        Me.Close()

'    End Sub

'    Private Sub btnFinanceHeadApp_Click(sender As Object, e As EventArgs) Handles btnFinanceHeadApp.Click
'        'updategrouphistory = "INSERT INTO `FINANCEheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadDateApprove`, `FINANCEHeadComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status, @dateapp, @comment)"
'        'updateHistory = "UPDATE `historyrequest` SET `FINANCEHEADName`=@name,`FINANCEHEADStatus`=@status,`FINANCEHEADDateApprove`=@dateapp, `FINANCEHEADComment`=@comment WHERE empID = '" & LabelEmpID.Text & "'"

'        'If verfResendHistory() Then
'        '    apdb.updateHistory(FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, updateHistory)
'        '    apdb.updateHistory(FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, updategrouphistory)

'        'Else

'        FinanceHeadApp()
'            MsgBox("You Successful Approve!", MsgBoxStyle.Information, "APPROVE")
'        'End If
'        Me.Close()

'    End Sub


'    Private Sub btnAdminApp_Click(sender As Object, e As EventArgs) Handles btnAdminApp.Click

'        AdminApp()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "REJECT")
'        Me.Close()

'    End Sub

'    Private Sub btnAdminHeadApp_Click(sender As Object, e As EventArgs) Handles btnAdminHeadApp.Click
'        AdminHeadApp()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "Approve")
'        Me.Close()

'    End Sub

'    Private Sub ButtonSysAdmin_Click(sender As Object, e As EventArgs) Handles btnSYSAdminApp.Click
'        SysAdmin()
'        MsgBox("You sent to history!", MsgBoxStyle.Information, "APPROVE")
'        Me.Close()

'    End Sub

'    Private Sub btnSysAdminHeadApp_Click(sender As Object, e As EventArgs) Handles btnSysAdminHeadApp.Click
'        SysAdminHead()
'        MsgBox("You Approve the Request!", MsgBoxStyle.Information, "Approve")
'        Me.Close()

'    End Sub



'    Private Sub btnHRApp_Click(sender As Object, e As EventArgs) Handles btnHRApp.Click
'        If Login.flag = "HR" Then
'            HRApp()
'        ElseIf Login.flag = "HR Interview" Then
'            HRAppInterview()
'        End If

'        MsgBox("You Approve the request!", MsgBoxStyle.Information, "APPROVE")
'        Me.Close()

'    End Sub


'    Private Sub btnHRHeadApp_Click(sender As Object, e As EventArgs) Handles btnHRHeadApp.Click
'        HRHeadApp()
'        MsgBox("You sent to history!", MsgBoxStyle.Information, "APPROVE")
'        Me.Close()

'    End Sub


'    Private Sub ViewRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
'        If Login.flag = "Finance Dept Head" Then
'            ShowFinanceData()

'        ElseIf Login.flag = "SYSADMIN" Then
'            ShowSysAdminData()

'        ElseIf Login.flag = "ADMIN" Then
'            ShowAdminData()

'        ElseIf Login.flag = "HR" Then
'            ShowHRData()
'        ElseIf Login.flag = "HR Interview" Then
'            ShowHRInterviewData()
'        Else
'            ShowData()
'        End If

'        HideButtons()

'    End Sub






'    Private Sub LabeLFinanceHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabeLFinanceHeadApp.TextChanged
'        If LabeLFinanceHeadApp.Text = "Pending" Then
'            LabeLFinanceHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabeLFinanceHeadApp.Text = "Approve" Then
'            LabeLFinanceHeadApp.BackColor = Color.Lime
'        Else
'            LabeLFinanceHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminHeadApp.TextChanged
'        If LabelAdminHeadApp.Text = "Pending" Then
'            LabelAdminHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelAdminHeadApp.Text = "Approve" Then
'            LabelAdminHeadApp.BackColor = Color.Lime
'        Else
'            LabelAdminHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelSysAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminHeadApp.TextChanged
'        If LabelSysAdminHeadApp.Text = "Pending" Then
'            LabelSysAdminHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelSysAdminHeadApp.Text = "Approve" Then
'            LabelSysAdminHeadApp.BackColor = Color.Lime
'        Else
'            LabelSysAdminHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelHRHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRHeadApp.TextChanged
'        If LabelHRHeadApp.Text = "Pending" Then
'            LabelHRHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelHRHeadApp.Text = "Approve" Then
'            LabelHRHeadApp.BackColor = Color.Lime
'        Else
'            LabelHRHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub



'    Private Sub CheckBoxESS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxESS.CheckedChanged
'        If CheckBoxESS.Checked = True Then
'            checkESS = "Checked"
'            CheckBoxESS.BackColor = Color.Lime
'        ElseIf CheckBoxESS.Checked = False Then
'            CheckBoxESS.BackColor = Color.Gray
'            checkESS = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxCompHealth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompHealth.CheckedChanged
'        If CheckBoxCompHealth.Checked = True Then
'            checkHealth = "Checked"
'            CheckBoxCompHealth.BackColor = Color.Lime
'        ElseIf CheckBoxCompHealth.Checked = False Then
'            CheckBoxCompHealth.BackColor = Color.Gray
'            checkHealth = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxPayroll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPayroll.CheckedChanged
'        If CheckBoxPayroll.Checked = True Then
'            checkPayroll = "Checked"
'            CheckBoxPayroll.BackColor = Color.Lime
'        ElseIf CheckBoxPayroll.Checked = False Then
'            CheckBoxPayroll.BackColor = Color.Gray
'            checkPayroll = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxInterview_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInterview.CheckedChanged
'        If CheckBoxInterview.Checked = True Then
'            checkinterview = "Checked"
'            CheckBoxInterview.BackColor = Color.Lime
'        ElseIf CheckBoxInterview.Checked = False Then
'            CheckBoxInterview.BackColor = Color.Gray
'            checkinterview = "Unchecked"
'        End If
'    End Sub


'End Class