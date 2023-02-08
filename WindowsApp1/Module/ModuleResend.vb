'Imports System
'Module ModuleResend
'    Dim apdb As New ApprovalDB

'    Dim updateHistory As String


'    Public Sub HRResendGroup()

'        If ViewHistory.ComboBox1.SelectedItem = "BDG" Then
'            updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptComment`=@comment,`BDGDeptDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)


'        ElseIf ViewHistory.ComboBox1.SelectedItem = "SDG Supervisor" Then
'            updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status,`SDGSuperComment`=@comment,`SDGSuperDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)


'        ElseIf ViewHistory.ComboBox1.SelectedItem = "SDG" Then
'            updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptComment`=@comment,`SDGDeptDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)


'        ElseIf ViewHistory.ComboBox1.SelectedItem = "ITOPS" Then
'            updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptComment`=@comment,`ITOPSDeptDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)


'        ElseIf ViewHistory.ComboBox1.SelectedItem = "PMG" Then
'            updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptComment`=@comment,`PMGDeptDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "Marketing" Then
'            updateHistory = "UPDATE `historyrequest` SET `MarketingDeptName`=@name, `MarketingDeptStatus`=@status,`MarketingDeptComment`=@comment,`MarketingDeptDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "Finance" Then
'            updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptComment`=@comment,`FinanceDeptDateApprove`=@dateapp, `CashAdvance`=@cash, `CashAdvanceCheckBy`=@checkcash WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentFinance(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "Finance Head" Then
'            updateHistory = "UPDATE `historyrequest` SET `FinanceHeadName`=@name, `FinanceHeadStatus`=@status,`FinanceHeadComment`=@comment,`FinanceHeadDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "Admin Group" Then
'            updateHistory = "UPDATE `historyrequest` SET `CompanyID`=@compid, `Tools`=@tools,`CompanyPhone`=@phone,`TelcoCheck`=@telco WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentAdmin(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "Admin Head" Then
'            updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status,`AdminHeadComment`=@comment,`AdminHeadDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "System Admin Group" Then
'            updateHistory = "UPDATE `historyrequest` SET `Laptop`=@laptop, `EmailDeact`=@email,`ComDeact`=@comdeact WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentSysAdmin(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "System Admin Head" Then
'            updateHistory = "UPDATE `historyrequest` SET `SysAdminHeadName`=@name, `SysAdminHeadStatus`=@status,`SysAdminHeadComment`=@comment,`SysAdminHeadDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "HR Head" Then
'            updateHistory = "UPDATE `historyrequest` SET `HRHeadName`=@name, `HRHeadStatus`=@status,`HRHeadComment`=@comment,`HRHeadDateApprove`=@dateapp WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentGroup(updateHistory)

'        ElseIf ViewHistory.ComboBox1.SelectedItem = "HR Group" Then
'            updateHistory = "UPDATE `historyrequest` SET `ESSActDeact`=@essdeact, `CompanyHealthCard`=@comphealth,`PayrollATM`=@payroll,`OthersCheck`=@othercheck, `OtherComment`=@othercomment WHERE empID='" & ViewHistory.LabelEmpID.Text & "'"
'            apdb.updateResentHRGroup(updateHistory)
'        Else
'            MsgBox("Please Select Group you want to resend the form.")
'        End If

'    End Sub

'End Module
