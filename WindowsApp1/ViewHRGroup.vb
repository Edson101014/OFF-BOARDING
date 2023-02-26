Imports MySql.Data.MySqlClient
Public Class ViewHRGroup
    Dim apdb As New ApprovalDB
    Dim labeldata As New ClassLabel


    Dim checkHMO As String = "Unchecked"
    Dim checkInsurance As String = "Unchecked"
    Dim checkCompanyID As String = "Unchecked"
    Dim checkQuitClaim As String = "Unchecked"
    Dim checkCOE As String = "Unchecked"
    Dim checkITR As String = "Unchecked"
    Dim checkFinalPay As String = "Unchecked"



    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    Dim sql As String

    Dim HRNameAccept As String
    Dim HRStatAccept As String
    Dim HRCommentAccept As String
    Dim HRDateAccept As Date

    Private WithEvents refreshTimer As New Timer()

    Sub getdata()








        ''COMMENT
        'sql = "select BDGDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(BDGComment, sql)

        'sql = "select SDGSuperComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(SDGHeadComment, sql)

        'sql = "select SDGDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(SDGComment, sql)

        'sql = "select ITOPSDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(ITOPSComment, sql)

        'sql = "select PMGDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(PMGComment, sql)

        'sql = "select MarketingDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(MarketingComment, sql)

        'sql = "select FinanceHeadComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(FinanceHeadComment, sql)

        'sql = "select FinanceDeptComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(FinanceComment, sql)

        'sql = "select AdminGroupComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(AdminComment, sql)

        'sql = "select AdminHeadComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(AdminHeadComment, sql)

        'sql = "select SysAdminComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(SysAdminComment, sql)

        'sql = "select SysAdminHeadComment from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelComment(SysAdminHeadComment, sql)

        ''End of Comment

        ''DATE

        'sql = "select BDGDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(BDGDate, sql)

        'sql = "select SDGSuperDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(SDGHeadDate, sql)

        'sql = "select SDGDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(SDGDate, sql)

        'sql = "select ITOPSDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(ITOPSDate, sql)

        'sql = "select PMGDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(PMGDate, sql)

        'sql = "select MarketingDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(MarketingDate, sql)

        'sql = "select FinanceHeadDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(FinanceHeadDate, sql)

        'sql = "select FinanceDeptDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(FinanceDate, sql)

        'sql = "select AdminGroupDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(AdminDate, sql)

        'sql = "select AdminHeadDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(AdminHeadDate, sql)

        'sql = "select SysAdminDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(SysAdminDate, sql)

        'sql = "select SysAdminHeadDate from historyrequest where empID='" & LabelEmpID.Text & "'"
        'labeldata.LabelDate(SysAdminHeadDate, sql)

        ''END OF DATE

    End Sub

    Private Sub ViewHRGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labeldata.LabelHRName()
        labeldata.LabelHRStatus()
        labeldata.LabelHRComment()
        labeldata.LabelHRDate()

        ' Set the interval of the refresh timer to 5000ms (5 seconds)
        refreshTimer.Interval = 5000
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        labeldata.LabelHRName()
        labeldata.LabelHRStatus()
        labeldata.LabelHRComment()
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        labeldata.LabelHRName()
        labeldata.LabelHRStatus()
        labeldata.LabelHRComment()
        labeldata.LabelHRDate()
    End Sub

    Private Sub StartRefreshTimer()
        ' Start the refresh timer
        refreshTimer.Start()
    End Sub

    Private Sub StopRefreshTimer()
        ' Stop the refresh timer
        refreshTimer.Stop()
    End Sub
    Function verf() As Boolean
        Dim checker As Integer = 0

        If CheckBoxHMO.Checked = False Then
            CheckBoxHMO.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxInsurance.Checked = False Then
            CheckBoxInsurance.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxCompanyID.Checked = False Then
            CheckBoxCompanyID.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxQuitClaim.Checked = False Then
            CheckBoxQuitClaim.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxCOE.Checked = False Then
            CheckBoxCOE.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxITR.Checked = False Then
            CheckBoxITR.BackColor = Color.DarkRed
            checker += 1
        End If

        If CheckBoxFinalPay.Checked = False Then
            CheckBoxFinalPay.BackColor = Color.DarkRed
            checker += 1
        End If


        If checker > 0 Then
            Return False
        Else
            Return True
        End If


    End Function

    'Accept


    Private Sub btnHRGroupApp_Click(sender As Object, e As EventArgs) Handles btnHRGroupApp.Click

        If verfGroupAccept() = True Then
            If verf() = True Then
                HRNameAccept = LabelHRName.Text

                HRStatAccept = "Approve"

                HRCommentAccept = txtboxHRGroup.Text

                HRDateAccept = Date.Today

                LabelHRGroupApp.Text = HRStatAccept

                LabelDateHRGroup.Text = HRDateAccept

                LabelHRGroupComment.Text = txtboxHRGroup.Text

                statusNextflow = "Pending"

                updateHistory = "UPDATE `historyrequest` SET `HRGroupName`=@lblname, `HRGroupStatus`=@stats, `HRGroupComment`=@comment, `HRGroupDate`=@dateapp, `CheckHMO`=@checkHMO, `CheckInsurance`=@checkInsurance, `CheckCompanyID`=@checkCompanyID, `CheckQuitClaim`=@checkQuitClaim, `CheckCOE`=@checkCOE, `CheckITR`=@checkITR, `CheckFinalPay`=@checkFinalPay WHERE empID = '" & LabelEmpID.Text & "'"
                insertNextFlow = "INSERT INTO `hrhead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `hrheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
                apdb.updateHRHistory(HRNameAccept, HRStatAccept, HRCommentAccept, HRDateAccept, checkHMO, checkInsurance, checkCompanyID, checkQuitClaim, checkCOE, checkITR, checkFinalPay, updateHistory)

                apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)

                Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
                apdb.deleteRequest(LabelEmpID.Text, deletedt)

                btnHRGroupApp.Visible = False
                btnHRGroupReject.Visible = False
                ButtonCancel.Visible = False
                ButtonClose.Visible = True

                CheckBoxHMO.Enabled = False
                CheckBoxInsurance.Enabled = False
                CheckBoxCompanyID.Enabled = False
                CheckBoxQuitClaim.Enabled = False
                CheckBoxCOE.Enabled = False
                CheckBoxITR.Enabled = False
                CheckBoxFinalPay.Enabled = False

                LabelHRGroupComment.Visible = True

                txtboxHRGroup.Visible = False
                txtboxHRGroup.Text = ""

            Else
                MsgBox("Request can't approve!, Make sure all checkbox is checked", MsgBoxStyle.Exclamation, "Approve")
            End If
        Else
                MsgBox("Request can't approve!, Make sure all group is approve otherwise you cannot accept/reject", MsgBoxStyle.Exclamation, "Reject")
        End If

    End Sub





    'END OF ACCEPT



    'REJECT

    Private Sub btnHRGroupReject_Click(sender As Object, e As EventArgs) Handles btnHRGroupReject.Click


        HRNameAccept = LabelHRName.Text

        HRStatAccept = "Reject"

        HRCommentAccept = txtboxHRGroup.Text

        HRDateAccept = Date.Today

        LabelHRGroupApp.Text = HRStatAccept

        LabelDateHRGroup.Text = HRDateAccept

        LabelHRGroupComment.Text = txtboxHRGroup.Text


        updateHistory = "UPDATE `historyrequest` SET `HRGroupName`=@lblname, `HRGroupStatus`=@stats, `HRGroupComment`=@comment, `HRGroupDate`=@dateapp, `CheckHMO`=@checkHMO, `CheckInsurance`=@checkInsurance, `CheckCompanyID`=@checkCompanyID, `CheckQuitClaim`=@checkQuitClaim, `CheckCOE`=@checkCOE, `CheckITR`=@checkITR, `CheckFinalPay`=@checkFinalPay WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHRHistory(HRNameAccept, HRStatAccept, HRCommentAccept, HRDateAccept, checkHMO, checkInsurance, checkCompanyID, checkQuitClaim, checkCOE, checkITR, checkFinalPay, updateHistory)


        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
        apdb.deleteRequest(LabelEmpID.Text, deletedt)

        btnHRGroupApp.Visible = False
        btnHRGroupReject.Visible = False
        ButtonCancel.Visible = False
        ButtonClose.Visible = True

        CheckBoxHMO.Enabled = False
        CheckBoxInsurance.Enabled = False
        CheckBoxCompanyID.Enabled = False
        CheckBoxQuitClaim.Enabled = False
        CheckBoxCOE.Enabled = False
        CheckBoxITR.Enabled = False
        CheckBoxFinalPay.Enabled = False

        LabelHRGroupComment.Visible = True

        txtboxHRGroup.Visible = False
        txtboxHRGroup.Text = ""

    End Sub



    'END OF REJECT








    'EDIT APPROVE
    Private Sub ButtonEditApprove_Click(sender As Object, e As EventArgs) Handles ButtonEditApprove.Click

        If verfGroupAccept() = True Then
            If verf() = True Then

                HRNameAccept = LabelHRName.Text

                HRStatAccept = "Approve"

                HRCommentAccept = txtboxHRGroup.Text

                HRDateAccept = Date.Today

                LabelHRGroupApp.Text = HRStatAccept

                LabelDateHRGroup.Text = HRDateAccept

                LabelHRGroupComment.Text = txtboxHRGroup.Text


                updateHistory = "UPDATE `historyrequest` SET `HRGroupName`=@lblname, `HRGroupStatus`=@stats, `HRGroupComment`=@comment, `HRGroupDate`=@dateapp, `CheckHMO`=@checkHMO, `CheckInsurance`=@checkInsurance, `CheckCompanyID`=@checkCompanyID, `CheckQuitClaim`=@checkQuitClaim, `CheckCOE`=@checkCOE, `CheckITR`=@checkITR, `CheckFinalPay`=@checkFinalPay WHERE empID = '" & LabelEmpID.Text & "'"
                apdb.updateHRHistory(HRNameAccept, HRStatAccept, HRCommentAccept, HRDateAccept, checkHMO, checkInsurance, checkCompanyID, checkQuitClaim, checkCOE, checkITR, checkFinalPay, updateHistory)


                ButtonEdit.Visible = True
                ButtonEditApprove.Visible = False
                ButtonEditReject.Visible = False
                ButtonEditCancel.Visible = False
                ButtonClose.Visible = True

                CheckBoxHMO.Enabled = False
                CheckBoxInsurance.Enabled = False
                CheckBoxCompanyID.Enabled = False
                CheckBoxQuitClaim.Enabled = False
                CheckBoxCOE.Enabled = False
                CheckBoxITR.Enabled = False
                CheckBoxFinalPay.Enabled = False

                LabelHRGroupComment.Visible = True

                txtboxHRGroup.Visible = False
                txtboxHRGroup.Text = ""

            Else
                MsgBox("Request can't approve!, Make sure all checkbox is checked", MsgBoxStyle.Exclamation, "Approve")
        End If
        Else
        MsgBox("Request can't approve!, Make sure all group is approve otherwise you cannot accept/reject", MsgBoxStyle.Exclamation, "Reject")
        End If

    End Sub
    'END OF EDIT APPROVE







    'EDIT REJECT
    Private Sub ButtonEditReject_Click(sender As Object, e As EventArgs) Handles ButtonEditReject.Click

        HRNameAccept = LabelHRName.Text

        HRStatAccept = "Reject"

        HRCommentAccept = txtboxHRGroup.Text

        HRDateAccept = Date.Today

        LabelHRGroupApp.Text = HRStatAccept

        LabelDateHRGroup.Text = HRDateAccept

        LabelHRGroupComment.Text = txtboxHRGroup.Text


        updateHistory = "UPDATE `historyrequest` SET `HRGroupName`=@lblname, `HRGroupStatus`=@stats, `HRGroupComment`=@comment, `HRGroupDate`=@dateapp, `CheckHMO`=@checkHMO, `CheckInsurance`=@checkInsurance, `CheckCompanyID`=@checkCompanyID, `CheckQuitClaim`=@checkQuitClaim, `CheckCOE`=@checkCOE, `CheckITR`=@checkITR, `CheckFinalPay`=@checkFinalPay WHERE empID = '" & LabelEmpID.Text & "'"
        apdb.updateHRHistory(HRNameAccept, HRStatAccept, HRCommentAccept, HRDateAccept, checkHMO, checkInsurance, checkCompanyID, checkQuitClaim, checkCOE, checkITR, checkFinalPay, updateHistory)


        ButtonEdit.Visible = True
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False
        ButtonClose.Visible = True

        CheckBoxHMO.Enabled = False
        CheckBoxInsurance.Enabled = False
        CheckBoxCompanyID.Enabled = False
        CheckBoxQuitClaim.Enabled = False
        CheckBoxCOE.Enabled = False
        CheckBoxITR.Enabled = False
        CheckBoxFinalPay.Enabled = False

        LabelHRGroupComment.Visible = True

        txtboxHRGroup.Visible = False
        txtboxHRGroup.Text = ""

    End Sub

    'END OF EDIT REJECT







    Function verfGroupAccept() As Boolean
        Dim bdgacceptstat As String = BDGAccept.Text
        Dim sdgheadacceptstat As String = SDGHeadAccept.Text
        Dim sdgdeptacceptstat As String = SDGDeptAccept.Text
        Dim itopsacceptstat As String = ITOPSAccept.Text
        Dim pmgacceptstat As String = PMGAccept.Text
        Dim marketingacceptstat As String = MarketingAccept.Text
        Dim financeheadstat As String = FinanceHead.Text
        Dim financeacceptstat As String = FinanceAccept.Text
        Dim adminacceptstat As String = AdminAccept.Text
        Dim adminheadacceptstat As String = AdminHeadAccept.Text
        Dim sysadminacceptstat As String = SysAdminAccept.Text
        Dim sysadminheadacceptstat As String = SysAdminHeadAccept.Text



        If bdgacceptstat = "Approve" And sdgheadacceptstat = "Approve" And sdgdeptacceptstat = "Approve" And itopsacceptstat = "Approve" And pmgacceptstat = "Approve" And marketingacceptstat = "Approve" And financeheadstat = "Approve" And financeacceptstat = "Approve" And adminacceptstat = "Approve" And adminheadacceptstat = "Approve" And sysadminacceptstat = "Approve" And sysadminheadacceptstat = "Approve" Then
            Return True
        Else
            Return False
        End If


    End Function






    Private Sub LabelHRGroupApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRGroupApp.TextChanged
        If LabelHRGroupApp.Text = "Pending" Then
            LabelHRGroupApp.BackColor = Color.PowderBlue
        ElseIf LabelHRGroupApp.Text = "Approve" Then
            LabelHRGroupApp.BackColor = Color.Lime
        Else
            LabelHRGroupApp.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub CheckBoxHMO_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHMO.CheckedChanged

        If CheckBoxHMO.Checked = True Then
            checkHMO = "Checked"
            CheckBoxHMO.BackColor = Color.Green
        ElseIf CheckBoxHMO.Checked = False Then
            CheckBoxHMO.BackColor = Color.Gray
            checkHMO = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInsurance.CheckedChanged

        If CheckBoxInsurance.Checked = True Then
            checkInsurance = "Checked"
            CheckBoxInsurance.BackColor = Color.Green
        ElseIf CheckBoxInsurance.Checked = False Then
            CheckBoxInsurance.BackColor = Color.Gray
            checkInsurance = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxCompanyID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompanyID.CheckedChanged

        If CheckBoxCompanyID.Checked = True Then
            checkCompanyID = "Checked"
            CheckBoxCompanyID.BackColor = Color.Green
        ElseIf CheckBoxCompanyID.Checked = False Then
            CheckBoxCompanyID.BackColor = Color.Gray
            checkCompanyID = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxQuitClaim_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxQuitClaim.CheckedChanged

        If CheckBoxQuitClaim.Checked = True Then
            checkQuitClaim = "Checked"
            CheckBoxQuitClaim.BackColor = Color.Green
        ElseIf CheckBoxQuitClaim.Checked = False Then
            CheckBoxQuitClaim.BackColor = Color.Gray
            checkQuitClaim = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxCOE_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCOE.CheckedChanged

        If CheckBoxCOE.Checked = True Then
            checkCOE = "Checked"
            CheckBoxCOE.BackColor = Color.Green
        ElseIf CheckBoxCOE.Checked = False Then
            CheckBoxCOE.BackColor = Color.Gray
            checkCOE = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxITR_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxITR.CheckedChanged

        If CheckBoxITR.Checked = True Then
            checkITR = "Checked"
            CheckBoxITR.BackColor = Color.Green
        ElseIf CheckBoxITR.Checked = False Then
            CheckBoxITR.BackColor = Color.Gray
            checkITR = "Unchecked"
        End If

    End Sub

    Private Sub CheckBoxFinalPay_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFinalPay.CheckedChanged

        If CheckBoxFinalPay.Checked = True Then
            checkFinalPay = "Checked"
            CheckBoxFinalPay.BackColor = Color.Green
        ElseIf CheckBoxFinalPay.Checked = False Then
            CheckBoxFinalPay.BackColor = Color.Gray
            checkFinalPay = "Unchecked"
        End If

    End Sub


    Private Sub BDGAccept_TextChanged(sender As Object, e As EventArgs) Handles BDGAccept.TextChanged

        If BDGAccept.Text = "Pending" Then
            BDGAccept.BackColor = Color.PowderBlue
        ElseIf BDGAccept.Text = "Approve" Then
            BDGAccept.BackColor = Color.Lime
        Else
            BDGAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub SDGHeadAccept_TextChanged(sender As Object, e As EventArgs) Handles SDGHeadAccept.TextChanged

        If SDGHeadAccept.Text = "Pending" Then
            SDGHeadAccept.BackColor = Color.PowderBlue
        ElseIf SDGHeadAccept.Text = "Approve" Then
            SDGHeadAccept.BackColor = Color.Lime
        Else
            SDGHeadAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub SDGDeptAccept_TextChanged(sender As Object, e As EventArgs) Handles SDGDeptAccept.TextChanged

        If SDGDeptAccept.Text = "Pending" Then
            SDGDeptAccept.BackColor = Color.PowderBlue
        ElseIf SDGDeptAccept.Text = "Approve" Then
            SDGDeptAccept.BackColor = Color.Lime
        Else
            SDGDeptAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub ITOPSAccept_TextChanged(sender As Object, e As EventArgs) Handles ITOPSAccept.TextChanged

        If ITOPSAccept.Text = "Pending" Then
            ITOPSAccept.BackColor = Color.PowderBlue
        ElseIf ITOPSAccept.Text = "Approve" Then
            ITOPSAccept.BackColor = Color.Lime
        Else
            ITOPSAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub PMGAccept_TextChanged(sender As Object, e As EventArgs) Handles PMGAccept.TextChanged

        If PMGAccept.Text = "Pending" Then
            PMGAccept.BackColor = Color.PowderBlue
        ElseIf PMGAccept.Text = "Approve" Then
            PMGAccept.BackColor = Color.Lime
        Else
            PMGAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub MarketingAccept_TextChanged(sender As Object, e As EventArgs) Handles MarketingAccept.TextChanged

        If MarketingAccept.Text = "Pending" Then
            MarketingAccept.BackColor = Color.PowderBlue
        ElseIf MarketingAccept.Text = "Approve" Then
            MarketingAccept.BackColor = Color.Lime
        Else
            MarketingAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub FinanceAccept_TextChanged(sender As Object, e As EventArgs) Handles FinanceAccept.TextChanged

        If FinanceAccept.Text = "Pending" Then
            FinanceAccept.BackColor = Color.PowderBlue
        ElseIf FinanceAccept.Text = "Approve" Then
            FinanceAccept.BackColor = Color.Lime
        Else
            FinanceAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub FinanceHead_TextChanged(sender As Object, e As EventArgs) Handles FinanceHead.TextChanged

        If FinanceHead.Text = "Pending" Then
            FinanceHead.BackColor = Color.PowderBlue
        ElseIf FinanceHead.Text = "Approve" Then
            FinanceHead.BackColor = Color.Lime
        Else
            FinanceHead.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub AdminAccept_TextChanged(sender As Object, e As EventArgs) Handles AdminAccept.TextChanged

        If AdminAccept.Text = "Pending" Then
            AdminAccept.BackColor = Color.PowderBlue
        ElseIf AdminAccept.Text = "Approve" Then
            AdminAccept.BackColor = Color.Lime
        Else
            AdminAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub AdminHeadAccept_TextChanged(sender As Object, e As EventArgs) Handles AdminHeadAccept.TextChanged

        If AdminHeadAccept.Text = "Pending" Then
            AdminHeadAccept.BackColor = Color.PowderBlue
        ElseIf AdminHeadAccept.Text = "Approve" Then
            AdminHeadAccept.BackColor = Color.Lime
        Else
            AdminHeadAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub SysAdminAccept_TextChanged(sender As Object, e As EventArgs) Handles SysAdminAccept.TextChanged

        If SysAdminAccept.Text = "Pending" Then
            SysAdminAccept.BackColor = Color.PowderBlue
        ElseIf SysAdminAccept.Text = "Approve" Then
            SysAdminAccept.BackColor = Color.Lime
        Else
            SysAdminAccept.BackColor = Color.Firebrick

        End If

    End Sub

    Private Sub SysAdminHeadAccept_TextChanged(sender As Object, e As EventArgs) Handles SysAdminHeadAccept.TextChanged

        If SysAdminHeadAccept.Text = "Pending" Then
            SysAdminHeadAccept.BackColor = Color.PowderBlue
        ElseIf SysAdminHeadAccept.Text = "Approve" Then
            SysAdminHeadAccept.BackColor = Color.Lime
        Else
            SysAdminHeadAccept.BackColor = Color.Firebrick

        End If

    End Sub


    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click


        ButtonEditApprove.Visible = True
        ButtonEditReject.Visible = True
        ButtonEditCancel.Visible = True

        ButtonEdit.Visible = False
        ButtonClose.Visible = False

        CheckBoxHMO.Enabled = True
        CheckBoxInsurance.Enabled = True
        CheckBoxCompanyID.Enabled = True
        CheckBoxQuitClaim.Enabled = True
        CheckBoxCOE.Enabled = True
        CheckBoxITR.Enabled = True
        CheckBoxFinalPay.Enabled = True

        txtboxHRGroup.Visible = True
        txtboxHRGroup.Text = LabelHRGroupComment.Text
        LabelHRGroupComment.Visible = False

    End Sub



    Private Sub ButtonEditCancel_Click(sender As Object, e As EventArgs) Handles ButtonEditCancel.Click

        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        ButtonEdit.Visible = True
        ButtonClose.Visible = True

        CheckBoxHMO.Enabled = False
        CheckBoxInsurance.Enabled = False
        CheckBoxCompanyID.Enabled = False
        CheckBoxQuitClaim.Enabled = False
        CheckBoxCOE.Enabled = False
        CheckBoxITR.Enabled = False
        CheckBoxFinalPay.Enabled = False



        txtboxHRGroup.Visible = False
        txtboxHRGroup.Text = LabelHRGroupComment.Text
        LabelHRGroupComment.Visible = True

    End Sub


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnHRGroupApp.Visible = True
        btnHRGroupReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRGroupApp.Text = "Pending"
        LabelHRGroupComment.Text = ""
        LabelHRGroupComment.Visible = False

        txtboxHRGroup.Visible = True
        txtboxHRGroup.Text = ""

        CheckBoxHMO.Enabled = True
        CheckBoxInsurance.Enabled = True
        CheckBoxCompanyID.Enabled = True
        CheckBoxQuitClaim.Enabled = True
        CheckBoxCOE.Enabled = True
        CheckBoxITR.Enabled = True
        CheckBoxFinalPay.Enabled = True

        CheckBoxHMO.BackColor = Color.Gray
        CheckBoxInsurance.BackColor = Color.Gray
        CheckBoxCompanyID.BackColor = Color.Gray
        CheckBoxQuitClaim.BackColor = Color.Gray
        CheckBoxCOE.BackColor = Color.Gray
        CheckBoxITR.BackColor = Color.Gray
        CheckBoxFinalPay.BackColor = Color.Gray

        CheckBoxHMO.Checked = False
        CheckBoxInsurance.Checked = False
        CheckBoxCompanyID.Checked = False
        CheckBoxQuitClaim.Checked = False
        CheckBoxCOE.Checked = False
        CheckBoxITR.Checked = False
        CheckBoxFinalPay.Checked = False
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnHRGroupApp.Visible = True
        btnHRGroupReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRGroupApp.Text = "Pending"
        LabelHRGroupComment.Text = ""
        LabelHRGroupComment.Visible = False

        txtboxHRGroup.Visible = True
        txtboxHRGroup.Text = ""

        CheckBoxHMO.Enabled = True
        CheckBoxInsurance.Enabled = True
        CheckBoxCompanyID.Enabled = True
        CheckBoxQuitClaim.Enabled = True
        CheckBoxCOE.Enabled = True
        CheckBoxITR.Enabled = True
        CheckBoxFinalPay.Enabled = True

        CheckBoxHMO.BackColor = Color.Gray
        CheckBoxInsurance.BackColor = Color.Gray
        CheckBoxCompanyID.BackColor = Color.Gray
        CheckBoxQuitClaim.BackColor = Color.Gray
        CheckBoxCOE.BackColor = Color.Gray
        CheckBoxITR.BackColor = Color.Gray
        CheckBoxFinalPay.BackColor = Color.Gray

        CheckBoxHMO.Checked = False
        CheckBoxInsurance.Checked = False
        CheckBoxCompanyID.Checked = False
        CheckBoxQuitClaim.Checked = False
        CheckBoxCOE.Checked = False
        CheckBoxITR.Checked = False
        CheckBoxFinalPay.Checked = False
        Me.Close()
    End Sub

    Private Sub ViewHRGroup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnHRGroupApp.Visible = True
        btnHRGroupReject.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelHRGroupApp.Text = "Pending"
        LabelHRGroupComment.Text = ""
        LabelHRGroupComment.Visible = False

        txtboxHRGroup.Visible = True
        txtboxHRGroup.Text = ""

        ButtonEdit.Visible = False
        ButtonEditApprove.Visible = False
        ButtonEditReject.Visible = False
        ButtonEditCancel.Visible = False

        CheckBoxHMO.Enabled = True
        CheckBoxInsurance.Enabled = True
        CheckBoxCompanyID.Enabled = True
        CheckBoxQuitClaim.Enabled = True
        CheckBoxCOE.Enabled = True
        CheckBoxITR.Enabled = True
        CheckBoxFinalPay.Enabled = True

        CheckBoxHMO.BackColor = Color.Gray
        CheckBoxInsurance.BackColor = Color.Gray
        CheckBoxCompanyID.BackColor = Color.Gray
        CheckBoxQuitClaim.BackColor = Color.Gray
        CheckBoxCOE.BackColor = Color.Gray
        CheckBoxITR.BackColor = Color.Gray
        CheckBoxFinalPay.BackColor = Color.Gray

        CheckBoxHMO.Checked = False
        CheckBoxInsurance.Checked = False
        CheckBoxCompanyID.Checked = False
        CheckBoxQuitClaim.Checked = False
        CheckBoxCOE.Checked = False
        CheckBoxITR.Checked = False
        CheckBoxFinalPay.Checked = False

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