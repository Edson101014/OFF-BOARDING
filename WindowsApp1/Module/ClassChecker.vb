Imports MySql.Data.MySqlClient
Public Class ClassChecker

    Dim dbs As New db
    Dim adapter As New MySqlDataAdapter
    Dim table As New DataTable




    Public Function verfAdminIfEmpty() As Boolean
        Dim query As String
        query = "select adminhead from checker where empID='" & ViewRequest.LabelEmpID.Text & "'"
        Dim command As New MySqlCommand(query, dbs.getconn)
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            Return True
            Exit Function
        End If
    End Function










    Public Function verfSDGHeadIfEmpty() As Boolean
        Dim query As String
        query = "select SDGhead from checkergroup where empID='" & ViewRequest.LabelEmpID.Text & "'"
        Dim command As New MySqlCommand(query, dbs.getconn)
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            Return True
            Exit Function
        End If
    End Function

    Public Function verfResendHistory()
        Dim query As String
        query = String.Format("Select empID from {0} where empID='" & ViewHistory.LabelEmpID.Text & "'", Login.queryhistory)
        Dim command As New MySqlCommand(query, dbs.getconn)
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            Return True
            Exit Function
        End If
    End Function

    Public Function verfHRhistory()
        Dim query As String
        query = "INSERT INTO `completerequest`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDateApprove`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDateApprove`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDateApprove`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDateApprove`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDateApprove`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDateApprove`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDateApprove`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDateApprove`, `CashAdvance`, `CashAdvanceCheckBy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDateApprove`, `CompanyID`, `Tools`, `CompanyPhone`, `TelcoCheck`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDateApprove`, `Laptop`, `EmailDeact`, `ComDeact`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDateApprove`, `ESSActDeact`, `CompanyHealthCard`, `PayrollATM`, `OthersCheck`, `OtherComment`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDateApprove`) SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDateApprove`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDateApprove`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDateApprove`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDateApprove`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDateApprove`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDateApprove`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDateApprove`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDateApprove`, `CashAdvance`, `CashAdvanceCheckBy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDateApprove`, `CompanyID`, `Tools`, `CompanyPhone`, `TelcoCheck`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDateApprove`, `Laptop`, `EmailDeact`, `ComDeact`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDateApprove`, `ESSActDeact`, `CompanyHealthCard`, `PayrollATM`, `OthersCheck`, `OtherComment`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDateApprove` FROM `historyrequest` WHERE empID='" & ViewHistory.LabelEmpID.Text & "' AND BDGDeptName is not null and BDGDeptStatus is not null and BDGDeptDateApprove is not null and SDGSuperName is not null and SDGSuperStatus is not null and SDGSuperDateApprove is not null and SDGDeptName is not null and SDGDeptStatus is not null and SDGDeptDateApprove is not null and ITOPSDeptName is not null and ITOPSDeptStatus is not null and ITOPSDeptDateApprove is not null and PMGDeptName is not null and PMGDeptStatus is not null and PMGDeptDateApprove is not null and MarketingDeptName is not null and MarketingDeptStatus is not null and MarketingDeptDateApprove is not null and FINANCEHeadName is not null and FINANCEHeadStatus is not null and FinanceHeadDateApprove is not null and FINANCEDeptName is not null and FINANCEDeptStatus is not null and FINANCEDeptName is not null and FINANCEDeptStatus is not null and FINANCEDeptDateApprove is not null and AdminHeadName is not null and AdminHeadStatus is not null and AdminHeadDateApprove is not null and SysAdminHeadName is not null and SysAdminHeadStatus is not null and SysAdminHeadDateApprove is not null and CashAdvance is not null and CashAdvanceCheckBy is not null and CompanyID is not null and tools is not null and CompanyPhone is not null and TelcoCheck is not null and Laptop is not null and EmailDeact is not null and ComDeact is not null and InterviewCheck is not null and CompanyHealthCard is not null and ESSActDeact is not null and PayrollATM IS NOT NULL AND HRHeadName IS NOT NULL AND HRHeadStatus IS NOT NULL AND HRHeadDateApprove IS NOT NULL AND CashAdvance=`Checked` and CompanyID=`Checked` and Tools=`Checked` and CompanyPhone=`Checked` and TelcoCheck=`Checked` and Laptop=`Checked` and EmailDeact=`Checked` and ComDeact=`Checked` and InterviewCheck=`Checked` and CompanyHealthCard=`Checked` and ESSActDeact=`Checked` and PayrollATM=`Checked`"
        Dim command As New MySqlCommand(query, dbs.getconn)
        adapter.SelectCommand = command
        adapter.Fill(table)



        If table.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            Return True
            Exit Function
        End If
    End Function


End Class
