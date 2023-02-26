Public Class CompleteRequest
    Dim comp As New CompleteClass
    Private Sub CompleteRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comp.LabelHRName()
        comp.LabelHRStatus()
        comp.LabelHRComment()
        comp.LabelHRDate()
        comp.LabelCheckBox()
    End Sub

    Private Sub LabelBDGStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelBDGStatus.TextChanged
        If LabelBDGStatus.Text = "Pending" Then
            LabelBDGStatus.BackColor = Color.PowderBlue
        ElseIf LabelBDGStatus.Text = "Approve" Then
            LabelBDGStatus.BackColor = Color.Lime
        Else
            LabelBDGStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelSDGSuperStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelSDGSuperStatus.TextChanged
        If LabelSDGSuperStatus.Text = "Pending" Then
            LabelSDGSuperStatus.BackColor = Color.PowderBlue
        ElseIf LabelSDGSuperStatus.Text = "Approve" Then
            LabelSDGSuperStatus.BackColor = Color.Lime
        Else
            LabelSDGSuperStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelSDGStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelSDGStatus.TextChanged
        If LabelSDGStatus.Text = "Pending" Then
            LabelSDGStatus.BackColor = Color.PowderBlue
        ElseIf LabelSDGStatus.Text = "Approve" Then
            LabelSDGStatus.BackColor = Color.Lime
        Else
            LabelSDGStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelITOPSStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelITOPSStatus.TextChanged
        If LabelITOPSStatus.Text = "Pending" Then
            LabelITOPSStatus.BackColor = Color.PowderBlue
        ElseIf LabelITOPSStatus.Text = "Approve" Then
            LabelITOPSStatus.BackColor = Color.Lime
        Else
            LabelITOPSStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelPMGStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelPMGStatus.TextChanged
        If LabelPMGStatus.Text = "Pending" Then
            LabelPMGStatus.BackColor = Color.PowderBlue
        ElseIf LabelPMGStatus.Text = "Approve" Then
            LabelPMGStatus.BackColor = Color.Lime
        Else
            LabelPMGStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelMarketingStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelMarketingStatus.TextChanged
        If LabelMarketingStatus.Text = "Pending" Then
            LabelMarketingStatus.BackColor = Color.PowderBlue
        ElseIf LabelMarketingStatus.Text = "Approve" Then
            LabelMarketingStatus.BackColor = Color.Lime
        Else
            LabelMarketingStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelFinanceStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelFinanceStatus.TextChanged
        If LabelFinanceStatus.Text = "Pending" Then
            LabelFinanceStatus.BackColor = Color.PowderBlue
        ElseIf LabelFinanceStatus.Text = "Approve" Then
            LabelFinanceStatus.BackColor = Color.Lime
        Else
            LabelFinanceStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelFinanceHeadStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelFinanceHeadStatus.TextChanged
        If LabelFinanceHeadStatus.Text = "Pending" Then
            LabelFinanceHeadStatus.BackColor = Color.PowderBlue
        ElseIf LabelFinanceHeadStatus.Text = "Approve" Then
            LabelFinanceHeadStatus.BackColor = Color.Lime
        Else
            LabelFinanceHeadStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelAdminStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminStatus.TextChanged
        If LabelAdminStatus.Text = "Pending" Then
            LabelAdminStatus.BackColor = Color.PowderBlue
        ElseIf LabelAdminStatus.Text = "Approve" Then
            LabelAdminStatus.BackColor = Color.Lime
        Else
            LabelAdminStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelAdminHeadStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminHeadStatus.TextChanged
        If LabelAdminHeadStatus.Text = "Pending" Then
            LabelAdminHeadStatus.BackColor = Color.PowderBlue
        ElseIf LabelAdminHeadStatus.Text = "Approve" Then
            LabelAdminHeadStatus.BackColor = Color.Lime
        Else
            LabelAdminHeadStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelSysAdminStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminStatus.TextChanged
        If LabelSysAdminStatus.Text = "Pending" Then
            LabelSysAdminStatus.BackColor = Color.PowderBlue
        ElseIf LabelSysAdminStatus.Text = "Approve" Then
            LabelSysAdminStatus.BackColor = Color.Lime
        Else
            LabelSysAdminStatus.BackColor = Color.Firebrick

        End If
    End Sub



    Private Sub LabelSysAdminHeadStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminHeadStatus.TextChanged
        If LabelSysAdminHeadStatus.Text = "Pending" Then
            LabelSysAdminHeadStatus.BackColor = Color.PowderBlue
        ElseIf LabelSysAdminHeadStatus.Text = "Approve" Then
            LabelSysAdminHeadStatus.BackColor = Color.Lime
        Else
            LabelSysAdminHeadStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelHRGroupStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelHRGroupStatus.TextChanged
        If LabelHRGroupStatus.Text = "Pending" Then
            LabelHRGroupStatus.BackColor = Color.PowderBlue
        ElseIf LabelHRGroupStatus.Text = "Approve" Then
            LabelHRGroupStatus.BackColor = Color.Lime
        Else
            LabelHRGroupStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelHRHeadStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelHRHeadStatus.TextChanged
        If LabelHRHeadStatus.Text = "Pending" Then
            LabelHRHeadStatus.BackColor = Color.PowderBlue
        ElseIf LabelHRHeadStatus.Text = "Approve" Then
            LabelHRHeadStatus.BackColor = Color.Lime
        Else
            LabelHRHeadStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelHRInterviewStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelHRInterviewStatus.TextChanged
        If LabelHRInterviewStatus.Text = "Pending" Then
            LabelHRInterviewStatus.BackColor = Color.PowderBlue
        ElseIf LabelHRInterviewStatus.Text = "Scheduled" Then
            LabelHRInterviewStatus.BackColor = Color.Lime
        Else
            LabelHRInterviewStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub LabelFinalStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelFinalStatus.TextChanged
        If LabelFinalStatus.Text = "Pending" Then
            LabelFinalStatus.BackColor = Color.PowderBlue
        ElseIf LabelFinalStatus.Text = "Interviewed" Then
            LabelFinalStatus.BackColor = Color.Lime
        Else
            LabelFinalStatus.BackColor = Color.Firebrick

        End If
    End Sub

    Private Sub CheckBoxCashAdv_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCashAdv.CheckedChanged
        If CheckBoxCashAdv.Checked = True Then
            CheckBoxCashAdv.BackColor = Color.Lime
        ElseIf CheckBoxCashAdv.Checked = False Then
            CheckBoxCashAdv.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxFinanceOther_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFinanceOther.CheckedChanged
        If CheckBoxFinanceOther.Checked = True Then
            CheckBoxFinanceOther.BackColor = Color.Lime
        ElseIf CheckBoxFinanceOther.Checked = False Then
            CheckBoxFinanceOther.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxTelco_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTelco.CheckedChanged
        If CheckBoxTelco.Checked = True Then
            CheckBoxTelco.BackColor = Color.Lime
        ElseIf CheckBoxTelco.Checked = False Then
            CheckBoxTelco.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxTools_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTools.CheckedChanged
        If CheckBoxTools.Checked = True Then
            CheckBoxTools.BackColor = Color.Lime
        ElseIf CheckBoxTools.Checked = False Then
            CheckBoxTools.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxTable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTable.CheckedChanged
        If CheckBoxTable.Checked = True Then
            CheckBoxTable.BackColor = Color.Lime
        ElseIf CheckBoxTable.Checked = False Then
            CheckBoxTable.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxPhone_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPhone.CheckedChanged
        If CheckBoxPhone.Checked = True Then
            CheckBoxPhone.BackColor = Color.Lime
        ElseIf CheckBoxPhone.Checked = False Then
            CheckBoxPhone.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxOthers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOthers.CheckedChanged
        If CheckBoxOthers.Checked = True Then
            CheckBoxOthers.BackColor = Color.Lime
        ElseIf CheckBoxOthers.Checked = False Then
            CheckBoxOthers.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxLaptop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLaptop.CheckedChanged
        If CheckBoxLaptop.Checked = True Then
            CheckBoxLaptop.BackColor = Color.Lime
        ElseIf CheckBoxLaptop.Checked = False Then
            CheckBoxLaptop.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmail.CheckedChanged
        If CheckBoxEmail.Checked = True Then
            CheckBoxEmail.BackColor = Color.Lime
        ElseIf CheckBoxEmail.Checked = False Then
            CheckBoxEmail.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxComputer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxComputer.CheckedChanged
        If CheckBoxComputer.Checked = True Then
            CheckBoxComputer.BackColor = Color.Lime
        ElseIf CheckBoxComputer.Checked = False Then
            CheckBoxComputer.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxHMO_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHMO.CheckedChanged
        If CheckBoxHMO.Checked = True Then
            CheckBoxHMO.BackColor = Color.Lime
        ElseIf CheckBoxHMO.Checked = False Then
            CheckBoxHMO.BackColor = Color.Gray
        End If
    End Sub


    Private Sub CheckBoxCompanyID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompanyID.CheckedChanged
        If CheckBoxCompanyID.Checked = True Then
            CheckBoxCompanyID.BackColor = Color.Lime
        ElseIf CheckBoxCompanyID.Checked = False Then
            CheckBoxCompanyID.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInsurance.CheckedChanged
        If CheckBoxInsurance.Checked = True Then
            CheckBoxInsurance.BackColor = Color.Lime
        ElseIf CheckBoxInsurance.Checked = False Then
            CheckBoxInsurance.BackColor = Color.Gray
        End If
    End Sub



    Private Sub CheckBoxQuitClaim_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxQuitClaim.CheckedChanged
        If CheckBoxQuitClaim.Checked = True Then
            CheckBoxQuitClaim.BackColor = Color.Lime
        ElseIf CheckBoxQuitClaim.Checked = False Then
            CheckBoxQuitClaim.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxITR_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxITR.CheckedChanged
        If CheckBoxITR.Checked = True Then
            CheckBoxITR.BackColor = Color.Lime
        ElseIf CheckBoxITR.Checked = False Then
            CheckBoxITR.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxCOE_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCOE.CheckedChanged
        If CheckBoxCOE.Checked = True Then
            CheckBoxCOE.BackColor = Color.Lime
        ElseIf CheckBoxCOE.Checked = False Then
            CheckBoxCOE.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxFinalPay_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFinalPay.CheckedChanged
        If CheckBoxFinalPay.Checked = True Then
            CheckBoxFinalPay.BackColor = Color.Lime
        ElseIf CheckBoxFinalPay.Checked = False Then
            CheckBoxFinalPay.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxInterview_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInterview.CheckedChanged
        If CheckBoxInterview.Checked = True Then
            CheckBoxInterview.BackColor = Color.Lime
        ElseIf CheckBoxInterview.Checked = False Then
            CheckBoxInterview.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBoxFinal_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFinal.CheckedChanged
        If CheckBoxFinal.Checked = True Then
            CheckBoxFinal.BackColor = Color.Lime
        ElseIf CheckBoxFinal.Checked = False Then
            CheckBoxFinal.BackColor = Color.Gray
        End If
    End Sub

    Private Sub CompleteRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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