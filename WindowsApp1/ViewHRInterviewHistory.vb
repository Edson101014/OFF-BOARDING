Public Class ViewHRInterviewHistory
    Private Sub HRInterviewHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click


        Me.Close()
    End Sub

    Private Sub HRInterviewHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LabelFinalInterview.Text = ""
        LabelFinalDate.Text = ""
        LabelFinalStatus.Text = "Pending"

        LabelDateHRInterview.Text = ""
        LabelHRInterviewName.Text = ""
        LabelHRInterviewApp.Text = "Pending"

        CheckBoxInterview.Enabled = False
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

    Private Sub LabelFinalStatus_TextChanged(sender As Object, e As EventArgs) Handles LabelFinalStatus.TextChanged
        If LabelFinalStatus.Text = "Pending" Then
            LabelFinalStatus.BackColor = Color.PowderBlue
        ElseIf LabelFinalStatus.Text = "Scheduled" Then
            LabelFinalStatus.BackColor = Color.Lime
        ElseIf LabelFinalStatus.Text = "Interviewed" Then
            LabelFinalStatus.BackColor = Color.Lime
        Else
            LabelFinalStatus.BackColor = Color.Firebrick

        End If
    End Sub

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
End Class