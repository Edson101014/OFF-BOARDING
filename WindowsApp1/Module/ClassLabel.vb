Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.IO
Public Class ClassLabel
    Dim dbs As New db
    Dim x As Integer

    Public Sub LabelHRName()
        Dim sql As String = "SELECT BDGDeptName, SDGSuperName, SDGDeptName, ITOPSDeptName, PMGDeptName, MarketingDeptName, FinanceHeadName, FinanceDeptName, AdminGroupName, AdminHeadName, SysAdminName, SysAdminHeadName FROM historyrequest WHERE empID='" & ViewHRGroup.LabelEmpID.Text & "'"

        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ViewHRGroup.txtboxBDGName.Text = If(String.IsNullOrEmpty(reader("BDGDeptName").ToString()), "Pending", reader("BDGDeptName").ToString())
                ViewHRGroup.txtboxSDGHeadName.Text = If(String.IsNullOrEmpty(reader("SDGSuperName").ToString()), "Pending", reader("SDGSuperName").ToString())
                ViewHRGroup.txtboxSDGName.Text = If(String.IsNullOrEmpty(reader("SDGDeptName").ToString()), "Pending", reader("SDGDeptName").ToString())
                ViewHRGroup.txtboxITOPSName.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptName").ToString()), "Pending", reader("ITOPSDeptName").ToString())
                ViewHRGroup.txtboxPMGName.Text = If(String.IsNullOrEmpty(reader("PMGDeptName").ToString()), "Pending", reader("PMGDeptName").ToString())
                ViewHRGroup.txtboxMarketingName.Text = If(String.IsNullOrEmpty(reader("MarketingDeptName").ToString()), "Pending", reader("MarketingDeptName").ToString())
                ViewHRGroup.txtboxFinanceHeadName.Text = If(String.IsNullOrEmpty(reader("FinanceHeadName").ToString()), "Pending", reader("FinanceHeadName").ToString())
                ViewHRGroup.txtboxFinanceName.Text = If(String.IsNullOrEmpty(reader("FinanceDeptName").ToString()), "Pending", reader("FinanceDeptName").ToString())
                ViewHRGroup.txtboxAdminName.Text = If(String.IsNullOrEmpty(reader("AdminGroupName").ToString()), "Pending", reader("AdminGroupName").ToString())
                ViewHRGroup.txtboxAdminHeadName.Text = If(String.IsNullOrEmpty(reader("AdminHeadName").ToString()), "Pending", reader("AdminHeadName").ToString())
                ViewHRGroup.txtboxSysAdminName.Text = If(String.IsNullOrEmpty(reader("SysAdminName").ToString()), "Pending", reader("SysAdminName").ToString())
                ViewHRGroup.txtboxSysAdminHeadName.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadName").ToString()), "Pending", reader("SysAdminHeadName").ToString())
            End While

            reader.Close()
            conn.Close()
            dbs.returnConnection(conn)
        End Using


    End Sub

    Public Sub LabelHRStatus()
        Dim sql As String = "SELECT BDGDeptStatus, SDGSuperStatus, SDGDeptStatus, ITOPSDeptStatus, PMGDeptStatus, MarketingDeptStatus, FinanceHeadStatus, FinanceDeptStatus, AdminGroupStatus, AdminHeadStatus, SysAdminStatus, SysAdminHeadStatus FROM historyrequest WHERE empID='" & ViewHRGroup.LabelEmpID.Text & "'"

        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ViewHRGroup.BDGAccept.Text = If(String.IsNullOrEmpty(reader("BDGDeptStatus").ToString()), "Pending", reader("BDGDeptStatus").ToString())
                ViewHRGroup.SDGHeadAccept.Text = If(String.IsNullOrEmpty(reader("SDGSuperStatus").ToString()), "Pending", reader("SDGSuperStatus").ToString())
                ViewHRGroup.SDGDeptAccept.Text = If(String.IsNullOrEmpty(reader("SDGDeptStatus").ToString()), "Pending", reader("SDGDeptStatus").ToString())
                ViewHRGroup.ITOPSAccept.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptStatus").ToString()), "Pending", reader("ITOPSDeptStatus").ToString())
                ViewHRGroup.PMGAccept.Text = If(String.IsNullOrEmpty(reader("PMGDeptStatus").ToString()), "Pending", reader("PMGDeptStatus").ToString())
                ViewHRGroup.MarketingAccept.Text = If(String.IsNullOrEmpty(reader("MarketingDeptStatus").ToString()), "Pending", reader("MarketingDeptStatus").ToString())
                ViewHRGroup.FinanceHead.Text = If(String.IsNullOrEmpty(reader("FinanceHeadStatus").ToString()), "Pending", reader("FinanceHeadStatus").ToString())
                ViewHRGroup.FinanceAccept.Text = If(String.IsNullOrEmpty(reader("FinanceDeptStatus").ToString()), "Pending", reader("FinanceDeptStatus").ToString())
                ViewHRGroup.AdminAccept.Text = If(String.IsNullOrEmpty(reader("AdminGroupStatus").ToString()), "Pending", reader("AdminGroupStatus").ToString())
                ViewHRGroup.AdminHeadAccept.Text = If(String.IsNullOrEmpty(reader("AdminHeadStatus").ToString()), "Pending", reader("AdminHeadStatus").ToString())
                ViewHRGroup.SysAdminAccept.Text = If(String.IsNullOrEmpty(reader("SysAdminStatus").ToString()), "Pending", reader("SysAdminStatus").ToString())
                ViewHRGroup.SysAdminHeadAccept.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadStatus").ToString()), "Pending", reader("SysAdminHeadStatus").ToString())
            End While

            reader.Close()
            conn.Close()
            dbs.returnConnection(conn)
        End Using


    End Sub

    Public Sub LabelHRComment()
        Dim sql As String = "SELECT BDGDeptComment, SDGSuperComment, SDGDeptComment, ITOPSDeptComment, PMGDeptComment, MarketingDeptComment, FinanceHeadComment, FinanceDeptComment, AdminGroupComment, AdminHeadComment, SysAdminComment, SysAdminHeadComment FROM historyrequest WHERE empID='" & ViewHRGroup.LabelEmpID.Text & "'"

        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ViewHRGroup.BDGComment.Text = If(String.IsNullOrEmpty(reader("BDGDeptComment").ToString()), "Pending", reader("BDGDeptComment").ToString())
                ViewHRGroup.SDGHeadComment.Text = If(String.IsNullOrEmpty(reader("SDGSuperComment").ToString()), "Pending", reader("SDGSuperComment").ToString())
                ViewHRGroup.SDGComment.Text = If(String.IsNullOrEmpty(reader("SDGDeptComment").ToString()), "Pending", reader("SDGDeptComment").ToString())
                ViewHRGroup.ITOPSComment.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptComment").ToString()), "Pending", reader("ITOPSDeptComment").ToString())
                ViewHRGroup.PMGComment.Text = If(String.IsNullOrEmpty(reader("PMGDeptComment").ToString()), "Pending", reader("PMGDeptComment").ToString())
                ViewHRGroup.MarketingComment.Text = If(String.IsNullOrEmpty(reader("MarketingDeptComment").ToString()), "Pending", reader("MarketingDeptComment").ToString())
                ViewHRGroup.FinanceHeadComment.Text = If(String.IsNullOrEmpty(reader("FinanceHeadComment").ToString()), "Pending", reader("FinanceHeadComment").ToString())
                ViewHRGroup.FinanceComment.Text = If(String.IsNullOrEmpty(reader("FinanceDeptComment").ToString()), "Pending", reader("FinanceDeptComment").ToString())
                ViewHRGroup.AdminComment.Text = If(String.IsNullOrEmpty(reader("AdminGroupComment").ToString()), "Pending", reader("AdminGroupComment").ToString())
                ViewHRGroup.AdminHeadComment.Text = If(String.IsNullOrEmpty(reader("AdminHeadComment").ToString()), "Pending", reader("AdminHeadComment").ToString())
                ViewHRGroup.SysAdminComment.Text = If(String.IsNullOrEmpty(reader("SysAdminComment").ToString()), "Pending", reader("SysAdminComment").ToString())
                ViewHRGroup.SysAdminHeadComment.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadComment").ToString()), "Pending", reader("SysAdminHeadComment").ToString())
            End While

            reader.Close()
            conn.Close()
            dbs.returnConnection(conn)
        End Using


    End Sub



    Public Sub LabelHRDate()
        Dim sql As String = "SELECT BDGDeptDate, SDGSuperDate, SDGDeptDate, ITOPSDeptDate, PMGDeptDate, MarketingDeptDate, FinanceHeadDate, FinanceDeptDate, AdminGroupDate, AdminHeadDate, SysAdminDate, SysAdminHeadDate FROM historyrequest WHERE empID='" & ViewHRGroup.LabelEmpID.Text & "'"

        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ViewHRGroup.BDGDate.Text = If(String.IsNullOrEmpty(reader("BDGDeptDate").ToString()), "Pending", DateTime.Parse(reader("BDGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.SDGHeadDate.Text = If(String.IsNullOrEmpty(reader("SDGSuperDate").ToString()), "Pending", DateTime.Parse(reader("SDGSuperDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.SDGDate.Text = If(String.IsNullOrEmpty(reader("SDGDeptDate").ToString()), "Pending", DateTime.Parse(reader("SDGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.ITOPSDate.Text = If(String.IsNullOrEmpty(reader("ITOPSDeptDate").ToString()), "Pending", DateTime.Parse(reader("ITOPSDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.PMGDate.Text = If(String.IsNullOrEmpty(reader("PMGDeptDate").ToString()), "Pending", DateTime.Parse(reader("PMGDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.MarketingDate.Text = If(String.IsNullOrEmpty(reader("MarketingDeptDate").ToString()), "Pending", DateTime.Parse(reader("MarketingDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.FinanceHeadDate.Text = If(String.IsNullOrEmpty(reader("FinanceHeadDate").ToString()), "Pending", DateTime.Parse(reader("FinanceHeadDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.FinanceDate.Text = If(String.IsNullOrEmpty(reader("FinanceDeptDate").ToString()), "Pending", DateTime.Parse(reader("FinanceDeptDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.AdminDate.Text = If(String.IsNullOrEmpty(reader("AdminGroupDate").ToString()), "Pending", DateTime.Parse(reader("AdminGroupDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.AdminHeadDate.Text = If(String.IsNullOrEmpty(reader("AdminHeadDate").ToString()), "Pending", DateTime.Parse(reader("AdminHeadDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.SysAdminDate.Text = If(String.IsNullOrEmpty(reader("SysAdminDate").ToString()), "Pending", DateTime.Parse(reader("SysAdminDate").ToString()).ToString("MMM-dd-yyyy"))
                ViewHRGroup.SysAdminHeadDate.Text = If(String.IsNullOrEmpty(reader("SysAdminHeadDate").ToString()), "Pending", DateTime.Parse(reader("SysAdminHeadDate").ToString()).ToString("MMM-dd-yyyy"))
            End While

            reader.Close()
            conn.Close()
            dbs.returnConnection(conn)
        End Using
    End Sub


    Public Sub LabelStatus(ByRef lbl As Label, ByVal sql As String)
        Try

            Using conn As MySqlConnection = dbs.getConn()
                Dim cmd As New MySqlCommand(sql, conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    For x = 0 To reader.FieldCount - 1
                        If reader.IsDBNull(x) Then
                            lbl.Text = "Pending"
                        Else
                            lbl.Text = reader.GetValue(x).ToString
                        End If
                    Next x
                End While
                reader.Close()
                conn.Close()
                dbs.returnConnection(conn)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try



    End Sub


    Public Async Sub sentmail()

        Try
            Loading.Show()
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim folderName As String = "Resources"
            Dim fileName As String = "index.html"
            Dim filePath As String = Path.Combine(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), folderName), fileName)

            If File.Exists(filePath) Then
                Dim path As New FileStream(filePath, FileMode.Open)
                Dim str As New StreamReader(path)
                Dim Mailtext As String = str.ReadToEnd
                str.Close()

                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("ojt.systemadmin@findme.com.ph", "kucgpmvpetlhbjzo")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                ' Retrieve all emails from database

                Dim query As String = "SELECT email FROM login WHERE department != 'HR' OR (title != 'Supervisor' OR title IS NULL) ORDER BY department ASC"

                Using conn As MySqlConnection = dbs.getConn()
                    Dim cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim email As String = reader.GetString("email")

                        ' Populate email content
                        Mailtext = Mailtext.Replace("@empname", ViewHRInterview.LabelEmpName.Text)
                        Mailtext = Mailtext.Replace("@empID", ViewHRInterview.LabelEmpID.Text)
                        Mailtext = Mailtext.Replace("@empPos", ViewHRInterview.LabelPos.Text)
                        Mailtext = Mailtext.Replace("@empStatus", ViewHRInterview.LabelStatus.Text)
                        Mailtext = Mailtext.Replace("@clearPurpose", ViewHRInterview.LabelPurpose.Text)
                        Mailtext = Mailtext.Replace("@lastday", ViewHRInterview.LabelLastDay.Text)
                        Mailtext = Mailtext.Replace("@dept", ViewHRInterview.LabelDept.Text)

                        e_mail = New MailMessage
                        e_mail.From = New MailAddress("no-reply@gmail.com")
                        e_mail.To.Add(email)

                        e_mail.Subject = "Request Approval Notification"
                        e_mail.IsBodyHtml = True
                        e_mail.Body = Mailtext

                        ' Send email to recipient
                        Await Smtp_Server.SendMailAsync(e_mail)
                        Await Task.Delay(1500) ' Delay 1 second before sending next email
                    End While
                    reader.Close()
                    conn.Close()
                    dbs.returnConnection(conn)
                End Using

            End If

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub


End Class
