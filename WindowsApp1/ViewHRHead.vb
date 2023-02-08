
Public Class ViewHRHead
    Dim apdb As New ApprovalDB


    Dim insertNextFlow As String
    Dim updateHistory As String


    Dim HRHeadNameAccept As String
    Dim HRHeadStatAccept As String
    Dim HRHeadCommentAccept As String
    Dim HRHeadDateAccept As String

    'Approve

    Private Sub btnHRGroupApp_Click(sender As Object, e As EventArgs) Handles btnHRHeadApp.Click
        HRHeadStatAccept = "Approve"

        HRHeadNameAccept = LabelHRHeadName.Text

        HRHeadCommentAccept = txtboxHRHead.Text

        HRHeadDateAccept = Date.Today

        LabelHRHeadApp.Text = HRHeadStatAccept

        LabelDateHRHead.Text = HRHeadDateAccept

        LabelHRHeadComment.Text = txtboxHRHead.Text

        updateHistory = "UPDATE `historyrequest` SET `HRHeadName`=@name, `HRHeadStatus`=@status, `HRHeadComment`=@comment, `HRHeadDate`=@dateapp WHERE empID ='" & LabelEmpID.Text & "'"
        apdb.updateHistory(HRHeadNameAccept, HRHeadStatAccept, HRHeadDateAccept, HRHeadCommentAccept, updateHistory)

        insertNextFlow = "INSERT INTO `completerequest`(`id`,`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDate`) 
        SELECT `id`,`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDate` FROM historyrequest WHERE empID='" & LabelEmpID.Text & "'"
        apdb.insertcompleterequest(insertNextFlow)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        Dim deletehistory As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.queryhistory)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnHRHeadApp.Visible = False
        btnHRHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelHRHeadComment.Visible = True

        txtboxHRHead.Visible = False
        txtboxHRHead.Text = ""


    End Sub

    'End of Approve





    'Reject

    Private Sub btnHRGroupReject_Click(sender As Object, e As EventArgs) Handles btnHRHeadReject.Click
        HRHeadStatAccept = "Reject"

        HRHeadNameAccept = LabelHRHeadName.Text

        HRHeadCommentAccept = txtboxHRHead.Text

        HRHeadDateAccept = Date.Today

        LabelHRHeadApp.Text = HRHeadStatAccept

        LabelDateHRHead.Text = HRHeadDateAccept

        LabelHRHeadComment.Text = txtboxHRHead.Text

        updateHistory = "UPDATE `historyrequest` SET `HRHeadName`=@name, `HRHeadStatus`=@status, `HRHeadComment`=@comment, `HRHeadDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHistory(HRHeadNameAccept, HRHeadStatAccept, HRHeadDateAccept, HRHeadCommentAccept, updateHistory)

        insertNextFlow = "INSERT INTO `completerequest`(`id`,`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDate`) 
        SELECT `id`,`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDate` FROM historyrequest WHERE empID='" & LabelEmpID.Text & "'"
        apdb.insertcompleterequest(insertNextFlow)

        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnHRHeadApp.Visible = False
        btnHRHeadReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        LabelHRHeadComment.Visible = True

        txtboxHRHead.Visible = False
        txtboxHRHead.Text = ""

    End Sub


    'End of Reject



    Private Sub LabelHRHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRHeadApp.TextChanged
        If LabelHRHeadApp.Text = "Pending" Then
            LabelHRHeadApp.BackColor = Color.PowderBlue
        ElseIf LabelHRHeadApp.Text = "Approve" Then
            LabelHRHeadApp.BackColor = Color.Lime
        Else
            LabelHRHeadApp.BackColor = Color.Firebrick

        End If
    End Sub


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnHRHeadApp.Visible = True
        btnHRHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRHeadApp.Text = "Pending"
        LabelHRHeadComment.Text = ""
        LabelDateHRHead.Text = ""
        LabelHRHeadComment.Visible = False


        txtboxHRHead.Visible = True
        txtboxHRHead.Text = ""
        Me.Close()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnHRHeadApp.Visible = True
        btnHRHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRHeadApp.Text = "Pending"
        LabelHRHeadComment.Text = ""
        LabelDateHRHead.Text = ""
        LabelHRHeadComment.Visible = False


        txtboxHRHead.Visible = True
        txtboxHRHead.Text = ""
        Me.Close()
    End Sub

    Private Sub ViewHRHead_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnHRHeadApp.Visible = True
        btnHRHeadReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRHeadApp.Text = "Pending"
        LabelHRHeadComment.Text = ""
        LabelDateHRHead.Text = ""
        LabelHRHeadComment.Visible = False


        txtboxHRHead.Visible = True
        txtboxHRHead.Text = ""

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