Imports MySql.Data.MySqlClient
Public Class ViewHRInterview
    Dim apdb As New ApprovalDB
    Dim dbs As New db
    Dim adapter As New MySqlDataAdapter
    Dim table As New DataTable

    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    'Dim insertchecker As String
    Dim checkinterview As String = "Unchecked"

    Dim HRInterviewStatAccept As String
    Dim HRInterviewNameAccept As String
    Dim HRInterviewDateAccept As Date

    Private Sub ViewHRInterview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If verfSchedule() = True Then
            btnHRInterviewApp.Visible = False
            CheckBoxInterview.Checked = True
            CheckBoxInterview.Enabled = False
        Else
            btnFinalInterview.Visible = False
            CheckBoxFinal.Enabled = False
        End If
    End Sub

    'ACCEPT

    Private Sub btnHRInterviewApp_Click(sender As Object, e As EventArgs) Handles btnHRInterviewApp.Click
        If verfChecked() = True Then
            Dim tablegroup(8) As String
            tablegroup(0) = "BDGDepthead"
            tablegroup(1) = "sdgsupervisor"
            tablegroup(2) = "itopsDepthead"
            tablegroup(3) = "pmgDepthead"
            tablegroup(4) = "marketingDepthead"
            tablegroup(5) = "financegrouphead"
            tablegroup(6) = "admingroup"
            tablegroup(7) = "sysadmin"
            tablegroup(8) = "hr"

            Dim tablestatus(8) As String
            tablestatus(0) = "bdgdeptstatus"
            tablestatus(1) = "sdgsuperstatus"
            tablestatus(2) = "itopsdeptstatus"
            tablestatus(3) = "pmgdeptstatus"
            tablestatus(4) = "marketingdeptstatus"
            tablestatus(5) = "financeheadstatus"
            tablestatus(6) = "adminstatus"
            tablestatus(7) = "sysadminstatus"
            tablestatus(8) = "hrstatus"


            HRInterviewStatAccept = "Scheduled"

            HRInterviewNameAccept = LabelHRInterviewName.Text


            HRInterviewDateAccept = Date.Today

            LabelHRInterviewApp.Text = HRInterviewStatAccept

            LabelDateHRInterview.Text = HRInterviewDateAccept

            statusNextflow = "Pending"

            updateHistory = "UPDATE `historyrequest` SET `ScheduleInterviewerName`=@lblname, `ScheduleInterviewStatus`=@interviewstat, `ScheduleInterviewDate`=@dateapp WHERE empID = '" & LabelEmpID.Text & "'"

            apdb.updateinterview(HRInterviewNameAccept, HRInterviewStatAccept, HRInterviewDateAccept, updateHistory)

            'insertchecker = "INSERT INTO `checkergroup`(`empID`) VALUES (@empid)"
            'apdb.insertchecker(LabelEmpID.Text, insertchecker)

            'insertchecker = "INSERT INTO `checker`(`empID`) VALUES (@empid)"
            'apdb.insertchecker(LabelEmpID.Text, insertchecker)


            For n As Integer = 0 To 8
                insertNextFlow = String.Format("INSERT INTO {0}(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {1}) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)", tablegroup(n), tablestatus(n))
                apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, statusNextflow, insertNextFlow)
            Next


            insertNextFlow = "INSERT INTO `hrinterview`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `hrstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
            apdb.insertNextFlow(LabelEmpName.Text, LabelEmpID.Text, LabelDept.Text, LabelPos.Text, LabelPurpose.Text, LabelStatus.Text, LabelLastDay.Text, HRInterviewStatAccept, insertNextFlow)

            Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
            apdb.deleteRequest(LabelEmpID.Text, deletedt)

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

    End Sub

    'END OF FINAL ACCEPT



    Function verfChecked() As Boolean


        If CheckBoxInterview.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Function verfCheckedFinal() As Boolean
        If CheckBoxFinal.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Function verfSchedule() As Boolean
        Dim query As String
        query = "select HRStatus from HRInterview where empID='" & LabelEmpID.Text & "'"
        Dim command As New MySqlCommand(query, dbs.getconn)
        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Return False

        Else
            Dim hrStatus As String = table.Rows(0)("HRStatus").ToString
            If hrStatus = "Scheduled" Then
                Return True
            Else
                Return False
            End If
        End If

    End Function


    Private Sub LabelHRInterviewApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRInterviewApp.TextChanged
        If LabelHRInterviewApp.Text = "Pending" Then
            LabelHRInterviewApp.BackColor = Color.PowderBlue
        ElseIf LabelHRInterviewApp.Text = "Scheduled" Then
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
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelDateHRInterview.Visible = False

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        btnHRInterviewApp.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelDateHRInterview.Visible = False

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False
        Me.Close()
    End Sub

    Private Sub ViewHRInterview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnHRInterviewApp.Visible = True
        ButtonCancel.Visible = True
        ButtonClose.Visible = False

        LabelDateHRInterview.Visible = False

        CheckBoxInterview.Enabled = True
        CheckBoxInterview.Checked = False


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