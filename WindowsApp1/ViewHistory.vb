'Imports MySql.Data.MySqlClient
'Public Class ViewHistory
'    Dim dbs As New db
'    Dim apdb As New ApprovalDB
'    Dim query As New MySqlCommand()
'    Dim checkTelco As String
'    Dim checkCash As String


'    Private Sub ViewHistory_Load(sender As Object, e As EventArgs)
'        Label3.Select()

'        If Login.flag = "Supervisor" Then
'            ShowSuperButton()

'        ElseIf Login.flag = "BDG Dept Head" Then
'            ShowBDGButton()

'        ElseIf Login.flag = "SDG Dept Head" Then
'            ShowSDGButton()

'        ElseIf Login.flag = "ITOPS Dept Head" Then
'            ShowITOPSButton()

'        ElseIf Login.flag = "PMG Dept Head" Then
'            ShowPMGButton()

'        ElseIf Login.flag = "Marketing Dept Head" Then
'            ShowMarketingButton()

'        ElseIf Login.flag = "Finance Dept Head" Then
'            ShowFinanceButton()

'        ElseIf Login.flag = "ADMIN" Then
'            ShowAdminButton()

'        ElseIf Login.flag = "ADMIN HEAD" Then
'            ShowAdminHeadButton()

'        ElseIf Login.flag = "SYSADMIN" Then
'            ShowSysAdminButton()

'        ElseIf Login.flag = "SYS ADMIN HEAD" Then
'            ShowSysAdminHeadButton()

'        ElseIf Login.flag = "HR Interview" Then
'            ShowHRInterviewButton()

'        ElseIf Login.flag = "HR" Then
'            ShowHRButton()
'            ButtonResend.Visible = True
'            ComboBox1.Visible = True

'        ElseIf Login.flag = "HR Head" Then
'            ShowHRHeadButton()
'            ButtonResend.Visible = True
'            ComboBox1.Visible = True
'        End If
'    End Sub

'    Private Sub ButtonResend_Click(sender As Object, e As EventArgs) Handles ButtonResend.Click
'        HRResendGroup()
'    End Sub



'    Private Sub ViewHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
'        If Login.flag = "Finance Dept Head" Then
'            ShowFinanceData()

'        ElseIf Login.flag = "SYSADMIN" Then
'            ShowSysAdminData()

'        ElseIf Login.flag = "Admin" Then
'            ShowAdminData()

'        ElseIf Login.flag = "HR" Then
'            ShowHRData()

'        ElseIf Login.flag = "HR Interview" Then
'            ShowHRInterviewData()
'        Else
'            ShowData()
'        End If

'        HideViewHistory()

'    End Sub

'    Private Sub LabelIMSuperApp_TextChanged(sender As Object, e As EventArgs) Handles LabelIMSuperApp.TextChanged
'        If LabelIMSuperApp.Text = "Pending" Then
'            LabelIMSuperApp.BackColor = Color.PowderBlue
'        ElseIf LabelIMSuperApp.Text = "Approve" Then
'            LabelIMSuperApp.BackColor = Color.Lime
'        Else
'            LabelIMSuperApp.BackColor = Color.Firebrick

'        End If
'    End Sub




'    Private Sub LabelBDGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelBDGDeptApp.TextChanged
'        If LabelBDGDeptApp.Text = "Pending" Then
'            LabelBDGDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelBDGDeptApp.Text = "Approve" Then
'            LabelBDGDeptApp.BackColor = Color.Lime
'        Else
'            LabelBDGDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub


'    Private Sub LabelSDGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSDGDeptApp.TextChanged
'        If LabelSDGDeptApp.Text = "Pending" Then
'            LabelSDGDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelSDGDeptApp.Text = "Approve" Then
'            LabelSDGDeptApp.BackColor = Color.Lime
'        Else
'            LabelSDGDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub



'    Private Sub LabelITOPSDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelITOPSDeptApp.TextChanged
'        If LabelITOPSDeptApp.Text = "Pending" Then
'            LabelITOPSDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelITOPSDeptApp.Text = "Approve" Then
'            LabelITOPSDeptApp.BackColor = Color.Lime
'        Else
'            LabelITOPSDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub


'    Private Sub LabelPMGDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelPMGDeptApp.TextChanged
'        If LabelPMGDeptApp.Text = "Pending" Then
'            LabelPMGDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelPMGDeptApp.Text = "Approve" Then
'            LabelPMGDeptApp.BackColor = Color.Lime
'        Else
'            LabelPMGDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub



'    Private Sub LabelMARKETDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelMARKETDeptApp.TextChanged
'        If LabelMARKETDeptApp.Text = "Pending" Then
'            LabelMARKETDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelMARKETDeptApp.Text = "Approve" Then
'            LabelMARKETDeptApp.BackColor = Color.Lime
'        Else
'            LabelMARKETDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub



'    Private Sub LabelFINANCEDeptApp_TextChanged(sender As Object, e As EventArgs) Handles LabelFINANCEDeptApp.TextChanged
'        If LabelFINANCEDeptApp.Text = "Pending" Then
'            LabelFINANCEDeptApp.BackColor = Color.PowderBlue
'        ElseIf LabelFINANCEDeptApp.Text = "Approve" Then
'            LabelFINANCEDeptApp.BackColor = Color.Lime
'        Else
'            LabelFINANCEDeptApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabeLFinanceHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabeLFinanceHeadApp.TextChanged
'        If LabeLFinanceHeadApp.Text = "Pending" Then
'            LabeLFinanceHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabeLFinanceHeadApp.Text = "Approve" Then
'            LabeLFinanceHeadApp.BackColor = Color.Lime
'        Else
'            LabeLFinanceHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelAdminHeadApp.TextChanged
'        If LabelAdminHeadApp.Text = "Pending" Then
'            LabelAdminHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelAdminHeadApp.Text = "Approve" Then
'            LabelAdminHeadApp.BackColor = Color.Lime
'        Else
'            LabelAdminHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelSysAdminHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelSysAdminHeadApp.TextChanged
'        If LabelSysAdminHeadApp.Text = "Pending" Then
'            LabelSysAdminHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelSysAdminHeadApp.Text = "Approve" Then
'            LabelSysAdminHeadApp.BackColor = Color.Lime
'        Else
'            LabelSysAdminHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub

'    Private Sub LabelHRHeadApp_TextChanged(sender As Object, e As EventArgs) Handles LabelHRHeadApp.TextChanged
'        If LabelHRHeadApp.Text = "Pending" Then
'            LabelHRHeadApp.BackColor = Color.PowderBlue
'        ElseIf LabelHRHeadApp.Text = "Approve" Then
'            LabelHRHeadApp.BackColor = Color.Lime
'        Else
'            LabelHRHeadApp.BackColor = Color.Firebrick

'        End If
'    End Sub


'    Private Sub CheckBoxCash_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCash.CheckedChanged
'        If CheckBoxCash.Checked = True Then
'            checkCash = "Checked"
'            CheckBoxCash.BackColor = Color.Lime
'            LabelCashChecked.Text = LabelFinanceName.Text
'        ElseIf CheckBoxCash.Checked = False Then
'            CheckBoxCash.BackColor = Color.Gray
'            LabelCashChecked.Text = ""
'            checkCash = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxLaptop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLaptop.CheckedChanged
'        If CheckBoxLaptop.Checked = True Then
'            checklaptop = "Checked"
'            CheckBoxLaptop.BackColor = Color.Lime
'        ElseIf CheckBoxLaptop.Checked = False Then
'            CheckBoxLaptop.BackColor = Color.Gray
'            checklaptop = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmail.CheckedChanged
'        If CheckBoxEmail.Checked = True Then
'            checkemail = "Checked"
'            CheckBoxEmail.BackColor = Color.Lime
'        ElseIf CheckBoxEmail.Checked = False Then
'            CheckBoxEmail.BackColor = Color.Gray
'            checkemail = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxComputer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxComputer.CheckedChanged
'        If CheckBoxComputer.Checked = True Then
'            checkcom = "Checked"
'            CheckBoxComputer.BackColor = Color.Lime
'        ElseIf CheckBoxComputer.Checked = False Then
'            CheckBoxComputer.BackColor = Color.Gray
'            checkcom = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxCompID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompID.CheckedChanged
'        If CheckBoxCompID.Checked = True Then
'            checkID = "Checked"
'            CheckBoxCompID.BackColor = Color.Lime

'        ElseIf CheckBoxCompID.Checked = False Then
'            CheckBoxCompID.BackColor = Color.Gray
'            checkID = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxCompPhone_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompPhone.CheckedChanged
'        If CheckBoxCompPhone.Checked = True Then
'            checkphone = "Checked"
'            CheckBoxCompPhone.BackColor = Color.Lime
'        ElseIf CheckBoxCompPhone.Checked = False Then
'            CheckBoxCompPhone.BackColor = Color.Gray
'            checkphone = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxTools_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTools.CheckedChanged
'        If CheckBoxTools.Checked = True Then
'            checktools = "Checked"
'            CheckBoxTools.BackColor = Color.Lime
'        ElseIf CheckBoxTools.Checked = False Then
'            CheckBoxTools.BackColor = Color.Gray
'            checktools = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxTelco_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTelco.CheckedChanged
'        If CheckBoxTelco.Checked = True Then
'            checkTelco = "Checked"
'            CheckBoxTelco.BackColor = Color.Lime
'        ElseIf CheckBoxTelco.Checked = False Then
'            CheckBoxTelco.BackColor = Color.Gray
'            checkTelco = "Unchecked"

'        End If
'    End Sub

'    Private Sub CheckBoxESS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxESS.CheckedChanged
'        If CheckBoxESS.Checked = True Then
'            checkESS = "Checked"
'            CheckBoxESS.BackColor = Color.Lime
'        ElseIf CheckBoxESS.Checked = False Then
'            CheckBoxESS.BackColor = Color.Gray
'            checkESS = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxCompHealth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCompHealth.CheckedChanged
'        If CheckBoxCompHealth.Checked = True Then
'            checkHealth = "Checked"
'            CheckBoxCompHealth.BackColor = Color.Lime
'        ElseIf CheckBoxCompHealth.Checked = False Then
'            CheckBoxCompHealth.BackColor = Color.Gray
'            checkHealth = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxPayroll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPayroll.CheckedChanged
'        If CheckBoxPayroll.Checked = True Then
'            checkPayroll = "Checked"
'            CheckBoxPayroll.BackColor = Color.Lime
'        ElseIf CheckBoxPayroll.Checked = False Then
'            CheckBoxPayroll.BackColor = Color.Gray
'            checkPayroll = "Unchecked"
'        End If
'    End Sub

'    Private Sub CheckBoxInterview_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInterview.CheckedChanged
'        If CheckBoxInterview.Checked = True Then
'            checkinterview = "Checked"
'            CheckBoxInterview.BackColor = Color.Lime
'        ElseIf CheckBoxInterview.Checked = False Then
'            CheckBoxInterview.BackColor = Color.Gray
'            checkinterview = "Unchecked"
'        End If
'    End Sub


'End Class