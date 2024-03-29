﻿Imports MySql.Data.MySqlClient
Public Class Login
    Dim dbs As New db
    Private count = 0
    Public flag As String
    Public str As String
    Public querystatus As String
    Public querycomment As String
    Public querydate As String
    Public queryhistory As String
    Public insertSuperTable As String
    Public insertSuperStatus As String
    Public queryName As String

    Dim labelname As String

    Dim classlabel As New ClassLabel


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If My.Computer.Network.IsAvailable Then

            Else
                MessageBox.Show("Internet connection is not available.")
            End If
            Dim query As String
            query = "select * from login where user=@user and pass=@pass"

            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable
            Using connection As MySqlConnection = dbs.getConn()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@user", TextBox1.Text)
                    command.Parameters.AddWithValue("@pass", TextBox2.Text)
                    adapter.SelectCommand = command
                    adapter.Fill(table)


                    If table.Rows.Count > 0 Then
                        connection.Open()

                        Dim usertype = table.Rows(0)("Department").ToString()

                        If usertype = "BDG" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Dept Head" Then

                                MsgBox("Welcome BDG Dept Head")

                                connection.Close()
                                Me.Hide()

                                str = "bdgdepthead"
                                querystatus = "bdgDeptStatus"
                                querycomment = "bdgDeptComment"
                                querydate = "bdgDeptDate"
                                queryName = "BDGDeptName"
                                queryhistory = "bdgdepthistory"

                                flag = "BDG Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewBDG.LabelBDGName, labelname)



                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            End If


                        ElseIf usertype = "SDG" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Supervisor" Then

                                MsgBox("Welcome SDG Supervisor")

                                connection.Close()

                                Me.Hide()

                                str = "sdgsupervisor"
                                querystatus = "SDGSuperStatus"
                                querycomment = "SDGSuperComment"
                                querydate = "SDGSuperDate"
                                queryName = "SDGSuperName"
                                queryhistory = "sdgsuperhistory"

                                flag = "Supervisor"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewSDGSuper.LabelSDGSuperName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            Else

                                MsgBox("Welcome SDG Dept Head")

                                connection.Close()

                                Me.Hide()

                                str = "sdgdepthead"
                                querystatus = "SDGDeptStatus"
                                querycomment = "SDGDeptComment"
                                querydate = "SDGDeptDate"
                                queryName = "SDGDeptName"
                                queryhistory = "sdgdepthistory"

                                flag = "SDG Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewSDG.LabelSDGDeptName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            End If


                        ElseIf usertype = "ITOPS" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Dept Head" Then

                                MsgBox("Welcome ITOPS Dept Head")

                                connection.Close()

                                Me.Hide()

                                str = "itopsdepthead"
                                querystatus = "ITOPSDeptStatus"
                                querycomment = "ITOPSDeptComment"
                                querydate = "ITOPSDeptDate"
                                queryName = "ITOPSDeptName"
                                queryhistory = "itopsdepthistory"

                                flag = "ITOPS Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewITOPS.LabelITOPSDeptName, labelname)



                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            End If


                        ElseIf usertype = "PMG" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Dept Head" Then

                                MsgBox("Welcome PMG Dept Head")

                                connection.Close()

                                Me.Hide()

                                str = "pmgdepthead"
                                querystatus = "PMGDeptStatus"
                                querycomment = "PMGDeptComment"
                                querydate = "PMGDeptDate"
                                queryName = "PMGDeptName"
                                queryhistory = "pmgdepthistory"

                                flag = "PMG Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewPMG.LabelPMGName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))


                                Dashboard.Show()
                                TextBox2.Clear()

                            End If


                        ElseIf usertype = "Marketing" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Dept Head" Then

                                MsgBox("Welcome MARKETING Dept Head")

                                connection.Close()

                                Me.Hide()

                                str = "marketingdepthead"
                                querystatus = "MARKETINGDeptStatus"
                                querycomment = "MARKETINGDeptComment"
                                querydate = "MARKETINGDeptDate"
                                queryName = "MarketingDeptName"
                                queryhistory = "marketingdepthistory"

                                flag = "Marketing Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewMarketing.LabelMarketingName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))


                                Dashboard.Show()
                                TextBox2.Clear()

                            End If

                        ElseIf usertype = "Finance" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Supervisor" Then

                                MsgBox("Welcome FINANCE Supervisor")

                                connection.Close()

                                Me.Hide()

                                str = "financegrouphead"
                                queryName = "FinanceHeadName"
                                querystatus = "FINANCEHeadStatus"
                                querycomment = "FINANCEHeadComment"
                                querydate = "FINANCEHeadDate"
                                queryhistory = "financeheadhistory"

                                flag = "Finance Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewFinanceHead.LabelFinanceHeadName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))


                                Dashboard.Show()
                                TextBox2.Clear()

                            Else

                                MsgBox("Welcome FINANCE Dept Head")

                                connection.Close()

                                Me.Hide()

                                str = "financedepthead"
                                querystatus = "FINANCEDeptStatus"
                                querycomment = "FINANCEDeptComment"
                                querydate = "FINANCEDeptDate"
                                queryhistory = "financedepthistory"

                                flag = "Finance Dept Head"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewFinance.LabelFinanceName, labelname)



                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))


                                Dashboard.Show()
                                TextBox2.Clear()

                            End If


                        ElseIf usertype = "Admin" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Supervisor" Then

                                MsgBox("Welcome Admin Head")

                                connection.Close()

                                Me.Hide()

                                str = "admingrouphead"
                                queryName = "AdminHeadName"
                                querystatus = "AdminHeadStatus"
                                querycomment = "AdminHeadComment"
                                querydate = "AdminHeadDate"
                                queryhistory = "admingroupheadhistory"

                                flag = "ADMIN HEAD"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewAdminHead.LabelAdminHeadName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            Else

                                MsgBox("Welcome Admin")

                                connection.Close()

                                Me.Hide()

                                str = "admingroup"
                                queryName = "AdminGroupName"
                                querystatus = "AdminGroupStatus"
                                querycomment = "AdminGroupComment"
                                querydate = "AdminGroupDate"
                                queryhistory = "admingrouphistory"

                                flag = "ADMIN"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewAdmin.LabelAdminName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()
                            End If

                        ElseIf usertype = "SysAdmin" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Supervisor" Then

                                MsgBox("Welcome System Admin Head")

                                connection.Close()

                                Me.Hide()

                                str = "sysadmingrouphead"
                                queryName = "SysAdminHeadName"
                                querystatus = "SysAdminHeadStatus"
                                querycomment = "SysAdminHeadComment"
                                querydate = "SysAdminHeadDate"
                                queryhistory = "sysadmingroupheadhistory"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewSysAdminHead.LabelSysAdminHeadName, labelname)

                                flag = "SYS ADMIN HEAD"


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()

                            Else

                                MsgBox("Welcome System Admin")

                                connection.Close()

                                Me.Hide()

                                str = "sysadmin"
                                queryName = "SysAdminName"
                                querystatus = "SysAdminStatus"
                                querycomment = "SysAdminComment"
                                querydate = "SysAdminDate"
                                queryhistory = "sysadmingrouphistory"

                                flag = "SYSADMIN"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewSysAdmin.LabelSysAdminName, labelname)


                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(3))
                                Dashboard.TabControl1.TabPages.Remove(Dashboard.TabControl1.TabPages(2))

                                Dashboard.Show()
                                TextBox2.Clear()
                            End If

                        ElseIf usertype = "HR" Then

                            usertype = table.Rows(0)("title").ToString()

                            If usertype = "Dept Head" Then

                                MsgBox("Welcome HR Group")

                                connection.Close()

                                Me.Hide()

                                str = "hr"
                                flag = "HR"
                                querystatus = "HRStatus"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewHRGroup.LabelHRName, labelname)

                                Dashboard.Show()
                                TextBox2.Clear()
                            ElseIf usertype = "Interview" Then

                                MsgBox("Welcome HR Interview")

                                connection.Close()

                                Me.Hide()

                                str = "hrinterview"
                                flag = "HR Interview"
                                querystatus = "HRStatus"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewHRInterview.LabelHRInterviewName, labelname)

                                Dashboard.Show()
                                TextBox2.Clear()
                            ElseIf usertype = "Supervisor" Then

                                MsgBox("Welcome HR Head '" & TextBox1.Text & "'")

                                connection.Close()

                                Me.Hide()

                                str = "hrhead"
                                flag = "HR Head"
                                querystatus = "HRHeadStatus"
                                queryhistory = "historyrequest"

                                labelname = "Select name FROM login WHERE user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                                classlabel.LabelStatus(ViewHRHead.LabelHRHeadName, labelname)


                                Dashboard.Show()
                                TextBox2.Clear()
                            End If
                        End If

                    Else

                        count = count + 1

                        If count < 3 Then
                            MsgBox("USERNAME OR PASSWORD INCORRECT", MsgBoxStyle.Critical, "Login Error")
                        End If

                        If count = 3 Then
                            MsgBox("You exceed try again, app is now close", MsgBoxStyle.Critical)
                            Me.Close()
                        End If

                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for internet connection: " & ex.Message)
        Finally
            dbs.returnConnection(dbs.getConn())
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked


    End Sub


End Class
