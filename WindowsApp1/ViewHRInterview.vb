﻿Imports MySql.Data.MySqlClient
Public Class ViewHRInterview
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    Dim adapter As New MySqlDataAdapter
    Dim table As New DataTable
    Dim label As New ClassLabel

    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    'Dim insertchecker As String
    Dim checkinterview As String = "Unchecked"

    Dim HRInterviewStatAccept As String
    Dim HRInterviewNameAccept As String
    Dim HRInterviewDateAccept As Date

    Private Sub ViewHRInterview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LabelHRInterviewApp.Text = "Scheduled" Then
            btnHRInterviewApp.Visible = False
            btnFinalInterview.Visible = True
            CheckBoxInterview.Checked = True
            CheckBoxInterview.Enabled = False
            CheckBoxFinal.Checked = False
            CheckBoxFinal.Enabled = True
        ElseIf LabelHRInterviewApp.Text = "Pending" Then
            btnHRInterviewApp.Visible = True
            btnFinalInterview.Visible = False
            CheckBoxInterview.Checked = False
            CheckBoxInterview.Enabled = True
            CheckBoxFinal.Checked = False
            CheckBoxFinal.Enabled = False
        End If
    End Sub

    'ACCEPT

    Private Sub btnHRInterviewApp_Click(sender As Object, e As EventArgs) Handles btnHRInterviewApp.Click
        If verfChecked() = True Then
            Dim tablegroup() As String = {"bdgdepthead", "sdgsupervisor", "itopsdepthead", "pmgdepthead", "marketingdepthead", "financegrouphead", "admingroup", "sysadmin", "hr"}
            Dim tablestatus() As String = {"bdgdeptstatus", "sdgsuperstatus", "itopsdeptstatus", "pmgdeptstatus", "marketingdeptstatus", "financeheadstatus", "adminstatus", "sysadminstatus", "hrstatus"}

            HRInterviewStatAccept = "Scheduled"
            HRInterviewNameAccept = LabelHRInterviewName.Text
            HRInterviewDateAccept = Date.Today

            LabelHRInterviewApp.Text = HRInterviewStatAccept
            LabelDateHRInterview.Text = HRInterviewDateAccept
            statusNextflow = "Pending"

            updateHistory = "UPDATE `historyrequest` SET `ScheduleInterviewerName`=@lblname, `ScheduleInterviewStatus`=@interviewstat, `ScheduleInterviewDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"
            apdb.updateinterview(HRInterviewNameAccept, HRInterviewStatAccept, HRInterviewDateAccept, updateHistory)

            For n As Integer = 0 To 8
                insertNextFlow = String.Format("INSERT INTO {0}(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {1}) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)", tablegroup(n), tablestatus(n))
                apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
            Next

            label.sentmail()
            Loading.Close()

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)
            insertNextFlow = "INSERT INTO `hrinterview`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `hrStatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, HRInterviewStatAccept, insertNextFlow)


            btnHRInterviewApp.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True
            LabelDateHRInterview.Visible = True
            CheckBoxInterview.Enabled = False
        Else
            MsgBox("Please check the checkbox if you want to Scheduled", MsgBoxStyle.Exclamation, "Schedule")
        End If
    End Sub



    'END OF ACCEPT




    'FINAL ACCEPT
    Private Sub btnFinalInterview_Click(sender As Object, e As EventArgs) Handles btnFinalInterview.Click

        If verfCheckedFinal() = True Then
            HRInterviewStatAccept = "Interviewed"

            HRInterviewNameAccept = LabelHRInterviewName.Text


            HRInterviewDateAccept = Date.Today

            LabelHRInterviewApp.Text = HRInterviewStatAccept

            LabelDateHRInterview.Text = HRInterviewDateAccept


            updateHistory = "UPDATE `historyrequest` SET `ExitInterviewBy`=@lblname, `ExitInterviewStatus`=@interviewstat, `ExitInterviewDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"

            apdb.updateinterview(HRInterviewNameAccept, HRInterviewStatAccept, HRInterviewDateAccept, updateHistory)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)


            btnFinalInterview.Visible = False
            ButtonCancel.Visible = False
            ButtonClose.Visible = True

            LabelDateHRInterview.Visible = True

            CheckBoxFinal.Enabled = False

        Else
            MsgBox("Please check the checkbox if you want to Final Interview", MsgBoxStyle.Exclamation, "Interview")
        End If
    End Sub

    'END OF FINAL ACCEPT



    Function verfChecked() As Boolean


        If CheckBoxInterview.Checked = False Then
            CheckBoxInterview.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function

    Function verfCheckedFinal() As Boolean
        If CheckBoxFinal.Checked = False Then
            CheckBoxFinal.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function




    Private Sub LabelHRInterviewApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRInterviewApp.TextChanged
        If LabelHRInterviewApp.Text = "Pending" Then
            LabelHRInterviewApp.BackColor = Color.PowderBlue
        ElseIf LabelHRInterviewApp.Text = "Scheduled" Then
            LabelHRInterviewApp.BackColor = Color.Lime
        ElseIf LabelHRInterviewApp.Text = "Interviewed" Then
            LabelHRInterviewApp.BackColor = Color.Lime
        Else
            LabelHRInterviewApp.BackColor = Color.Firebrick

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


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        btnHRInterviewApp.Visible = True
        btnFinalInterview.Visible = False
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelDateHRInterview.Visible = False

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False
        CheckBoxFinal.Enabled = False
        CheckBoxFinal.Checked = False
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnHRInterviewApp.Visible = True
        btnFinalInterview.Visible = False
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelDateHRInterview.Visible = False

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False
        CheckBoxFinal.Enabled = False
        CheckBoxFinal.Checked = False
        Me.Close()
    End Sub

    Private Sub ViewHRInterview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        btnHRInterviewApp.Visible = True
        btnFinalInterview.Visible = False
        ButtonCancel.Visible = True
        ButtonClose.Visible = False


        LabelDateHRInterview.Text = ""

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False
        CheckBoxFinal.Enabled = False
        CheckBoxFinal.Checked = False



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