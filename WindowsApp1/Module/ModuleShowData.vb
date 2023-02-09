Imports MySql.Data.MySqlClient
Module ModuleShowData
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    Dim query As New MySqlCommand()

    Public Sub fillGridDashboard(ByVal command As MySqlCommand)
        Dashboard.DataGridView1.ReadOnly = True
        Dashboard.DataGridView1.DataSource = apdb.getemployee(command)

        If Login.flag = "COO" Or Login.flag = "CEO" Then
            Dashboard.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dashboard.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            Dashboard.DataGridView1.Columns(1).HeaderText = "Employee Name"
            Dashboard.DataGridView1.Columns(2).HeaderText = "Employee ID"
            Dashboard.DataGridView1.Columns(3).HeaderText = "Department"
            Dashboard.DataGridView1.Columns(4).HeaderText = "Employee Position"
            Dashboard.DataGridView1.Columns(5).HeaderText = "Clearance Purpose"
            Dashboard.DataGridView1.Columns(6).HeaderText = "Employee Status"
            Dashboard.DataGridView1.Columns(7).HeaderText = "Seperation Date"

            Dashboard.LabelTotalDash.Text = Dashboard.DataGridView1.Rows.Count

        Else
            Dashboard.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dashboard.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            Dashboard.DataGridView1.Columns(1).HeaderText = "Employee Name"
            Dashboard.DataGridView1.Columns(2).HeaderText = "Employee ID"
            Dashboard.DataGridView1.Columns(3).HeaderText = "Department"
            Dashboard.DataGridView1.Columns(4).HeaderText = "Employee Position"
            Dashboard.DataGridView1.Columns(5).HeaderText = "Clearance Purpose"
            Dashboard.DataGridView1.Columns(6).HeaderText = "Employee Status"
            Dashboard.DataGridView1.Columns(7).HeaderText = "Seperation Date"
            Dashboard.DataGridView1.Columns(8).HeaderText = "Status"
            Dashboard.LabelTotalDash.Text = Dashboard.DataGridView1.Rows.Count
        End If

    End Sub

    Public Sub fillGridHistory(ByVal command As MySqlCommand)
        Dashboard.DataGridHistory.ReadOnly = True
        Dashboard.DataGridHistory.DataSource = apdb.getemployee(command)
        Dim columnNames() As String


        If Login.flag = "Supervisor" Then
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Supervisor Name", "Status", "Comment", "Date"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count

        ElseIf Login.flag = "Finance Dept Head" Then
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Name", "Status", "Comment", "Date", "Cash Advance Status", "Others Status", "Others Comment"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count

        ElseIf Login.flag = "ADMIN" Then
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Name", "Status", "Comment", "Date", "Telco Check Status", "Tools Check Status", "Phone Check Status", "Table Check Status", "Others Check Status", "Others Comment"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count

        ElseIf Login.flag = "SYSADMIN" Then
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Laptop Check Status", "Computer Check Status", "Email Deact Status", "Computer Deact Status"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count

        ElseIf Login.flag = "HR" Then
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "BDG Dept Head Name", "BDG Dept Head Status", "BDG Dept Head Comment", "BDG Dept Head Date", "SDG Supervisor Name", "SDG Supervisor Status", "SDG Supervisor Comment", "SDG Supervisor Date", "SDG Dept Head Name", "SDG Dept Head Status", "SDG Dept Head Comment", "SDG Dept HeadDate", "ITOPS Dept Head Name", "ITOPS Dept Head Status", "ITOPS Dept Head Comment", "ITOPS Dept HeadDate", "PMG Dept Head Name", "PMG Dept Head Status", "PMG Dept Head Comment", "PMG Dept Head Date", "Marketing Dept Head Name", "Marketing Dept Head Status", "Marketing Dept Head Comment", "Marketing Dept Head Date", "FINANCE Head Name", "FINANCE Head Status", "FINANCE Head Comment", "Finance Head Date", "FINANCE Dept Head Name", "FINANCE Dept Head Status", "FINANCE Dept Head Comment", "FINANCE Dept Head Date", "Cash Advance Status", "Finance Dept Head Others Status", "Finance Dept Head Other Comment", "Admin Group Name", "Admin Group Status", "Admin Group Comment", "Admin Group Date", "Check Laptop Status", "Check Teleco Status", "Check Tools Status", "Check Phone Status", "Check Table Status", "Check Others Status", "Check Others Comment", "Admin Head Name", "Admin Head Status", "Admin Head Comment", "Admin Head Date", "Sys Admin Head Name", "Sys Admin Head Status", "Sys Admin Head Comment", "Sys Admin Head Date", "Laptop Status", "Email Deactivation Status", "Computer Deactivation Status", "HR Head Name", "HR Head Status", "HR Head Comment", "HR Head Date", "HR Group Status", "HR Group Comment", "HR Group Date", "Check HMO Status", "Check Insurance Status", "Check CompanyID Status", "Check QuitClaim Status", "Check COE Status", "Check ITR Status", "Check FinalPay Status", "Interview Check Status", "Exit InterviewBy", "Exit Interview Date"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalDash.Text = Dashboard.DataGridHistory.Rows.Count

        Else

            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Approver Name", "Status", "Comment", "Date"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count
        End If
    End Sub

    Public Sub ShowHRInterviewData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRStatus` FROM `hrinterview` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)
    End Sub

    Public Sub ShowData()

        query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} ORDER BY `LastDayEmploy` ASC", Login.querystatus, Login.str)
        fillGridDashboard(query)

        query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} ORDER BY `LastDayEmploy` ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        fillGridHistory(query)

    End Sub


    Public Sub ShowFinanceData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthead` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)

    End Sub
    Public Sub ShowAdminData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminStatus` FROM `admingroup` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)

    End Sub
    Public Sub ShowSysAdminData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminStatus` FROM `sysadmin` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)
    End Sub

    Public Sub ShowHRData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRStatus` FROM `hr` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)
    End Sub


    Public Sub ShowHRHeadData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRHeadStatus` FROM `hrhead` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` ASC"
        fillGridHistory(query)
    End Sub





End Module
