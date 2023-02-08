Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim app As New ApprovalDB
    Dim query As New MySqlCommand()

    Dim approve As String = "Approve"
    Dim reject As String = "Reject"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            If Login.flag = "Supervisor" Then

                ViewSDGSuper.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewSDGSuper.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewSDGSuper.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewSDGSuper.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewSDGSuper.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewSDGSuper.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewSDGSuper.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDGSuper.LabelSDGSuperApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
                ViewSDGSuper.ShowDialog()


            ElseIf Login.flag = "HR Interview" Then
                ViewHRInterview.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewHRInterview.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewHRInterview.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewHRInterview.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewHRInterview.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewHRInterview.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewHRInterview.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewHRInterview.LabelHRInterviewApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

                ViewHRInterview.ShowDialog()


            ElseIf Login.flag = "BDG Dept Head" Then

                ViewBDG.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewBDG.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewBDG.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewBDG.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewBDG.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewBDG.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewBDG.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewBDG.LabelBDGDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
                ViewBDG.ShowDialog()


            ElseIf Login.flag = "SDG Dept Head" Then

                ViewSDG.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewSDG.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewSDG.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewSDG.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewSDG.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewSDG.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewSDG.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDG.LabelSDGDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

                ViewSDG.ShowDialog()


            ElseIf Login.flag = "ITOPS Dept Head" Then

                ViewITOPS.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewITOPS.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewITOPS.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewITOPS.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewITOPS.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewITOPS.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewITOPS.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewITOPS.LabelITOPSDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

                ViewITOPS.ShowDialog()




            ElseIf Login.flag = "PMG Dept Head" Then

                ViewPMG.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewPMG.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewPMG.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewPMG.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewPMG.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewPMG.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewPMG.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewPMG.LabelPMGDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

                ViewPMG.ShowDialog()



            ElseIf Login.flag = "Marketing Dept Head" Then

                ViewMarketing.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewMarketing.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewMarketing.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewMarketing.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewMarketing.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewMarketing.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewMarketing.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewMarketing.LabelMarketingDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewMarketing.ShowDialog()


            ElseIf Login.flag = "Finance Dept Head" Then

                ViewFinance.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewFinance.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewFinance.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewFinance.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewFinance.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewFinance.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewFinance.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewFinance.LabelFinanceDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewFinance.ShowDialog()


            ElseIf Login.flag = "Finance Head" Then
                ViewFinanceHead.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewFinanceHead.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewFinanceHead.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewFinanceHead.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewFinanceHead.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewFinanceHead.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewFinanceHead.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewFinanceHead.LabelFinanceHeadApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewFinanceHead.ShowDialog()

            ElseIf Login.flag = "ADMIN" Then
                ViewAdmin.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewAdmin.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewAdmin.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewAdmin.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewAdmin.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewAdmin.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewAdmin.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewAdmin.LabelAdminDeptApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewAdmin.ShowDialog()


            ElseIf Login.flag = "SYSADMIN" Then
                ViewSysAdmin.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewSysAdmin.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewSysAdmin.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewSysAdmin.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewSysAdmin.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewSysAdmin.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewSysAdmin.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSysAdmin.LabelSysAdminApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewSysAdmin.ShowDialog()


            ElseIf Login.flag = "ADMIN HEAD" Then
                ViewAdminHead.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewAdminHead.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewAdminHead.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewAdminHead.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewAdminHead.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewAdminHead.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewAdminHead.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewAdminHead.LabelAdminHeadApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewAdminHead.ShowDialog()

            ElseIf Login.flag = "SYS ADMIN HEAD" Then
                ViewSysAdminHead.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewSysAdminHead.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewSysAdminHead.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewSysAdminHead.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewSysAdminHead.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewSysAdminHead.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewSysAdminHead.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSysAdminHead.LabelSysAdminHeadApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewSysAdminHead.ShowDialog()




            ElseIf Login.flag = "HR" Then
                ViewHRGroup.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewHRGroup.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewHRGroup.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewHRGroup.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewHRGroup.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewHRGroup.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewHRGroup.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewHRGroup.LabelHRGroupApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewHRGroup.ShowDialog()

            ElseIf Login.flag = "HR Head" Then
                ViewHRHead.LabelEmpName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
                ViewHRHead.LabelEmpID.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                ViewHRHead.LabelDept.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                ViewHRHead.LabelPos.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
                ViewHRHead.LabelPurpose.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
                ViewHRHead.LabelStatus.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
                ViewHRHead.LabelLastDay.Text = DateTime.Parse(DataGridView1.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewHRHead.LabelHRHeadApp.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


                ViewHRHead.ShowDialog()

            End If
        End If

    End Sub

    Private Sub DataGridHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridHistory.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            If Login.flag = "Supervisor" Then

                ViewSDGSuper.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewSDGSuper.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewSDGSuper.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewSDGSuper.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewSDGSuper.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewSDGSuper.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewSDGSuper.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDGSuper.LabelSDGSuperName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewSDGSuper.LabelSDGSuperApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewSDGSuper.LabelSDGSuperComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewSDGSuper.LabelDateSDGSuper.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDGSuper.btnSDGSuperApp.Visible = False
                ViewSDGSuper.btnSDGSuperReject.Visible = False
                ViewSDGSuper.ButtonCancel.Visible = False

                ViewSDGSuper.txtboxSDGSuper.Visible = False
                ViewSDGSuper.LabelSDGSuperComment.Visible = True

                ViewSDGSuper.ButtonEdit.Visible = True
                ViewSDGSuper.ButtonClose.Visible = True

                ViewSDGSuper.ShowDialog()


            ElseIf Login.flag = "BDG Dept Head" Then
                ViewBDG.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewBDG.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewBDG.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewBDG.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewBDG.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewBDG.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewBDG.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewBDG.LabelBDGName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewBDG.LabelBDGDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewBDG.LabelBDGDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewBDG.LabelDateBDGDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewBDG.btnBDGDeptApp.Visible = False
                ViewBDG.btnBDGDeptReject.Visible = False
                ViewBDG.ButtonCancel.Visible = False

                ViewBDG.txtboxBDGDept.Visible = False
                ViewBDG.LabelBDGDeptComment.Visible = True

                ViewBDG.ButtonEdit.Visible = True
                ViewBDG.ButtonClose.Visible = True


                ViewBDG.ShowDialog()



            ElseIf Login.flag = "SDG Dept Head" Then

                ViewSDG.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewSDG.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewSDG.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewSDG.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewSDG.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewSDG.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewSDG.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDG.LabelSDGDeptName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewSDG.LabelSDGDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewSDG.LabelSDGDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewSDG.LabelDateSDGDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSDG.btnSDGDeptApp.Visible = False
                ViewSDG.btnSDGDeptReject.Visible = False
                ViewSDG.ButtonCancel.Visible = False

                ViewSDG.txtboxSDGDept.Visible = False
                ViewSDG.LabelSDGDeptComment.Visible = True

                ViewSDG.ButtonEdit.Visible = True
                ViewSDG.ButtonClose.Visible = True

                ViewSDG.ShowDialog()



            ElseIf Login.flag = "ITOPS Dept Head" Then

                ViewITOPS.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewITOPS.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewITOPS.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewITOPS.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewITOPS.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewITOPS.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewITOPS.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewITOPS.LabelITOPSDeptName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewITOPS.LabelITOPSDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewITOPS.LabelITOPSDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewITOPS.LabelDateITOPSDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewITOPS.btnITOPSDeptApp.Visible = False
                ViewITOPS.btnITOPSDeptReject.Visible = False
                ViewITOPS.ButtonCancel.Visible = False

                ViewITOPS.txtboxITOPSDept.Visible = False
                ViewITOPS.LabelITOPSDeptComment.Visible = True

                ViewITOPS.ButtonEdit.Visible = True
                ViewITOPS.ButtonClose.Visible = True

                ViewITOPS.ShowDialog()




            ElseIf Login.flag = "PMG Dept Head" Then

                ViewPMG.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewPMG.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewPMG.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewPMG.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewPMG.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewPMG.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewPMG.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewPMG.LabelPMGName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewPMG.LabelPMGDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewPMG.LabelPMGDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewPMG.LabelDatePMGDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewPMG.btnPMGDeptApp.Visible = False
                ViewPMG.btnPMGDeptReject.Visible = False
                ViewPMG.ButtonCancel.Visible = False

                ViewPMG.txtboxPMGDept.Visible = False
                ViewPMG.LabelPMGDeptComment.Visible = True

                ViewPMG.ButtonEdit.Visible = True
                ViewPMG.ButtonClose.Visible = True

                ViewPMG.ShowDialog()



            ElseIf Login.flag = "Marketing Dept Head" Then

                ViewMarketing.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewMarketing.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewMarketing.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewMarketing.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewMarketing.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewMarketing.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewMarketing.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewMarketing.LabelMarketingName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewMarketing.LabelMarketingDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewMarketing.LabelMarketingDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewMarketing.LabelDateMarketingDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewMarketing.btnMarketingDeptApp.Visible = False
                ViewMarketing.btnMarketingDeptReject.Visible = False
                ViewMarketing.ButtonCancel.Visible = False

                ViewMarketing.txtboxMarketingDept.Visible = False
                ViewMarketing.LabelMarketingDeptComment.Visible = True

                ViewMarketing.ButtonEdit.Visible = True
                ViewMarketing.ButtonClose.Visible = True

                ViewMarketing.ShowDialog()

                'ElseIf Login.flag = "Finance Dept Head" Then
                '    ViewHistoryFINANCE()
                'ElseIf Login.flag = "ADMIN" Then
                '    ViewHistoryADMIN()
                'ElseIf Login.flag = "ADMINHead" Then
                '    ViewHistoryAdminHead()


                'ElseIf Login.flag = "SYSADMIN" Then
                '    ViewHistorySysAdmin()

                'ElseIf Login.flag = "SYSADMINHEAD" Then
                '    ViewHistorySysAdminHead()


            End If

        End If


    End Sub

    Sub fillGridHR(ByVal command As MySqlCommand)
        DataGridHR.ReadOnly = True
        DataGridHR.DataSource = app.getemployee(command)
        DataGridHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridHR.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None


        DataGridHR.Columns(0).HeaderText = "Username"
        DataGridHR.Columns(1).HeaderText = "Password"
        DataGridHR.Columns(2).HeaderText = "Name"
        DataGridHR.Columns(3).HeaderText = "Email"
        DataGridHR.Columns(4).HeaderText = "Title"
        DataGridHR.Columns(5).HeaderText = "Department"
        LabelTotalHR.Text = DataGridHR.Rows.Count
    End Sub

    Private Sub DataGridHR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridHR.CellMouseClick
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        HRUserForm.TextBoxUsername.Text = DataGridHR.CurrentRow.Cells(0).Value.ToString
        HRUserForm.TextBoxPassword.Text = DataGridHR.CurrentRow.Cells(1).Value.ToString
        HRUserForm.TextBoxName.Text = DataGridHR.CurrentRow.Cells(2).Value.ToString
        HRUserForm.TextBoxEmail.Text = DataGridHR.CurrentRow.Cells(3).Value.ToString
        HRUserForm.ComboBoxTitle.SelectedItem = DataGridHR.CurrentRow.Cells(4).Value.ToString
        HRUserForm.ComboBoxDept.SelectedItem = DataGridHR.CurrentRow.Cells(5).Value.ToString

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        HRUserForm.ButtonAdd.Enabled = False
        HRUserForm.ButtonAdd.Visible = False
        HRUserForm.ButtonDelete.Enabled = False
        HRUserForm.ButtonDelete.Visible = False
        HRUserForm.ButtonEdit.Enabled = True
        HRUserForm.ButtonEdit.Visible = True
        HRUserForm.ShowDialog()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        HRUserForm.TextBoxUsername.Clear()
        HRUserForm.TextBoxPassword.Clear()
        HRUserForm.TextBoxName.Clear()
        HRUserForm.TextBoxEmail.Clear()
        HRUserForm.ComboBoxTitle.SelectedIndex = -1
        HRUserForm.ComboBoxDept.SelectedIndex = -1
        HRUserForm.ShowDialog()
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        HRUserForm.ButtonAdd.Enabled = False
        HRUserForm.ButtonAdd.Visible = False
        HRUserForm.ButtonEdit.Enabled = False
        HRUserForm.ButtonEdit.Visible = False
        HRUserForm.ButtonDelete.Enabled = True
        HRUserForm.ButtonDelete.Visible = True
        HRUserForm.ShowDialog()
    End Sub

    Private Sub TextBoxsSearchDash_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchDash.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearchDash.Text = Nothing Then
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}  FROM {1} ORDER BY `empID`", Login.querystatus, Login.str)
                fillGridDashboard(query)
            Else
                query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} WHERE `empID` Like '%" & TextBoxSearchDash.Text & "%'", Login.querystatus, Login.str)
                fillGridDashboard(query)
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearchDash.Text = Nothing Then
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}  FROM {1} ORDER BY `Name`", Login.querystatus, Login.str)
                fillGridDashboard(query)
            Else
                query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} WHERE `Name` Like '%" & TextBoxSearchDash.Text & "%'", Login.querystatus, Login.str)
                fillGridDashboard(query)
            End If
        End If
        If CheckBoxByPurpose.Checked = True Then
            If TextBoxSearchDash.Text = Nothing Then
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}  FROM {1} ORDER BY `clearPurpose`", Login.querystatus, Login.str)
                fillGridDashboard(query)
            Else
                query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} WHERE `clearPurpose` Like '%" & TextBoxSearchDash.Text & "%'", Login.querystatus, Login.str)
                fillGridDashboard(query)
            End If
        End If
        If CheckBoxByDepartment.Checked = True Then
            If TextBoxSearchDash.Text = Nothing Then
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}  FROM {1} ORDER BY `dept`", Login.querystatus, Login.str)
                fillGridDashboard(query)
            Else
                query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} WHERE `dept` Like '%" & TextBoxSearchDash.Text & "%'", Login.querystatus, Login.str)
                fillGridDashboard(query)
            End If
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
            CheckBoxByPurpose.Checked = False
            CheckBoxByDepartment.Checked = False

        End If
    End Sub

    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
            CheckBoxByPurpose.Checked = False
            CheckBoxByDepartment.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} ORDER BY `Name`", Login.querystatus, Login.str)
            fillGridDashboard(query)
        End If
    End Sub

    Private Sub CheckBoxByPurpose_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByPurpose.CheckedChanged
        If CheckBoxByPurpose.Checked = True Then
            CheckBoxByName.Checked = False
            CheckBoxByID.Checked = False
            CheckBoxByDepartment.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} ORDER BY `clearPurpose`", Login.querystatus, Login.str)
            fillGridDashboard(query)
        End If
    End Sub

    Private Sub CheckBoxByDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByDepartment.CheckedChanged
        If CheckBoxByDepartment.Checked = True Then
            CheckBoxByName.Checked = False
            CheckBoxByID.Checked = False
            CheckBoxByPurpose.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0} FROM {1} ORDER BY `dept`", Login.querystatus, Login.str)
            fillGridDashboard(query)
        End If
    End Sub


    Private Sub TextBoxSearchHistory_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchHistory.TextChanged
        ''ADMIN
        'If Login.flag = "ADMIN" Then
        '    If CheckHistoryByID.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` ORDER BY `empID` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `empID` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    If CheckHistoryByName.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` ORDER BY `Name` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `Name` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByPurpose.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` ORDER BY `clearPurpose` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `clearPurpose` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByDepartment.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` ORDER BY `dept` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `dept` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    If CheckHistoryByApprove.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & approve & "' ORDER BY `AdminStatus` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & approve & "' Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    If CheckHistoryByRejected.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & reject & "' ORDER BY `AdminStatus` ASC"
        '            fillGridHistory(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckLaptop`, `CheckTelco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `AdminOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & reject & "' Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    'END OF ADMIN


        '    ' FINANCE DEPT HEAD
        'ElseIf Login.flag = "Finance Dept Head" Then

        '    If CheckHistoryByID.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `empID` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `empID` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    If CheckHistoryByName.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `Name` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `Name` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByPurpose.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `clearPurpose` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `clearPurpose` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByDepartment.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `dept` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `dept` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    'END OF FINANCE HEAD


        '    'SYS ADMIN HEAD
        'ElseIf Login.flag = "SYS ADMIN HEAD" Then
        '    If CheckHistoryByID.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `empID` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `empID` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    If CheckHistoryByName.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `Name` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `Name` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByPurpose.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `clearPurpose` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `clearPurpose` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If
        '    If CheckHistoryByDepartment.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptStatus` FROM `financedepthistory` ORDER BY `dept` ASC"
        '            fillGridDashboard(query)

        '        Else

        '            query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvanceCheck`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `dept` Like '%" & TextBoxSearchHistory.Text & "%'"
        '            fillGridHistory(query)

        '        End If

        '    End If

        '    'END OF SYS ADMIN HEAD


        'Else

        '    If CheckHistoryByID.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then
        '            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}  FROM {3} ORDER BY `empID` ASC", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        Else
        '            query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} WHERE `empID` Like '%" & TextBoxSearchHistory.Text & "%'", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        End If

        '    End If
        '    If CheckHistoryByName.Checked = True Then
        '        If TextBoxSearchHistory.Text = Nothing Then
        '            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}  FROM {3} ORDER BY `Name` ASC", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        Else
        '            query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} WHERE `Name` Like '%" & TextBoxSearchHistory.Text & "%'", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        End If
        '    End If
        '    If CheckHistoryByPurpose.Checked = True Then

        '        If TextBoxSearchHistory.Text = Nothing Then
        '            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}  FROM {3} ORDER BY `clearPurpose` ASC", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        Else
        '            query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} WHERE `clearPurpose` Like '%" & TextBoxSearchHistory.Text & "%'", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        End If
        '    End If
        '    If CheckHistoryByDepartment.Checked = True Then
        '        If TextBoxSearchHistory.Text = Nothing Then
        '            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}  FROM {3} ORDER BY `dept` ASC", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        Else
        '            query.CommandText = String.Format("Select `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} WHERE `dept` Like '%" & TextBoxSearchHistory.Text & "%'", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
        '            fillGridHistory(query)
        '        End If
        '    End If
        'End If

    End Sub


    Private Sub CheckHistoryByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByID.CheckedChanged
        If CheckHistoryByID.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByPurpose.Checked = False

        End If
    End Sub

    Private Sub CheckHistoryByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByName.CheckedChanged
        If CheckHistoryByName.Checked = True Then
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} ORDER BY Name", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
            fillGridHistory(query)
        End If
    End Sub

    Private Sub CheckHistoryByPurpose_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByPurpose.CheckedChanged
        If CheckHistoryByPurpose.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByDepartment.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} ORDER BY clearPurpose", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
            fillGridHistory(query)
        End If
    End Sub

    Private Sub CheckHistoryByDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByDepartment.CheckedChanged
        If CheckHistoryByDepartment.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2} FROM {3} ORDER BY dept", Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
            fillGridHistory(query)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchHR.TextChanged
        If CheckHRByUser.Checked = True Then

            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY user"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE user like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If

        End If
        If CheckHRByName.Checked = True Then
            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY Name"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE Name like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If
        End If
        If CheckHRByEmail.Checked = True Then

            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY email"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE email like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If
        End If
        If CheckHRByDepartment.Checked = True Then
            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY department"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE department like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If
        End If
    End Sub

    Private Sub CheckHRByUser_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByUser.CheckedChanged
        If CheckHRByUser.Checked = True Then
            CheckHRByName.Checked = False
            CheckHRByDepartment.Checked = False
            CheckHRByEmail.Checked = False

        End If
    End Sub

    Private Sub CheckHRByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByName.CheckedChanged
        If CheckHRByName.Checked = True Then
            CheckHRByDepartment.Checked = False
            CheckHRByUser.Checked = False
            CheckHRByEmail.Checked = False
            query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY name"
            fillGridHR(query)
        End If
    End Sub

    Private Sub CheckHRByEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByEmail.CheckedChanged
        If CheckHRByEmail.Checked = True Then
            CheckHRByName.Checked = False
            CheckHRByUser.Checked = False
            CheckHRByDepartment.Checked = False
            query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY email"
            fillGridHR(query)
        End If
    End Sub

    Private Sub CheckHRByDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByDepartment.CheckedChanged
        If CheckHRByDepartment.Checked = True Then
            CheckHRByName.Checked = False
            CheckHRByUser.Checked = False
            CheckHRByEmail.Checked = False
            query.CommandText = "SELECT `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY department"
            fillGridHR(query)
        End If
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Login.Show()

    End Sub
End Class