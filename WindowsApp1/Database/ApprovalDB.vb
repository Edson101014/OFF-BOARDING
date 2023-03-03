Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ApprovalDB
    Dim dbs As New db
    Public Function getemployee(ByVal command As MySqlCommand) As DataTable

        Dim resultTable As New DataTable()

        Using conn As MySqlConnection = dbs.getConn()
            command.Connection = conn
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(resultTable)
            dbs.returnConnection(conn)
        End Using

        Return resultTable
    End Function


    'INSERT HISTORY

    Public Function insertchecker(ByVal empID As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using

        Return result

    End Function

    Public Function insertcompleterequest(ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using

        Return result
    End Function

    Public Function insertNextFlow(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal stats As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate

            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using

        Return result
    End Function

    Public Function insertHistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result

    End Function


    Public Function insertFinance(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checkcash As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            cmd.Parameters.Add("@checkcash", MySqlDbType.VarChar).Value = checkcash
            cmd.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
            cmd.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True

            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function


    Public Function insertAdminhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
           cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            cmd.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
            cmd.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
            cmd.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
            cmd.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
            cmd.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
            cmd.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function insertSysAdminhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checklaptop As String, ByVal checkemail As String, ByVal checkcom As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            cmd.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
            cmd.Parameters.Add("@checkemail", MySqlDbType.VarChar).Value = checkemail
            cmd.Parameters.Add("@checkcom", MySqlDbType.VarChar).Value = checkcom

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function insertHRhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal essdeact As String, ByVal comphealth As String, ByVal payroll As String, ByVal others As String, ByVal othercomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
            cmd.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
            cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
            cmd.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
            cmd.Parameters.Add("@essdeact", MySqlDbType.VarChar).Value = essdeact
            cmd.Parameters.Add("@comphealth", MySqlDbType.VarChar).Value = comphealth
            cmd.Parameters.Add("@payroll", MySqlDbType.VarChar).Value = payroll
            cmd.Parameters.Add("@others", MySqlDbType.VarChar).Value = others
            cmd.Parameters.Add("@othercomment", MySqlDbType.VarChar).Value = othercomment


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function insertHRUser(ByRef user As String, ByVal pass As String, ByVal name As String, ByVal email As String, ByVal title As String, ByVal dept As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            cmd.Parameters.Add("@title", MySqlDbType.VarChar).Value = title
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function



    'END OF INSERT








    'UPDATE HISTORY
    Public Function updateinterview(ByVal lblname As String, ByVal interviewstat As String, ByVal dateapp As Date, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)


            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@interviewstat", MySqlDbType.VarChar).Value = interviewstat
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function


    Public Function updatechecker(ByVal check As Integer, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)


            cmd.Parameters.Add("@check", MySqlDbType.VarChar).Value = check

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function


    Public Function updateHistory(ByVal name As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result

    End Function



    Public Function updateFinance(ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checkcash As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
            cmd.Parameters.Add("@checkcash", MySqlDbType.VarChar).Value = checkcash
            cmd.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
            cmd.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result

    End Function


    Public Function updateAdmin(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

            cmd.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
            cmd.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
            cmd.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
            cmd.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
            cmd.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
            cmd.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function updateSysAdmin(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checklaptop As String, ByVal checkemail As String, ByVal checkcomputer As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

            cmd.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
            cmd.Parameters.Add("@checkemail", MySqlDbType.VarChar).Value = checkemail
            cmd.Parameters.Add("@checkcom", MySqlDbType.VarChar).Value = checkcomputer

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function updateAdminDateNull(ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checklaptop As String, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = DBNull.Value
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

            cmd.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
            cmd.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
            cmd.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
            cmd.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
            cmd.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
            cmd.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
            cmd.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function

    Public Function updateHRHistory(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkHMO As String, ByVal checkInsurance As String, ByVal checkCompanyID As String, ByVal checkQuitClaim As String, ByVal checkCOE As String, ByVal checkITR As String, ByVal checkFinalPay As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
            cmd.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
            cmd.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
            cmd.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

            cmd.Parameters.Add("@checkHMO", MySqlDbType.VarChar).Value = checkHMO
            cmd.Parameters.Add("@checkInsurance", MySqlDbType.VarChar).Value = checkInsurance
            cmd.Parameters.Add("@checkCompanyID", MySqlDbType.VarChar).Value = checkCompanyID
            cmd.Parameters.Add("@checkQuitClaim", MySqlDbType.VarChar).Value = checkQuitClaim
            cmd.Parameters.Add("@checkCOE", MySqlDbType.VarChar).Value = checkCOE
            cmd.Parameters.Add("@checkITR", MySqlDbType.VarChar).Value = checkITR
            cmd.Parameters.Add("@checkFinalPay", MySqlDbType.VarChar).Value = checkFinalPay
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function



    'END OF UPDATE




    'DELETE REQUEST
    Public Function deleteRequest(ByVal id As String, sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@empID", MySqlDbType.VarChar).Value = id


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result


    End Function



    'END OF REQUEST

    Public Function deleteHRuser(ByVal id As String, sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = id


            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result


    End Function

    Public Function updateHRUser(ByRef user As String, ByVal pass As String, ByVal name As String, ByVal email As String, ByVal title As String, ByVal dept As String, ByVal sql As String) As Boolean
        Dim result As Boolean = False
        Using conn As MySqlConnection = dbs.getConn()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            cmd.Parameters.Add("@title", MySqlDbType.VarChar).Value = title
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                result = True
            End If
            conn.Close()
            dbs.returnConnection(conn)
        End Using
        Return result
    End Function
End Class