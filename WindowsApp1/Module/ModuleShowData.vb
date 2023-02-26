Imports MySql.Data.MySqlClient
Module ModuleShowData
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    Dim query As New MySqlCommand()
    Dim pagerows As Integer

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





    Public Sub fillGridComplete(ByVal command As MySqlCommand)
        Dashboard.DataGridViewComplete.ReadOnly = True
        Dashboard.DataGridViewComplete.DataSource = apdb.getemployee(command)

        Dim columnNames() As String

        columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clear Purpose", "Employee Status", "Seperation Date", "BDG Dept Head Name", "BDG Dept Head Status", "BDG Dept Head Comment", "BDG Dept Head Date", "SDG Supervisor Name", "SDG Supervisor Status", "SDG Supervisor Comment", "SDG Supervisor Date", "SDG Dept Head Name", "SDG Dept Head Status", "SDG Dept Head Comment", "SDG Dept Head Date", "ITOPS Dept Head Name", "ITOPS Dept Head Status", "ITOPS Dept Head Comment", "ITOPS Dept Head Date", "PMG Dept Head Name", "PMG Dept Head Status", "PMG Dept Head Comment", "PMG Dept Head Date", "Marketing Dept Head Name", "Marketing Dept Head Status", "Marketing Dept Head Comment", "Marketing Dept Head Date", "Finance Head Name", "Finance Head Status", "Finance Head Comment", "Finance Head Date", "Finance Group Name", "Finance Group Status", "Finance Group Comment", "Finance Group Date", "Cash Advance Status", "Finance Group Others", "Finance Group Other Comment", "Admin Group Name", "Admin Group Status", "Admin Group Comment", "Admin Group Date", "Check Teleco Status", "Check Tools Status", "Check Phone Status", "Check Table Status", "Check Others Status", "Check Others Comment", "Admin Head Name", "Admin Head Status", "Admin Head Comment", "Admin Head Date", "Sys Admin Name", "Sys Admin Status", "Sys Admin Comment", "Sys Admin Date", "Check Laptop Status", "Check Email Status", "Check Computer Status", "Sys Admin Head Name", "Sys Admin Head Status", "Sys Admin Head Comment", "Sys Admin Head Date", "HR Head Name", "HR Head Status", "HR Head Comment", "HR Head Date", "HR Group Name", "HR Group Status", "HR Group Comment", "HR Group Date", "Check HMO Status", "Check Insurance Status", "Check Company ID Status", "Check Quit Claim Status", "Check COE Status", "Check ITR Status", "Check FinalPay Status", "Schedule Interviewer Name", "Schedule Interview Status", "Schedule Interview Date", "Exit Interview By", "Exit Interview Status", "Exit Interview Date"}
        For i As Integer = 1 To columnNames.Length
            Dashboard.DataGridViewComplete.Columns(i).HeaderText = columnNames(i - 1)
        Next

        Dashboard.LabelTotalComplete.Text = Dashboard.DataGridViewComplete.Rows.Count

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
            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clear Purpose", "Employee Status", "Seperation Date", "BDG Dept Head Name", "BDG Dept Head Status", "BDG Dept Head Comment", "BDG Dept Head Date", "SDG Supervisor Name", "SDG Supervisor Status", "SDG Supervisor Comment", "SDG Supervisor Date", "SDG Dept Head Name", "SDG Dept Head Status", "SDG Dept Head Comment", "SDG Dept Head Date", "ITOPS Dept Head Name", "ITOPS Dept Head Status", "ITOPS Dept Head Comment", "ITOPS Dept Head Date", "PMG Dept Head Name", "PMG Dept Head Status", "PMG Dept Head Comment", "PMG Dept Head Date", "Marketing Dept Head Name", "Marketing Dept Head Status", "Marketing Dept Head Comment", "Marketing Dept Head Date", "Finance Head Name", "Finance Head Status", "Finance Head Comment", "Finance Head Date", "Finance Group Name", "Finance Group Status", "Finance Group Comment", "Finance Group Date", "Cash Advance Status", "Finance Group Others", "Finance Group Other Comment", "Admin Group Name", "Admin Group Status", "Admin Group Comment", "Admin Group Date", "Check Teleco Status", "Check Tools Status", "Check Phone Status", "Check Table Status", "Check Others Status", "Check Others Comment", "Admin Head Name", "Admin Head Status", "Admin Head Comment", "Admin Head Date", "Sys Admin Name", "Sys Admin Status", "Sys Admin Comment", "Sys Admin Date", "Check Laptop Status", "Check Email Status", "Check Computer Status", "Sys Admin Head Name", "Sys Admin Head Status", "Sys Admin Head Comment", "Sys Admin Head Date", "HR Head Name", "HR Head Status", "HR Head Comment", "HR Head Date", "HR Group Name", "HR Group Status", "HR Group Comment", "HR Group Date", "Check HMO Status", "Check Insurance Status", "Check Company ID Status", "Check Quit Claim Status", "Check COE Status", "Check ITR Status", "Check FinalPay Status", "Schedule Interviewer Name", "Schedule Interview Status", "Schedule Interview Date", "Exit Interview By", "Exit Interview Status", "Exit Interview Date"}
            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count

        ElseIf Login.flag = "HR Head" Then

            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clear Purpose", "Employee Status", "Seperation Date", "BDG Dept Head Name", "BDG Dept Head Status", "BDG Dept Head Comment", "BDG Dept Head Date", "SDG Supervisor Name", "SDG Supervisor Status", "SDG Supervisor Comment", "SDG Supervisor Date", "SDG Dept Head Name", "SDG Dept Head Status", "SDG Dept Head Comment", "SDG Dept Head Date", "ITOPS Dept Head Name", "ITOPS Dept Head Status", "ITOPS Dept Head Comment", "ITOPS Dept Head Date", "PMG Dept Head Name", "PMG Dept Head Status", "PMG Dept Head Comment", "PMG Dept Head Date", "Marketing Dept Head Name", "Marketing Dept Head Status", "Marketing Dept Head Comment", "Marketing Dept Head Date", "Finance Head Name", "Finance Head Status", "Finance Head Comment", "Finance Head Date", "Finance Group Name", "Finance Group Status", "Finance Group Comment", "Finance Group Date", "Cash Advance Status", "Finance Group Others", "Finance Group Other Comment", "Admin Group Name", "Admin Group Status", "Admin Group Comment", "Admin Group Date", "Check Teleco Status", "Check Tools Status", "Check Phone Status", "Check Table Status", "Check Others Status", "Check Others Comment", "Admin Head Name", "Admin Head Status", "Admin Head Comment", "Admin Head Date", "Sys Admin Name", "Sys Admin Status", "Sys Admin Comment", "Sys Admin Date", "Check Laptop Status", "Check Email Status", "Check Computer Status", "Sys Admin Head Name", "Sys Admin Head Status", "Sys Admin Head Comment", "Sys Admin Head Date", "HR Head Name", "HR Head Status", "HR Head Comment", "HR Head Date", "HR Group Name", "HR Group Status", "HR Group Comment", "HR Group Date", "Check HMO Status", "Check Insurance Status", "Check Company ID Status", "Check Quit Claim Status", "Check COE Status", "Check ITR Status", "Check FinalPay Status", "Schedule Interviewer Name", "Schedule Interview Status", "Schedule Interview Date", "Exit Interview By", "Exit Interview Status", "Exit Interview Date"}
            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count
        Else

            columnNames = {"Employee Name", "Employee ID", "Department", "Employee Position", "Clearance Purpose", "Employee Status", "Seperation Date", "Approver Name", "Status", "Comment", "Date"}

            For i As Integer = 1 To columnNames.Length
                Dashboard.DataGridHistory.Columns(i).HeaderText = columnNames(i - 1)
            Next

            Dashboard.LabelTotalHistory.Text = Dashboard.DataGridHistory.Rows.Count
        End If
    End Sub


    Public Sub ShowHRInterviewData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRStatus` FROM `hrinterview` ORDER BY `LastDayEmploy` DESC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `completerequest` ORDER BY `LastDayEmploy` DESC"
        fillGridComplete(query)

        query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login`"
        fillGridHR(query)
    End Sub


    Public Sub ShowData()

        query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} ORDER BY `LastDayEmploy` DESC", Login.querystatus, Login.str)
        fillGridDashboard(query)

        query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} ORDER BY `LastDayEmploy` DESC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        fillGridHistory(query)

    End Sub


    Public Sub ShowFinanceData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthead` ORDER BY `LastDayEmploy` DESC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)

    End Sub
    Public Sub ShowAdminData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminStatus` FROM `admingroup` ORDER BY `LastDayEmploy` DESC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)

    End Sub
    Public Sub ShowSysAdminData()

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminStatus` FROM `sysadmin` ORDER BY `LastDayEmploy` DESC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)
    End Sub

    Public Sub ShowHRData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRStatus` FROM `hr` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `completerequest` ORDER BY `LastDayEmploy` DESC"
        fillGridComplete(query)

        query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login`"
        fillGridHR(query)
    End Sub


    Public Sub ShowHRHeadData()
        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `HRHeadStatus` FROM `hrhead` ORDER BY `LastDayEmploy` ASC"
        fillGridDashboard(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `LastDayEmploy` DESC"
        fillGridHistory(query)

        query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `completerequest` ORDER BY `LastDayEmploy` DESC"
        fillGridComplete(query)

        query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login`"
        fillGridHR(query)
    End Sub


    Sub fillGridHR(ByVal command As MySqlCommand)
        Dashboard.DataGridHR.ReadOnly = True
        Dashboard.DataGridHR.DataSource = apdb.getemployee(command)
        Dashboard.DataGridHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dashboard.DataGridHR.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None


        Dashboard.DataGridHR.Columns(0).HeaderText = "Username"
        Dashboard.DataGridHR.Columns(1).HeaderText = "Password"
        Dashboard.DataGridHR.Columns(2).HeaderText = "Name"
        Dashboard.DataGridHR.Columns(3).HeaderText = "Email"
        Dashboard.DataGridHR.Columns(4).HeaderText = "Title"
        Dashboard.DataGridHR.Columns(5).HeaderText = "Department"

        Dashboard.LabelTotalHR.Text = Dashboard.DataGridHR.Rows.Count





    End Sub

    Public Sub HistorySearchAdmin()
        If Dashboard.CheckHistoryByID.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `empID` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByName.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `Name` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `Name` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByPurpose.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `clearPurpose` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByDepartment.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `dept` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `dept` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByApprove.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & Dashboard.approve & "' ORDER BY `AdminGroupStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & Dashboard.approve & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByRejected.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & Dashboard.reject & "' ORDER BY `AdminGroupStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & Dashboard.reject & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If


    End Sub


    Public Sub HistorySearchFinanceDept()

        If Dashboard.CheckHistoryByID.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `empID` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByName.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `Name` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `Name` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByPurpose.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `clearPurpose` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByDepartment.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `dept` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `dept` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByApprove.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & Dashboard.approve & "' ORDER BY `FINANCEDeptStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & Dashboard.approve & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByRejected.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & Dashboard.reject & "' ORDER BY `FINANCEDeptStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & Dashboard.reject & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

    End Sub

    Public Sub HistorySearchSysAdmin()
        If Dashboard.CheckHistoryByID.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `empID` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByName.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `Name` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `Name` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByPurpose.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `clearPurpose` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByDepartment.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` ORDER BY `dept` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `dept` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByApprove.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & Dashboard.approve & "' ORDER BY `SysAdminStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & Dashboard.approve & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByRejected.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & Dashboard.reject & "' ORDER BY `SysAdminStatus` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & Dashboard.reject & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
    End Sub

    Public Sub HistorySearchHR()
        If Dashboard.CheckHistoryByID.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE `empID` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByName.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `Name` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE `Name` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByPurpose.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE `clearPurpose` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
        If Dashboard.CheckHistoryByDepartment.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `dept` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE `dept` Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByApprove.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
                `BDGDeptStatus` = '" & Dashboard.approve & "' OR 
        `SDGSuperStatus` = '" & Dashboard.approve & "' OR 
          `SDGDeptStatus` = '" & Dashboard.approve & "' OR 
          `ITOPSDeptStatus` = '" & Dashboard.approve & "' OR 
      `PMGDeptStatus` = '" & Dashboard.approve & "' OR 
      `MarketingDeptStatus` = '" & Dashboard.approve & "' OR 
          `FINANCEHeadStatus` = '" & Dashboard.approve & "' OR 
      `FINANCEDeptStatus` = '" & Dashboard.approve & "' OR 
      `AdminGroupStatus` = '" & Dashboard.approve & "' OR 
      `SysAdminStatus` = '" & Dashboard.approve & "' OR 
      `AdminHeadStatus` = '" & Dashboard.approve & "' OR 
      `SysAdminHeadStatus` = '" & Dashboard.approve & "' OR 
      `HRHeadStatus` = '" & Dashboard.approve & "' OR 
      `HRGroupStatus` = '" & Dashboard.approve & "' ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
                   `BDGDeptStatus` = '" & Dashboard.approve & "' OR 
      `SDGSuperStatus` = '" & Dashboard.approve & "' OR 
      `SDGDeptStatus` = '" & Dashboard.approve & "' OR 
      `ITOPSDeptStatus` = '" & Dashboard.approve & "' OR 
      `PMGDeptStatus` = '" & Dashboard.approve & "' OR 
      `MarketingDeptStatus` = '" & Dashboard.approve & "' OR 
      `FINANCEHeadStatus` = '" & Dashboard.approve & "' OR 
      `FINANCEDeptStatus` = '" & Dashboard.approve & "' OR 
      `AdminGroupStatus` = '" & Dashboard.approve & "' OR 
      `SysAdminStatus` = '" & Dashboard.approve & "' OR 
      `AdminHeadStatus` = '" & Dashboard.approve & "' OR 
      `SysAdminHeadStatus` = '" & Dashboard.approve & "' OR 
      `HRHeadStatus` = '" & Dashboard.approve & "' OR 
      `HRGroupStatus` = '" & Dashboard.approve & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If

        If Dashboard.CheckHistoryByRejected.Checked = True Then

            If Dashboard.TextBoxSearchHistory.Text = Nothing Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
        `BDGDeptStatus` = '" & Dashboard.reject & "' OR 
      `SDGSuperStatus` = '" & Dashboard.reject & "' OR 
      `SDGDeptStatus` = '" & Dashboard.reject & "' OR 
      `ITOPSDeptStatus` = '" & Dashboard.reject & "' OR 
      `PMGDeptStatus` = '" & Dashboard.reject & "' OR 
      `MarketingDeptStatus` = '" & Dashboard.reject & "' OR 
      `FINANCEHeadStatus` = '" & Dashboard.reject & "' OR 
      `FINANCEDeptStatus` = '" & Dashboard.reject & "' OR 
      `AdminGroupStatus` = '" & Dashboard.reject & "' OR 
      `SysAdminStatus` = '" & Dashboard.reject & "' OR 
      `AdminHeadStatus` = '" & Dashboard.reject & "' OR 
      `SysAdminHeadStatus` = '" & Dashboard.reject & "' OR 
      `HRHeadStatus` = '" & Dashboard.reject & "' OR 
      `HRGroupStatus` = '" & Dashboard.reject & "' ORDER BY `empID` ASC"
                fillGridHistory(query)

            Else

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
`BDGDeptStatus` = '" & Dashboard.reject & "' OR 
      `SDGSuperStatus` = '" & Dashboard.reject & "' OR 
      `SDGDeptStatus` = '" & Dashboard.reject & "' OR 
      `ITOPSDeptStatus` = '" & Dashboard.reject & "' OR 
      `PMGDeptStatus` = '" & Dashboard.reject & "' OR 
      `MarketingDeptStatus` = '" & Dashboard.reject & "' OR 
      `FINANCEHeadStatus` = '" & Dashboard.reject & "' OR 
      `FINANCEDeptStatus` = '" & Dashboard.reject & "' OR 
      `AdminGroupStatus` = '" & Dashboard.reject & "' OR 
      `SysAdminStatus` = '" & Dashboard.reject & "' OR 
      `AdminHeadStatus` = '" & Dashboard.reject & "' OR 
      `SysAdminHeadStatus` = '" & Dashboard.reject & "' OR 
      `HRHeadStatus` = '" & Dashboard.reject & "' OR 
      `HRGroupStatus` = '" & Dashboard.reject & "' Like '%" & Dashboard.TextBoxSearchHistory.Text & "%'"
                fillGridHistory(query)

            End If

        End If
    End Sub

    Public Sub HistorySearchGroup()

    End Sub
End Module

