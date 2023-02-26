Imports MySql.Data.MySqlClient
Public Class CompleteClass
    Dim dbs As New db
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim x As Integer

    Public Sub LabelHRName()
        Dim sql As String = "SELECT BDGDeptName, SDGSuperName, SDGDeptName, ITOPSDeptName, PMGDeptName, MarketingDeptName, FinanceHeadName, FinanceDeptName, AdminGroupName, AdminHeadName, SysAdminName, SysAdminHeadName, HRHeadName, HRGroupName, ScheduleInterviewerName, ExitInterviewBy FROM completerequest WHERE empID='" & CompleteRequest.LabelEmpID.Text & "'"

        Dim cmd As New MySqlCommand(sql, dbs.getconn())
        dbs.opencon()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            CompleteRequest.LabelBDGName.Text = If(String.IsNullOrEmpty(reader("BDGDeptName").ToString()), "Pending", reader("BDGDeptName").ToString())
            CompleteRequest.LabelSDGSuperName.Text = If(String.IsNullOrEmpty(reader("SDGSuperName").ToString()), "Pending", reader("SDGSuperName").ToString())
            CompleteRequest.LabelSDGName.Text = If(String.IsNullOrEmpty(reader("SDGDeptName").ToString()), "Pending", reader("SDGDeptName").ToString())
            CompleteRequest.LabelITOPSName.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptName").ToString()), "Pending", reader("ITOPSDeptName").ToString())
            CompleteRequest.LabelPMGName.Text = If(String.IsNullOrEmpty(reader("PMGDeptName").ToString()), "Pending", reader("PMGDeptName").ToString())
            CompleteRequest.LabelMarketingName.Text = If(String.IsNullOrEmpty(reader("MarketingDeptName").ToString()), "Pending", reader("MarketingDeptName").ToString())
            CompleteRequest.LabelFinanceHeadName.Text = If(String.IsNullOrEmpty(reader("FinanceHeadName").ToString()), "Pending", reader("FinanceHeadName").ToString())
            CompleteRequest.LabelFinanceName.Text = If(String.IsNullOrEmpty(reader("FinanceDeptName").ToString()), "Pending", reader("FinanceDeptName").ToString())
            CompleteRequest.LabelAdminName.Text = If(String.IsNullOrEmpty(reader("AdminGroupName").ToString()), "Pending", reader("AdminGroupName").ToString())
            CompleteRequest.LabelAdminHeadName.Text = If(String.IsNullOrEmpty(reader("AdminHeadName").ToString()), "Pending", reader("AdminHeadName").ToString())
            CompleteRequest.LabelSysAdminName.Text = If(String.IsNullOrEmpty(reader("SysAdminName").ToString()), "Pending", reader("SysAdminName").ToString())
            CompleteRequest.LabelSysAdminHeadName.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadName").ToString()), "Pending", reader("SysAdminHeadName").ToString())
            CompleteRequest.LabelHRGroupName.Text = If(String.IsNullOrEmpty(reader("HRGroupName").ToString()), "Pending", reader("HRGroupName").ToString())
            CompleteRequest.LabelHRHeadName.Text = If(String.IsNullOrEmpty(reader("HRHeadName").ToString()), "Pending", reader("HRHeadName").ToString())
            CompleteRequest.LabelHRInterviewName.Text = If(String.IsNullOrEmpty(reader("ScheduleInterviewerName").ToString()), "Pending", reader("ScheduleInterviewerName").ToString())
            CompleteRequest.LabelFinalName.Text = If(String.IsNullOrEmpty(reader("ExitInterviewBy").ToString()), "Pending", reader("ExitInterviewBy").ToString())

        End While


        reader.Close()
        dbs.closecon()


    End Sub

    Public Sub LabelHRStatus()
        Dim sql As String = "SELECT BDGDeptStatus, SDGSuperStatus, SDGDeptStatus, ITOPSDeptStatus, PMGDeptStatus, MarketingDeptStatus, FinanceHeadStatus, FinanceDeptStatus, AdminGroupStatus, AdminHeadStatus, SysAdminStatus, SysAdminHeadStatus, HRHeadStatus, HRGroupStatus, ScheduleInterviewStatus, ExitInterviewStatus FROM completerequest WHERE empID='" & CompleteRequest.LabelEmpID.Text & "'"

        Dim cmd As New MySqlCommand(sql, dbs.getconn())
        dbs.opencon()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            CompleteRequest.LabelBDGStatus.Text = If(String.IsNullOrEmpty(reader("BDGDeptStatus").ToString()), "Pending", reader("BDGDeptStatus").ToString())
            CompleteRequest.LabelSDGSuperStatus.Text = If(String.IsNullOrEmpty(reader("SDGSuperStatus").ToString()), "Pending", reader("SDGSuperStatus").ToString())
            CompleteRequest.LabelSDGStatus.Text = If(String.IsNullOrEmpty(reader("SDGDeptStatus").ToString()), "Pending", reader("SDGDeptStatus").ToString())
            CompleteRequest.LabelITOPSStatus.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptStatus").ToString()), "Pending", reader("ITOPSDeptStatus").ToString())
            CompleteRequest.LabelPMGStatus.Text = If(String.IsNullOrEmpty(reader("PMGDeptStatus").ToString()), "Pending", reader("PMGDeptStatus").ToString())
            CompleteRequest.LabelMarketingStatus.Text = If(String.IsNullOrEmpty(reader("MarketingDeptStatus").ToString()), "Pending", reader("MarketingDeptStatus").ToString())
            CompleteRequest.LabelFinanceHeadStatus.Text = If(String.IsNullOrEmpty(reader("FinanceHeadStatus").ToString()), "Pending", reader("FinanceHeadStatus").ToString())
            CompleteRequest.LabelFinanceStatus.Text = If(String.IsNullOrEmpty(reader("FinanceDeptStatus").ToString()), "Pending", reader("FinanceDeptStatus").ToString())
            CompleteRequest.LabelAdminStatus.Text = If(String.IsNullOrEmpty(reader("AdminGroupStatus").ToString()), "Pending", reader("AdminGroupStatus").ToString())
            CompleteRequest.LabelAdminHeadStatus.Text = If(String.IsNullOrEmpty(reader("AdminHeadStatus").ToString()), "Pending", reader("AdminHeadStatus").ToString())
            CompleteRequest.LabelSysAdminStatus.Text = If(String.IsNullOrEmpty(reader("SysAdminStatus").ToString()), "Pending", reader("SysAdminStatus").ToString())
            CompleteRequest.LabelSysAdminHeadStatus.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadStatus").ToString()), "Pending", reader("SysAdminHeadStatus").ToString())
            CompleteRequest.LabelHRGroupStatus.Text = If(String.IsNullOrEmpty(reader("HRGroupStatus").ToString()), "Pending", reader("HRGroupStatus").ToString())
            CompleteRequest.LabelHRHeadStatus.Text = If(String.IsNullOrEmpty(reader("HRHeadStatus").ToString()), "Pending", reader("HRHeadStatus").ToString())
            CompleteRequest.LabelHRInterviewStatus.Text = If(String.IsNullOrEmpty(reader("ScheduleInterviewStatus").ToString()), "Pending", reader("ScheduleInterviewStatus").ToString())
            CompleteRequest.LabelFinalStatus.Text = If(String.IsNullOrEmpty(reader("ExitInterviewStatus").ToString()), "Pending", reader("ExitInterviewStatus").ToString())

        End While

        reader.Close()
        dbs.closecon()


    End Sub

    Public Sub LabelHRComment()
        Dim sql As String = "SELECT BDGDeptComment, SDGSuperComment, SDGDeptComment, ITOPSDeptComment, PMGDeptComment, MarketingDeptComment, FinanceHeadComment, FinanceDeptComment, AdminGroupComment, AdminHeadComment, SysAdminComment, SysAdminHeadComment, HRHeadComment, HRGroupComment FROM completerequest WHERE empID='" & CompleteRequest.LabelEmpID.Text & "'"

        Dim cmd As New MySqlCommand(sql, dbs.getconn())
        dbs.opencon()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            CompleteRequest.LabelBDGComment.Text = If(String.IsNullOrEmpty(reader("BDGDeptComment").ToString()), "Pending", reader("BDGDeptComment").ToString())
            CompleteRequest.LabelSDGSuperComment.Text = If(String.IsNullOrEmpty(reader("SDGSuperComment").ToString()), "Pending", reader("SDGSuperComment").ToString())
            CompleteRequest.LabelSDGComment.Text = If(String.IsNullOrEmpty(reader("SDGDeptComment").ToString()), "Pending", reader("SDGDeptComment").ToString())
            CompleteRequest.LabelITOPSComment.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptComment").ToString()), "Pending", reader("ITOPSDeptComment").ToString())
            CompleteRequest.LabelPMGComment.Text = If(String.IsNullOrEmpty(reader("PMGDeptComment").ToString()), "Pending", reader("PMGDeptComment").ToString())
            CompleteRequest.LabelMarketingComment.Text = If(String.IsNullOrEmpty(reader("MarketingDeptComment").ToString()), "Pending", reader("MarketingDeptComment").ToString())
            CompleteRequest.LabelFinanceHeadComment.Text = If(String.IsNullOrEmpty(reader("FinanceHeadComment").ToString()), "Pending", reader("FinanceHeadComment").ToString())
            CompleteRequest.LabelFinanceComment.Text = If(String.IsNullOrEmpty(reader("FinanceDeptComment").ToString()), "Pending", reader("FinanceDeptComment").ToString())
            CompleteRequest.LabelAdminComment.Text = If(String.IsNullOrEmpty(reader("AdminGroupComment").ToString()), "Pending", reader("AdminGroupComment").ToString())
            CompleteRequest.LabelAdminHeadComment.Text = If(String.IsNullOrEmpty(reader("AdminHeadComment").ToString()), "Pending", reader("AdminHeadComment").ToString())
            CompleteRequest.LabelSysAdminComment.Text = If(String.IsNullOrEmpty(reader("SysAdminComment").ToString()), "Pending", reader("SysAdminComment").ToString())
            CompleteRequest.LabelSysAdminHeadComment.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadComment").ToString()), "Pending", reader("SysAdminHeadComment").ToString())
            CompleteRequest.LabelHRGroupComment.Text = If(String.IsNullOrEmpty(reader("HRGroupComment").ToString()), "Pending", reader("HRGroupComment").ToString())
            CompleteRequest.LabelHRHeadComment.Text = If(String.IsNullOrEmpty(reader("HRHeadComment").ToString()), "Pending", reader("HRHeadComment").ToString())


        End While

        reader.Close()
        dbs.closecon()



    End Sub

    Public Sub LabelHRDate()
        Dim sql As String = "SELECT BDGDeptDate, SDGSuperDate, SDGDeptDate, ITOPSDeptDate, PMGDeptDate, MarketingDeptDate, FinanceHeadDate, FinanceDeptDate, AdminGroupDate, AdminHeadDate, SysAdminDate, SysAdminHeadDate, HRHeadDate, HRGroupDate, ScheduleInterviewDate, ExitInterviewDate FROM completerequest WHERE empID='" & CompleteRequest.LabelEmpID.Text & "'"

        Dim cmd As New MySqlCommand(sql, dbs.getconn())
        dbs.opencon()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            CompleteRequest.LabelBDGDate.Text = If(String.IsNullOrEmpty(reader("BDGDeptDate").ToString()), "Pending", DateTime.Parse(reader("BDGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelSDGSuperDate.Text = If(String.IsNullOrEmpty(reader("SDGSuperDate").ToString()), "Pending", DateTime.Parse(reader("SDGSuperDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelSDGDate.Text = If(String.IsNullOrEmpty(reader("SDGDeptDate").ToString()), "Pending", DateTime.Parse(reader("SDGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelITOPSDate.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptDate").ToString()), "Pending", DateTime.Parse(reader("ITOPSDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelPMGDate.Text = If(String.IsNullOrEmpty(reader("PMGDeptDate").ToString()), "Pending", DateTime.Parse(reader("PMGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelMarketingDate.Text = If(String.IsNullOrEmpty(reader("MarketingDeptDate").ToString()), "Pending", DateTime.Parse(reader("MarketingDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelFinanceHeadDate.Text = If(String.IsNullOrEmpty(reader("FinanceHeadDate").ToString()), "Pending", DateTime.Parse(reader("FinanceHeadDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelFinanceDate.Text = If(String.IsNullOrEmpty(reader("FinanceDeptDate").ToString()), "Pending", DateTime.Parse(reader("FinanceDeptDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelAdminDate.Text = If(String.IsNullOrEmpty(reader("AdminGroupDate").ToString()), "Pending", DateTime.Parse(reader("AdminGroupDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelAdminHeadDate.Text = If(String.IsNullOrEmpty(reader("AdminHeadDate").ToString()), "Pending", DateTime.Parse(reader("AdminHeadDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelSysAdminDate.Text = If(String.IsNullOrEmpty(reader("SysAdminDate").ToString()), "Pending", DateTime.Parse(reader("SysAdminDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelSysAdminHeadDate.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadDate").ToString()), "Pending", DateTime.Parse(reader("SysAdminHeadDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelHRGroupDate.Text = If(String.IsNullOrEmpty(reader("HRGroupDate").ToString()), "Pending", DateTime.Parse(reader("HRGroupDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelHRHeadDate.Text = If(String.IsNullOrEmpty(reader("HRHeadDate").ToString()), "Pending", DateTime.Parse(reader("HRHeadDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelHRInterviewDate.Text = If(String.IsNullOrEmpty(reader("ScheduleInterviewDate").ToString()), "Pending", DateTime.Parse(reader("ScheduleInterviewDate").ToString()).ToString("MMM-dd-yyyy"))
            CompleteRequest.LabelFinalDate.Text = If(String.IsNullOrEmpty(reader("ExitInterviewDate").ToString()), "Pending", DateTime.Parse(reader("ExitInterviewDate").ToString()).ToString("MMM-dd-yyyy"))

        End While

        reader.Close()
        dbs.closecon()
    End Sub

    Public Sub LabelCheckBox()
        Dim sql As String = "SELECT `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewStatus`, `ExitInterviewStatus` FROM completerequest WHERE empID='" & CompleteRequest.LabelEmpID.Text & "'"

        Dim cmd As New MySqlCommand(sql, dbs.getconn())
        dbs.opencon()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim cashAdvanceValue As String = reader("CashAdvance").ToString()
            If String.Equals(cashAdvanceValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCashAdv.Checked = True
            ElseIf String.Equals(cashAdvanceValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCashAdv.Checked = False
            End If

            Dim financeOtherValue As String = reader("FinanceDeptOthers").ToString()
            If String.Equals(financeOtherValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinanceOther.Checked = True
            ElseIf String.Equals(financeOtherValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinanceOther.Checked = False
            End If

            CompleteRequest.TextBoxFinanceOther.Text = reader("FinanceDeptOtherComment").ToString()

            Dim checkTelecoValue As String = reader("CheckTeleco").ToString()
            If String.Equals(checkTelecoValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTelco.Checked = True
            ElseIf String.Equals(checkTelecoValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTelco.Checked = False
            End If

            Dim checkToolsValue As String = reader("CheckTools").ToString
            If String.Equals(checkToolsValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTools.Checked = True
            ElseIf String.Equals(checkToolsValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTools.Checked = False
            End If

            Dim checkPhoneValue As String = reader("CheckPhone").ToString
            If String.Equals(checkPhoneValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxPhone.Checked = True
            ElseIf String.Equals(checkPhoneValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxPhone.Checked = False
            End If

            Dim checkTableValue As String = reader("CheckTable").ToString
            If String.Equals(checkTableValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTable.Checked = True
            ElseIf String.Equals(checkTableValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxTable.Checked = False
            End If

            Dim checkOthersValue As String = reader("CheckOthers").ToString
            If String.Equals(checkOthersValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxOthers.Checked = True
            ElseIf String.Equals(checkOthersValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxOthers.Checked = False
            End If

            CompleteRequest.txtboxOther.Text = reader("CheckOthersComment").ToString()

            Dim checkLaptopValue As String = reader("CheckLaptop").ToString
            If String.Equals(checkLaptopValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxLaptop.Checked = True
            ElseIf String.Equals(checkLaptopValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxLaptop.Checked = False
            End If

            Dim checkEmailValue As String = reader("CheckEmail").ToString()
            If String.Equals(checkEmailValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxEmail.Checked = True
            ElseIf String.Equals(checkEmailValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxEmail.Checked = False
            End If

            Dim checkComValue As String = reader("CheckCom").ToString()
            If String.Equals(checkComValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxComputer.Checked = True
            ElseIf String.Equals(checkComValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxComputer.Checked = False
            End If



            Dim checkHMOValue As String = reader("CheckHMO").ToString()
            If String.Equals(checkHMOValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxHMO.Checked = True
            ElseIf String.Equals(checkHMOValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxHMO.Checked = False
            End If

            Dim checkInsuranceValue As String = reader("CheckInsurance").ToString()
            If String.Equals(checkInsuranceValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxInsurance.Checked = True
            ElseIf String.Equals(checkInsuranceValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxInsurance.Checked = False
            End If

            Dim checkCompanyIDValue As String = reader("CheckCompanyID").ToString()
            If String.Equals(checkCompanyIDValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCompanyID.Checked = True
            ElseIf String.Equals(checkCompanyIDValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCompanyID.Checked = False
            End If

            Dim checkQuitClaimValue As String = reader("CheckQuitClaim").ToString()
            If String.Equals(checkQuitClaimValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxQuitClaim.Checked = True
            ElseIf String.Equals(checkQuitClaimValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxQuitClaim.Checked = False
            End If

            Dim checkCOEValue As String = reader("CheckCOE").ToString()
            If String.Equals(checkCOEValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCOE.Checked = True
            ElseIf String.Equals(checkCOEValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxCOE.Checked = False
            End If

            Dim checkITRValue As String = reader("CheckITR").ToString()
            If String.Equals(checkITRValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxITR.Checked = True
            ElseIf String.Equals(checkITRValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxITR.Checked = False
            End If

            Dim checkFinalPayValue As String = reader("CheckFinalPay").ToString()
            If String.Equals(checkFinalPayValue, "Checked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinalPay.Checked = True
            ElseIf String.Equals(checkFinalPayValue, "Unchecked", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinalPay.Checked = False
            End If

            Dim checkScheduleValue As String = reader("ScheduleInterviewStatus").ToString()
            If String.Equals(checkScheduleValue, "Scheduled", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxInterview.Checked = True
            ElseIf String.Equals(checkScheduleValue, "Pending", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxInterview.Checked = False
            End If

            Dim checkFinalValue As String = reader("ExitInterviewStatus").ToString()
            If String.Equals(checkFinalValue, "Interviewed", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinal.Checked = True
            ElseIf String.Equals(checkFinalValue, "Pending", StringComparison.OrdinalIgnoreCase) Then
                CompleteRequest.CheckBoxFinal.Checked = False
            End If

        End If

        reader.Close()
        dbs.closecon()
    End Sub


End Class
