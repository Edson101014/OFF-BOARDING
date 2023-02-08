Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.IO
Public Class ClassLabel
    Dim dbs As New db
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim x As Integer

    Public Sub LabelName(ByRef txt As TextBox, ByVal sql As String)
        Try
            cmd.Connection = dbs.getconn
            dbs.opencon()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader

            While reader.Read
                For x = 0 To reader.FieldCount - 1
                    If reader.IsDBNull(x) Then
                        txt.Text = ""
                    Else
                        txt.Text = reader.GetValue(x).ToString
                    End If
                Next x
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

        dbs.closecon()

    End Sub

    Public Sub LabelStatus(ByRef lbl As Label, ByVal sql As String)
        Try
            cmd.Connection = dbs.getconn
            dbs.opencon()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader

            While reader.Read
                For x = 0 To reader.FieldCount - 1
                    If reader.IsDBNull(x) Then
                        lbl.Text = "Pending"
                    Else
                        lbl.Text = reader.GetValue(x).ToString
                    End If
                Next x
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

        dbs.closecon()

    End Sub

    Public Sub LabelComment(ByRef lbl As Label, ByVal sql As String)
        Try
            cmd.Connection = dbs.getconn
            dbs.opencon()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader

            While reader.Read
                For x = 0 To reader.FieldCount - 1
                    If reader.IsDBNull(x) Then
                        lbl.Text = "Pending"
                    Else
                        lbl.Text = reader.GetValue(x).ToString
                    End If
                Next x
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

        dbs.closecon()

    End Sub

    Public Sub LabelDate(ByRef lbl As Label, ByVal sql As String)
        Try
            cmd.Connection = dbs.getconn
            dbs.opencon()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader

            While reader.Read
                For x = 0 To reader.FieldCount - 1
                    If reader.IsDBNull(x) Then
                        lbl.Text = "Waiting"
                    Else
                        lbl.Text = DateTime.Parse(reader.GetValue(x).ToString()).ToString("MMM-dd-yyyy")
                    End If
                Next x
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try

        dbs.closecon()
    End Sub

    Public Async Sub sentmail(ByVal mail As String)

        Try
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
                Smtp_Server.Credentials = New Net.NetworkCredential("edsonpaul98@gmail.com", "jytxsnpnpkpmtatv")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"


                Mailtext = Mailtext.Replace("@empname", ViewRequest.LabelEmpName.Text)
                Mailtext = Mailtext.Replace("@empID", ViewRequest.LabelEmpID.Text)
                Mailtext = Mailtext.Replace("@empPos", ViewRequest.LabelPos.Text)
                Mailtext = Mailtext.Replace("@empStatus", ViewRequest.LabelStatus.Text)
                Mailtext = Mailtext.Replace("@clearPurpose", ViewRequest.LabelPurpose.Text)
                Mailtext = Mailtext.Replace("@lastday", ViewRequest.LabelLastDay.Text)
                Mailtext = Mailtext.Replace("@dept", ViewRequest.LabelDept.Text)

                e_mail = New MailMessage
                e_mail.From = New MailAddress("no-reply@gmail.com")
                e_mail.To.Add(mail)

                e_mail.Subject = "Request Approval Notification"
                e_mail.IsBodyHtml = True
                e_mail.Body = Mailtext
                Smtp_Server.Send(e_mail)

                Await Smtp_Server.SendMailAsync(e_mail)


            End If

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub
    Public Sub multimail(ByRef mail1 As String, ByRef mail2 As String, ByRef mail3 As String)

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim path As New FileStream("C:\Users\edson\source\repos\Resignee\Resignee\Resources\index.html", FileMode.Open)
            Dim str As New StreamReader(path)
            Dim Mailtext As String = str.ReadToEnd
            str.Close()

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("edsonpaul98@gmail.com", "RXISxTJO230jYFw1")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp-relay.sendinblue.com"


            Mailtext = Mailtext.Replace("@empname", ViewRequest.LabelEmpName.Text)
            Mailtext = Mailtext.Replace("@empID", ViewRequest.LabelEmpID.Text)
            Mailtext = Mailtext.Replace("@empPos", ViewRequest.LabelPos.Text)
            Mailtext = Mailtext.Replace("@empStatus", ViewRequest.LabelStatus.Text)
            Mailtext = Mailtext.Replace("@clearPurpose", ViewRequest.LabelPurpose.Text)
            Mailtext = Mailtext.Replace("@lastday", ViewRequest.LabelLastDay.Text)
            Mailtext = Mailtext.Replace("@dept", ViewRequest.LabelDept.Text)

            e_mail = New MailMessage
            e_mail.From = New MailAddress("no-reply@gmail.com")
            e_mail.To.Add(mail1)
            e_mail.To.Add(mail2)
            e_mail.To.Add(mail3)

            e_mail.Subject = "Request Approval Notification"
            e_mail.IsBodyHtml = True
            e_mail.Body = Mailtext
            Smtp_Server.Send(e_mail)
            MsgBox("Email sent")


        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub
End Class
