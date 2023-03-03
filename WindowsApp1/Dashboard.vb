Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim app As New ApprovalDB
    Dim query As New MySqlCommand()
    Dim dbs As New db
    Dim pagerows As Integer
    Public approve As String = "Approve"
    Public reject As String = "Reject"
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


        DataGridHistory.Refresh()

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

            ElseIf Login.flag = "Finance Dept Head" Then

                ViewFinance.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewFinance.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewFinance.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewFinance.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewFinance.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewFinance.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewFinance.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewFinance.LabelFinanceName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewFinance.LabelFinanceDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewFinance.LabelFinanceDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewFinance.LabelDateFinanceDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                If DataGridHistory.CurrentRow.Cells(12).Value.ToString = "Checked" Then
                    ViewFinance.CheckBoxCash.Checked = True
                Else
                    ViewFinance.CheckBoxCash.Checked = False
                End If

                If DataGridHistory.CurrentRow.Cells(13).Value.ToString = "Checked" Then
                    ViewFinance.CheckBoxOthers.Checked = True
                    ViewFinance.txtboxOther.Text = DataGridHistory.CurrentRow.Cells(14).Value.ToString
                Else
                    ViewFinance.CheckBoxOthers.Checked = False
                    ViewFinance.txtboxOther.Text = ""
                End If

                ViewFinance.btnFinanceDeptApp.Visible = False
                ViewFinance.btnFinanceDeptReject.Visible = False
                ViewFinance.ButtonCancel.Visible = False

                ViewFinance.txtboxFinanceDept.Visible = False
                ViewFinance.LabelFinanceDeptComment.Visible = True

                ViewFinance.CheckBoxCash.Enabled = False
                ViewFinance.CheckBoxOthers.Enabled = False
                ViewFinance.txtboxOther.Enabled = False

                ViewFinance.ButtonEdit.Visible = True
                ViewFinance.ButtonClose.Visible = True

                ViewFinance.ShowDialog()

            ElseIf Login.flag = "Finance Head" Then
                ViewFinanceHead.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewFinanceHead.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewFinanceHead.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewFinanceHead.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewFinanceHead.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewFinanceHead.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewFinanceHead.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewFinanceHead.LabelFinanceHeadName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewFinanceHead.LabelFinanceHeadApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewFinanceHead.LabelFinanceHeadComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewFinanceHead.LabelDateFinanceHead.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")


                ViewFinanceHead.btnFinanceHeadApp.Visible = False
                ViewFinanceHead.btnFinanceHeadReject.Visible = False
                ViewFinanceHead.ButtonCancel.Visible = False

                ViewFinanceHead.txtboxFinanceHead.Visible = False
                ViewFinanceHead.LabelFinanceHeadComment.Visible = True

                ViewFinanceHead.ButtonEdit.Visible = True
                ViewFinanceHead.ButtonClose.Visible = True

                ViewFinanceHead.ShowDialog()

            ElseIf Login.flag = "ADMIN" Then
                ViewAdmin.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewAdmin.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewAdmin.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewAdmin.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewAdmin.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewAdmin.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewAdmin.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewAdmin.LabelAdminName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewAdmin.LabelAdminDeptApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewAdmin.LabelAdminDeptComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewAdmin.LabelDateAdminDept.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                If DataGridHistory.CurrentRow.Cells(12).Value.ToString = "Checked" Then
                    ViewAdmin.CheckBoxTelco.Checked = True
                Else
                    ViewAdmin.CheckBoxTelco.Checked = False
                End If

                If DataGridHistory.CurrentRow.Cells(13).Value.ToString = "Checked" Then
                    ViewAdmin.CheckBoxTools.Checked = True
                Else
                    ViewAdmin.CheckBoxTools.Checked = False
                End If

                If DataGridHistory.CurrentRow.Cells(14).Value.ToString = "Checked" Then
                    ViewAdmin.CheckBoxPhone.Checked = True
                Else
                    ViewAdmin.CheckBoxPhone.Checked = False
                End If

                If DataGridHistory.CurrentRow.Cells(15).Value.ToString = "Checked" Then
                    ViewAdmin.CheckBoxTable.Checked = True
                Else
                    ViewAdmin.CheckBoxTable.Checked = False
                End If

                If DataGridHistory.CurrentRow.Cells(16).Value.ToString = "Checked" Then
                    ViewAdmin.CheckBoxOthers.Checked = True
                    ViewAdmin.txtboxOther.Text = DataGridHistory.CurrentRow.Cells(17).Value.ToString
                    ViewAdmin.LabelOthers.Text = ViewAdmin.txtboxOther.Text
                Else
                    ViewAdmin.CheckBoxOthers.Checked = False
                    ViewAdmin.txtboxOther.Text = ""
                    ViewAdmin.LabelOthers.Text = ViewAdmin.txtboxOther.Text
                End If


                ViewAdmin.btnAdminDeptApp.Visible = False
                ViewAdmin.btnAdminDeptReject.Visible = False
                ViewAdmin.ButtonCancel.Visible = False


                ViewAdmin.CheckBoxTelco.Enabled = False
                ViewAdmin.CheckBoxTools.Enabled = False
                ViewAdmin.CheckBoxPhone.Enabled = False
                ViewAdmin.CheckBoxTable.Enabled = False
                ViewAdmin.CheckBoxOthers.Enabled = False
                ViewAdmin.txtboxOther.Enabled = False
                ViewAdmin.txtboxOther.Visible = False
                ViewAdmin.LabelOthers.Visible = True

                ViewAdmin.txtboxAdminDept.Visible = False
                ViewAdmin.LabelAdminDeptComment.Visible = True

                ViewAdmin.ButtonEdit.Visible = True
                ViewAdmin.ButtonClose.Visible = True

                ViewAdmin.ShowDialog()

            ElseIf Login.flag = "ADMIN HEAD" Then

                ViewAdminHead.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewAdminHead.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewAdminHead.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewAdminHead.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewAdminHead.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewAdminHead.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewAdminHead.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")


                ViewAdminHead.LabelAdminHeadName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewAdminHead.LabelAdminHeadApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewAdminHead.LabelAdminHeadComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewAdminHead.LabelDateAdminHead.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewAdminHead.btnAdminHeadApp.Visible = False
                ViewAdminHead.btnAdminHeadReject.Visible = False
                ViewAdminHead.ButtonCancel.Visible = False

                ViewAdminHead.txtboxAdminHead.Visible = False
                ViewAdminHead.LabelAdminHeadComment.Visible = True

                ViewAdminHead.ButtonEdit.Visible = True
                ViewAdminHead.ButtonClose.Visible = True

                ViewAdminHead.ShowDialog()

            ElseIf Login.flag = "SYSADMIN" Then

                ViewSysAdmin.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewSysAdmin.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewSysAdmin.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewSysAdmin.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewSysAdmin.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewSysAdmin.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewSysAdmin.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")


                ViewSysAdmin.LabelSysAdminName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewSysAdmin.LabelSysAdminApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewSysAdmin.LabelSysAdminComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewSysAdmin.LabelDateSysAdmin.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSysAdmin.btnSysAdminApp.Visible = False
                ViewSysAdmin.btnSysAdminReject.Visible = False
                ViewSysAdmin.ButtonCancel.Visible = False

                ViewSysAdmin.txtboxSysAdmin.Visible = False
                ViewSysAdmin.LabelSysAdminComment.Visible = True

                ViewSysAdmin.CheckBoxLaptop.Enabled = False
                ViewSysAdmin.CheckBoxEmail.Enabled = False
                ViewSysAdmin.CheckBoxComputer.Enabled = False


                ViewSysAdmin.ButtonEdit.Visible = True
                ViewSysAdmin.ButtonClose.Visible = True

                ViewSysAdmin.ShowDialog()

            ElseIf Login.flag = "SYS ADMIN HEAD" Then

                ViewSysAdminHead.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewSysAdminHead.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewSysAdminHead.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewSysAdminHead.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewSysAdminHead.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewSysAdminHead.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewSysAdminHead.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")


                ViewSysAdminHead.LabelSysAdminHeadName.Text = DataGridHistory.CurrentRow.Cells(8).Value.ToString
                ViewSysAdminHead.LabelSysAdminHeadApp.Text = DataGridHistory.CurrentRow.Cells(9).Value.ToString
                ViewSysAdminHead.LabelSysAdminHeadComment.Text = DataGridHistory.CurrentRow.Cells(10).Value.ToString
                ViewSysAdminHead.LabelDateSysAdminHead.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(11).Value.ToString()).ToString("MMM-dd-yyyy")

                ViewSysAdminHead.btnSysAdminHeadApp.Visible = False
                ViewSysAdminHead.btnSysAdminHeadReject.Visible = False
                ViewSysAdminHead.ButtonCancel.Visible = False

                ViewSysAdminHead.txtboxSysAdminHead.Visible = False
                ViewSysAdminHead.LabelSysAdminHeadComment.Visible = True

                ViewSysAdminHead.ButtonEdit.Visible = True
                ViewSysAdminHead.ButtonClose.Visible = True

                ViewSysAdminHead.ShowDialog()

            ElseIf Login.flag = "HR" Then

                ViewHRGroup.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewHRGroup.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewHRGroup.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewHRGroup.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewHRGroup.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewHRGroup.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewHRGroup.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                If DataGridHistory.CurrentRow.Cells(72).Value.Equals(DBNull.Value) Then
                    MsgBox("Please Approve/Reject first in the Dashboard before proceed to the history", MsgBoxStyle.Exclamation, "HR history")
                Else
                    ViewHRGroup.LabelHRName.Text = DataGridHistory.CurrentRow.Cells(72).Value.ToString
                    ViewHRGroup.LabelHRGroupApp.Text = DataGridHistory.CurrentRow.Cells(73).Value.ToString
                    ViewHRGroup.LabelHRGroupComment.Text = DataGridHistory.CurrentRow.Cells(74).Value.ToString
                    ViewHRGroup.LabelDateHRGroup.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(75).Value.ToString()).ToString("MMM-dd-yyyy")

                    ViewHRGroup.btnHRGroupApp.Visible = False
                    ViewHRGroup.btnHRGroupReject.Visible = False
                    ViewHRGroup.ButtonCancel.Visible = False

                    ViewHRGroup.txtboxHRGroup.Visible = False
                    ViewHRGroup.LabelHRGroupComment.Visible = True


                    ViewHRGroup.CheckBoxHMO.Enabled = False
                    ViewHRGroup.CheckBoxInsurance.Enabled = False
                    ViewHRGroup.CheckBoxCompanyID.Enabled = False
                    ViewHRGroup.CheckBoxQuitClaim.Enabled = False
                    ViewHRGroup.CheckBoxCOE.Enabled = False
                    ViewHRGroup.CheckBoxITR.Enabled = False
                    ViewHRGroup.CheckBoxFinalPay.Enabled = False


                    ViewHRGroup.ButtonEdit.Visible = True
                    ViewHRGroup.ButtonClose.Visible = True

                    ViewHRGroup.ShowDialog()
                End If


            ElseIf Login.flag = "HR Head" Then

                ViewHRHead.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewHRHead.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewHRHead.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewHRHead.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewHRHead.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewHRHead.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewHRHead.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")
                If DataGridHistory.CurrentRow.Cells(68).Value.Equals(DBNull.Value) Then
                    MsgBox("Please Approve/Reject first in the Dashboard before proceed to the history", MsgBoxStyle.Exclamation, "HR history")
                Else
                    ViewHRHead.LabelHRHeadName.Text = DataGridHistory.CurrentRow.Cells(68).Value.ToString
                    ViewHRHead.LabelHRHeadApp.Text = DataGridHistory.CurrentRow.Cells(69).Value.ToString
                    ViewHRHead.LabelHRHeadComment.Text = DataGridHistory.CurrentRow.Cells(70).Value.ToString
                    ViewHRHead.LabelDateHRHead.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(71).Value.ToString()).ToString("MMM-dd-yyyy")

                    ViewHRHead.btnHRHeadApp.Visible = False
                    ViewHRHead.btnHRHeadReject.Visible = False
                    ViewHRHead.ButtonCancel.Visible = False

                    ViewHRHead.txtboxHRHead.Visible = False
                    ViewHRHead.LabelHRHeadComment.Visible = True

                    ViewHRHead.ButtonEdit.Visible = True
                    ViewHRHead.ButtonClose.Visible = True

                    ViewHRHead.ShowDialog()
                End If

            ElseIf Login.flag = "HR Interview" Then
                ViewHRInterviewHistory.LabelEmpName.Text = DataGridHistory.CurrentRow.Cells(1).Value.ToString
                ViewHRInterviewHistory.LabelEmpID.Text = DataGridHistory.CurrentRow.Cells(2).Value.ToString
                ViewHRInterviewHistory.LabelDept.Text = DataGridHistory.CurrentRow.Cells(3).Value.ToString
                ViewHRInterviewHistory.LabelPos.Text = DataGridHistory.CurrentRow.Cells(4).Value.ToString
                ViewHRInterviewHistory.LabelPurpose.Text = DataGridHistory.CurrentRow.Cells(5).Value.ToString
                ViewHRInterviewHistory.LabelStatus.Text = DataGridHistory.CurrentRow.Cells(6).Value.ToString
                ViewHRInterviewHistory.LabelLastDay.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

                If DataGridHistory.CurrentRow.Cells(83).Value.Equals(DBNull.Value) Then
                    MsgBox("Please Approve/Reject first in the Dashboard before proceed to the history", MsgBoxStyle.Exclamation, "HR history")
                ElseIf DataGridHistory.CurrentRow.Cells(86).Value.Equals(DBNull.Value) Then

                    ViewHRInterviewHistory.LabelHRInterviewName.Text = DataGridHistory.CurrentRow.Cells(83).Value.ToString
                    ViewHRInterviewHistory.LabelHRInterviewApp.Text = DataGridHistory.CurrentRow.Cells(84).Value.ToString
                    ViewHRInterviewHistory.LabelDateHRInterview.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(85).Value.ToString()).ToString("MMM-dd-yyyy")


                    ViewHRInterviewHistory.LabelFinalInterview.Text = ""
                    ViewHRInterviewHistory.LabelFinalStatus.Text = "Pending"
                    ViewHRInterviewHistory.LabelFinalDate.Text = ""

                    ViewHRInterviewHistory.CheckBoxInterview.Checked = True

                    ViewHRInterviewHistory.CheckBoxFinal.Checked = False

                    ViewHRInterviewHistory.ShowDialog()
                Else

                    ViewHRInterviewHistory.LabelHRInterviewName.Text = DataGridHistory.CurrentRow.Cells(83).Value.ToString
                    ViewHRInterviewHistory.LabelHRInterviewApp.Text = DataGridHistory.CurrentRow.Cells(84).Value.ToString
                    ViewHRInterviewHistory.LabelDateHRInterview.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(85).Value.ToString()).ToString("MMM-dd-yyyy")


                    ViewHRInterviewHistory.LabelFinalInterview.Text = DataGridHistory.CurrentRow.Cells(86).Value.ToString
                    ViewHRInterviewHistory.LabelFinalStatus.Text = DataGridHistory.CurrentRow.Cells(87).Value.ToString
                    ViewHRInterviewHistory.LabelFinalDate.Text = DateTime.Parse(DataGridHistory.CurrentRow.Cells(88).Value.ToString()).ToString("MMM-dd-yyyy")

                    ViewHRInterviewHistory.CheckBoxInterview.Checked = True

                    ViewHRInterviewHistory.CheckBoxFinal.Checked = True

                    ViewHRInterviewHistory.ShowDialog()
                End if
            End If



        End If


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

        If Login.flag = "ADMIN" Then
            HistorySearchAdmin()
        ElseIf Login.flag = "Finance Dept Head" Then
            HistorySearchFinanceDept()
        ElseIf Login.flag = "SYSADMIN" Then
            HistorySearchSysAdmin()
        ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
            HistorySearchHR()
        Else
            HistorySearchGroup()
        End If



    End Sub



    Private Sub CheckHistoryByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByID.CheckedChanged
        If CheckHistoryByID.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByPurpose.Checked = False
            CheckHistoryByApprove.Checked = False
            CheckHistoryByRejected.Checked = False

        End If
    End Sub

    Private Sub CheckHistoryByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByName.CheckedChanged
        If CheckHistoryByName.Checked = True Then
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            CheckHistoryByApprove.Checked = False
            CheckHistoryByRejected.Checked = False
            If Login.flag = "ADMIN" Then
                query.CommandText = " SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `Name` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "Finance Dept Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `Name` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "SYSADMIN" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `Name` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `Name` ASC"
                fillGridHistory(query)
            Else
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} ORDER BY `Name` ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
                fillGridHistory(query)
            End If

        End If
    End Sub

    Private Sub CheckHistoryByPurpose_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByPurpose.CheckedChanged
        If CheckHistoryByPurpose.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByApprove.Checked = False
            CheckHistoryByRejected.Checked = False
            If Login.flag = "ADMIN" Then
                query.CommandText = " SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "Finance Dept Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "SYSADMIN" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `clearPurpose` ASC"
                fillGridHistory(query)
            Else
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} ORDER BY `clearPurpose` ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
                fillGridHistory(query)

            End If
        End If
    End Sub

    Private Sub CheckHistoryByDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByDepartment.CheckedChanged
        If CheckHistoryByDepartment.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            CheckHistoryByApprove.Checked = False
            CheckHistoryByRejected.Checked = False
            If Login.flag = "ADMIN" Then

                query.CommandText = " SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` ORDER BY `dept` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "Finance Dept Head" Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `dept` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "SYSADMIN" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` ORDER BY `dept` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` ORDER BY `dept` ASC"
                fillGridHistory(query)
            Else
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} ORDER BY `dept` ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory)
                fillGridHistory(query)
            End If
        End If
    End Sub

    Private Sub CheckHistoryByApprove_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByApprove.CheckedChanged

        If CheckHistoryByApprove.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            CheckHistoryByDepartment.Checked = False
            CheckHistoryByRejected.Checked = False
            If Login.flag = "ADMIN" Then

                query.CommandText = " SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & approve & "' ORDER BY `AdminGroupStatus` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "Finance Dept Head" Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & approve & "' ORDER BY `FINANCEDeptStatus` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "SYSADMIN" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & approve & "' ORDER BY `SysAdminStatus` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
                `BDGDeptStatus` = '" & approve & "' OR 
        `SDGSuperStatus` = '" & approve & "' OR 
          `SDGDeptStatus` = '" & approve & "' OR 
          `ITOPSDeptStatus` = '" & approve & "' OR 
      `PMGDeptStatus` = '" & approve & "' OR 
      `MarketingDeptStatus` = '" & approve & "' OR 
          `FINANCEHeadStatus` = '" & approve & "' OR 
      `FINANCEDeptStatus` = '" & approve & "' OR 
      `AdminGroupStatus` = '" & approve & "' OR 
      `SysAdminStatus` = '" & approve & "' OR 
      `AdminHeadStatus` = '" & approve & "' OR 
      `SysAdminHeadStatus` = '" & approve & "' OR 
      `HRHeadStatus` = '" & approve & "' OR 
      `HRGroupStatus` = '" & approve & "' ORDER BY `empID` ASC"
                fillGridHistory(query)
            Else
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} wHERE {5} = '" & approve & "' ORDER BY {6} ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory, Login.querystatus, Login.querystatus)
                fillGridHistory(query)
            End If
        End If

    End Sub

    Private Sub CheckHistoryByRejected_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHistoryByRejected.CheckedChanged

        If CheckHistoryByRejected.Checked = True Then
            CheckHistoryByName.Checked = False
            CheckHistoryByID.Checked = False
            CheckHistoryByPurpose.Checked = False
            CheckHistoryByApprove.Checked = False
            CheckHistoryByDepartment.Checked = False
            If Login.flag = "ADMIN" Then

                query.CommandText = " SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment` FROM `admingrouphistory` WHERE `AdminGroupStatus`= '" & reject & "' ORDER BY `AdminGroupStatus` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "Finance Dept Head" Then

                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment` FROM `financedepthistory` WHERE `FINANCEDeptStatus`= '" & reject & "' ORDER BY `FINANCEDeptStatus` ASC"
                fillGridHistory(query)

            ElseIf Login.flag = "SYSADMIN" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom` FROM `sysadminhistory` WHERE `SysAdminStatus`= '" & reject & "' ORDER BY `SysAdminStatus` ASC"
                fillGridHistory(query)
            ElseIf Login.flag = "HR" Or Login.flag = "HR Interview" Or Login.flag = "HR Head" Then
                query.CommandText = "SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDate`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDate`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDate`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDate`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDate`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDate`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDate`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDate`, `CashAdvance`, `FinanceDeptOthers`, `FinanceDeptOtherComment`, `AdminGroupName`, `AdminGroupStatus`, `AdminGroupComment`, `AdminGroupDate`, `CheckTeleco`, `CheckTools`, `CheckPhone`, `CheckTable`, `CheckOthers`, `CheckOthersComment`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDate`, `SysAdminName`, `SysAdminStatus`, `SysAdminComment`, `SysAdminDate`, `CheckLaptop`, `CheckEmail`, `CheckCom`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDate`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDate`, `HRGroupName`, `HRGroupStatus`, `HRGroupComment`, `HRGroupDate`, `CheckHMO`, `CheckInsurance`, `CheckCompanyID`, `CheckQuitClaim`, `CheckCOE`, `CheckITR`, `CheckFinalPay`, `ScheduleInterviewerName`, `ScheduleInterviewStatus`, `ScheduleInterviewDate`, `ExitInterviewBy`, `ExitInterviewStatus`, `ExitInterviewDate` FROM `historyrequest` WHERE 
                `BDGDeptStatus` = '" & reject & "' OR 
        `SDGSuperStatus` = '" & reject & "' OR 
          `SDGDeptStatus` = '" & reject & "' OR 
          `ITOPSDeptStatus` = '" & reject & "' OR 
      `PMGDeptStatus` = '" & reject & "' OR 
      `MarketingDeptStatus` = '" & reject & "' OR 
          `FINANCEHeadStatus` = '" & reject & "' OR 
      `FINANCEDeptStatus` = '" & reject & "' OR 
      `AdminGroupStatus` = '" & reject & "' OR 
      `SysAdminStatus` = '" & reject & "' OR 
      `AdminHeadStatus` = '" & reject & "' OR 
      `SysAdminHeadStatus` = '" & reject & "' OR 
      `HRHeadStatus` = '" & reject & "' OR 
      `HRGroupStatus` = '" & reject & "' ORDER BY `empID` ASC"
                fillGridHistory(query)
            Else
                query.CommandText = String.Format("SELECT `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {0}, {1}, {2}, {3} FROM {4} wHERE {5} = '" & reject & "' ORDER BY {6} ASC", Login.queryName, Login.querystatus, Login.querycomment, Login.querydate, Login.queryhistory, Login.querystatus, Login.querystatus)
                fillGridHistory(query)
            End If
        End If

    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchHR.TextChanged
        If CheckHRByUser.Checked = True Then

            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY user"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE user like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If

        End If
        If CheckHRByName.Checked = True Then
            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY Name"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE Name like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If
        End If
        If CheckHRByEmail.Checked = True Then

            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY email"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE email like '%" & TextBoxSearchHR.Text & "%'"
                fillGridHR(query)
            End If
        End If
        If CheckHRByDepartment.Checked = True Then
            If TextBoxSearchHR.Text = Nothing Then
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY department"
                fillGridHR(query)
            Else
                query.CommandText = "SELECT `id`,`user`, `pass`, `name`, `email`, `title`, `department` FROM `login` WHERE department like '%" & TextBoxSearchHR.Text & "%'"
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
            query.CommandText = "SELECT `id`, `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY name"
            fillGridHR(query)
        End If
    End Sub

    Private Sub CheckHRByEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByEmail.CheckedChanged
        If CheckHRByEmail.Checked = True Then
            CheckHRByName.Checked = False
            CheckHRByUser.Checked = False
            CheckHRByDepartment.Checked = False
            query.CommandText = "SELECT `id`, `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY email"
            fillGridHR(query)
        End If
    End Sub

    Private Sub CheckHRByDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHRByDepartment.CheckedChanged
        If CheckHRByDepartment.Checked = True Then
            CheckHRByName.Checked = False
            CheckHRByUser.Checked = False
            CheckHRByEmail.Checked = False
            query.CommandText = "SELECT `id`, `user`, `pass`, `name`, `email`, `title`, `department` FROM `login` ORDER BY department"
            fillGridHR(query)
        End If
    End Sub

    Private Sub DataGridHR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridHR.CellMouseClick
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        HRUser.labelID.Text = DataGridHR.CurrentRow.Cells(0).Value.ToString
        HRUser.TextBoxUsername.Text = DataGridHR.CurrentRow.Cells(1).Value.ToString
        HRUser.TextBoxPassword.Text = DataGridHR.CurrentRow.Cells(2).Value.ToString
        HRUser.TextBoxName.Text = DataGridHR.CurrentRow.Cells(3).Value.ToString
        HRUser.TextBoxEmail.Text = DataGridHR.CurrentRow.Cells(4).Value.ToString
        HRUser.ComboBoxTitle.SelectedItem = DataGridHR.CurrentRow.Cells(5).Value.ToString





        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridHR.Rows.Count AndAlso e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridHR.Columns.Count Then
            Dim clickedRow As DataGridViewRow = DataGridHR.Rows(e.RowIndex)
            Dim clickedCell As DataGridViewCell = clickedRow.Cells(e.ColumnIndex)
            ' Do something with the clicked cell or row...
            For Each cell As DataGridViewCell In clickedRow.Cells
                cell.Selected = True
            Next
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        HRUser.ButtonADD.Enabled = False
        HRUser.ButtonADD.Visible = False
        HRUser.ButtonDelete.Enabled = False
        HRUser.ButtonDelete.Visible = False
        HRUser.ButtonEdit.Enabled = True
        HRUser.ButtonEdit.Visible = True

        HRUser.TextBoxUsername.Enabled = True
        HRUser.TextBoxPassword.Enabled = True
        HRUser.TextBoxName.Enabled = True
        HRUser.TextBoxEmail.Enabled = True
        HRUser.ComboBoxTitle.Enabled = True
        HRUser.ComboBoxDepartment.Enabled = True
        HRUser.ComboBoxDepartment.SelectedItem = DataGridHR.CurrentRow.Cells(6).Value.ToString

        HRUser.ShowDialog()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        HRUser.TextBoxUsername.Clear()
        HRUser.TextBoxPassword.Clear()
        HRUser.TextBoxName.Clear()
        HRUser.TextBoxEmail.Clear()
        HRUser.ComboBoxTitle.SelectedItem = "Dept Head"
        HRUser.ComboBoxDepartment.SelectedItem = "BDG"

        HRUser.ButtonADD.Enabled = True
        HRUser.ButtonADD.Visible = True
        HRUser.ButtonDelete.Enabled = False
        HRUser.ButtonDelete.Visible = False
        HRUser.ButtonEdit.Enabled = False
        HRUser.ButtonEdit.Visible = False

        HRUser.TextBoxUsername.Enabled = True
        HRUser.TextBoxPassword.Enabled = True
        HRUser.TextBoxName.Enabled = True
        HRUser.TextBoxEmail.Enabled = True
        HRUser.ComboBoxTitle.Enabled = True
        HRUser.ComboBoxDepartment.Enabled = True
        HRUser.ShowDialog()
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        HRUser.ButtonADD.Enabled = False
        HRUser.ButtonADD.Visible = False
        HRUser.ButtonEdit.Enabled = False
        HRUser.ButtonEdit.Visible = False
        HRUser.ButtonDelete.Enabled = True
        HRUser.ButtonDelete.Visible = True
        HRUser.ComboBoxDepartment.SelectedItem = DataGridHR.CurrentRow.Cells(6).Value.ToString
        HRUser.ShowDialog()
    End Sub



    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbs.returnConnection(dbs.getConn)
        Login.Show()

    End Sub

    Private Sub DataGridHistory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridHistory.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridHistory.Rows.Count AndAlso e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridHistory.Columns.Count Then
            Dim clickedRow As DataGridViewRow = DataGridHistory.Rows(e.RowIndex)
            Dim clickedCell As DataGridViewCell = clickedRow.Cells(e.ColumnIndex)
            ' Do something with the clicked cell or row...
            For Each cell As DataGridViewCell In clickedRow.Cells
                cell.Selected = True
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count AndAlso e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridView1.Columns.Count Then
            Dim clickedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim clickedCell As DataGridViewCell = clickedRow.Cells(e.ColumnIndex)
            ' Do something with the clicked cell or row...
            For Each cell As DataGridViewCell In clickedRow.Cells
                cell.Selected = True
            Next
        End If
    End Sub

    Private Sub DataGridViewComplete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewComplete.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            CompleteRequest.LabelEmpName.Text = DataGridViewComplete.CurrentRow.Cells(1).Value.ToString
            CompleteRequest.LabelEmpID.Text = DataGridViewComplete.CurrentRow.Cells(2).Value.ToString
            CompleteRequest.LabelDept.Text = DataGridViewComplete.CurrentRow.Cells(3).Value.ToString
            CompleteRequest.LabelPos.Text = DataGridViewComplete.CurrentRow.Cells(4).Value.ToString
            CompleteRequest.LabelPurpose.Text = DataGridViewComplete.CurrentRow.Cells(5).Value.ToString
            CompleteRequest.LabelStatus.Text = DataGridViewComplete.CurrentRow.Cells(6).Value.ToString
            CompleteRequest.LabelLastDay.Text = DateTime.Parse(DataGridViewComplete.CurrentRow.Cells(7).Value.ToString()).ToString("MMM-dd-yyyy")

            CompleteRequest.ShowDialog()
        End If
    End Sub

    Private Sub DataGridViewComplete_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewComplete.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewComplete.Rows.Count AndAlso e.ColumnIndex >= 0 AndAlso e.ColumnIndex < DataGridViewComplete.Columns.Count Then
            Dim clickedRow As DataGridViewRow = DataGridViewComplete.Rows(e.RowIndex)
            Dim clickedCell As DataGridViewCell = clickedRow.Cells(e.ColumnIndex)
            ' Do something with the clicked cell or row...
            For Each cell As DataGridViewCell In clickedRow.Cells
                cell.Selected = True
            Next
        End If
    End Sub

    Private Sub ButtonLogOut_Click(sender As Object, e As EventArgs) Handles ButtonLogOut.Click
        Me.Close()
    End Sub
End Class