Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ApprovalDB
    Dim dbs As New db
    Public Function getemployee(ByVal command As MySqlCommand) As DataTable

        command.Connection = dbs.getconn()
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table
    End Function

    'INSERT HISTORY

    Public Function insertchecker(ByVal empID As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@empID", MySqlDbType.VarChar).Value = empID



        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertcompleterequest(ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertNextFlow(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal stats As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertHistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

        dbs.opencon()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False

        End If

    End Function


    Public Function insertFinance(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checkcash As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@checkcash", MySqlDbType.VarChar).Value = checkcash
        command.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
        command.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function


    Public Function insertAdminhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate

        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

        command.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
        command.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
        command.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
        command.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
        command.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
        command.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertSysAdminhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checklaptop As String, ByVal checkemail As String, ByVal checkcom As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

        command.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
        command.Parameters.Add("@checkemail", MySqlDbType.VarChar).Value = checkemail
        command.Parameters.Add("@checkcom", MySqlDbType.VarChar).Value = checkcom

        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertHRhistory(ByRef empName As String, ByVal empID As String, ByVal depart As String, ByVal empPos As String, ByVal clPurpose As String, ByVal empStatus As String, ByVal septDate As Date, ByVal essdeact As String, ByVal comphealth As String, ByVal payroll As String, ByVal others As String, ByVal othercomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@eName", MySqlDbType.VarChar).Value = empName
        command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = empID
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = depart
        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = empPos
        command.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = clPurpose
        command.Parameters.Add("@stat", MySqlDbType.VarChar).Value = empStatus
        command.Parameters.Add("@lastday", MySqlDbType.Date).Value = septDate
        command.Parameters.Add("@essdeact", MySqlDbType.VarChar).Value = essdeact
        command.Parameters.Add("@comphealth", MySqlDbType.VarChar).Value = comphealth
        command.Parameters.Add("@payroll", MySqlDbType.VarChar).Value = payroll
        command.Parameters.Add("@others", MySqlDbType.VarChar).Value = others
        command.Parameters.Add("@othercomment", MySqlDbType.VarChar).Value = othercomment


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function insertHRUser(ByRef user As String, ByVal pass As String, ByVal name As String, ByVal email As String, ByVal title As String, ByVal dept As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function



    'END OF INSERT








    'UPDATE HISTORY
    Public Function updateinterview(ByVal lblname As String, ByVal interviewstat As String, ByVal dateapp As Date, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())



        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@interviewstat", MySqlDbType.VarChar).Value = interviewstat
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp

        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function


    Public Function updatechecker(ByVal check As Integer, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())


        command.Parameters.Add("@check", MySqlDbType.VarChar).Value = check


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function


    Public Function updateHistory(ByVal name As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function



    Public Function updateFinance(ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checkcash As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@checkcash", MySqlDbType.VarChar).Value = checkcash
        command.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
        command.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()
    End Function


    Public Function updateAdmin(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

        command.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
        command.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
        command.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
        command.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
        command.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
        command.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function updateSysAdmin(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checklaptop As String, ByVal checkemail As String, ByVal checkcomputer As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

        command.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
        command.Parameters.Add("@checkemail", MySqlDbType.VarChar).Value = checkemail
        command.Parameters.Add("@checkcom", MySqlDbType.VarChar).Value = checkcomputer

        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function updateAdminDateNull(ByVal lblname As String, ByVal stats As String, ByVal dateapp As Date, ByVal comment As String, ByVal checklaptop As String, ByVal checkteleco As String, ByVal checktools As String, ByVal checkphone As String, ByVal checktable As String, ByVal checkothers As String, ByVal checkotherscomment As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = DBNull.Value
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

        command.Parameters.Add("@checklaptop", MySqlDbType.VarChar).Value = checklaptop
        command.Parameters.Add("@checkteleco", MySqlDbType.VarChar).Value = checkteleco
        command.Parameters.Add("@checktools", MySqlDbType.VarChar).Value = checktools
        command.Parameters.Add("@checkphone", MySqlDbType.VarChar).Value = checkphone
        command.Parameters.Add("@checktable", MySqlDbType.VarChar).Value = checktable
        command.Parameters.Add("@checkothers", MySqlDbType.VarChar).Value = checkothers
        command.Parameters.Add("@checkotherscomment", MySqlDbType.VarChar).Value = checkotherscomment
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function

    Public Function updateHRHistory(ByVal lblname As String, ByVal stats As String, ByVal comment As String, ByVal dateapp As Date, ByVal checkHMO As String, ByVal checkInsurance As String, ByVal checkCompanyID As String, ByVal checkQuitClaim As String, ByVal checkCOE As String, ByVal checkITR As String, ByVal checkFinalPay As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())

        command.Parameters.Add("@lblname", MySqlDbType.VarChar).Value = lblname
        command.Parameters.Add("@stats", MySqlDbType.VarChar).Value = stats
        command.Parameters.Add("@dateapp", MySqlDbType.Date).Value = dateapp
        command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment

        command.Parameters.Add("@checkHMO", MySqlDbType.VarChar).Value = checkHMO
        command.Parameters.Add("@checkInsurance", MySqlDbType.VarChar).Value = checkInsurance
        command.Parameters.Add("@checkCompanyID", MySqlDbType.VarChar).Value = checkCompanyID
        command.Parameters.Add("@checkQuitClaim", MySqlDbType.VarChar).Value = checkQuitClaim
        command.Parameters.Add("@checkCOE", MySqlDbType.VarChar).Value = checkCOE
        command.Parameters.Add("@checkITR", MySqlDbType.VarChar).Value = checkITR
        command.Parameters.Add("@checkFinalPay", MySqlDbType.VarChar).Value = checkFinalPay
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function



    'END OF UPDATE




    'DELETE REQUEST
    Public Function deleteRequest(ByVal id As String, admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@empID", MySqlDbType.VarChar).Value = id


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()

    End Function



    'END OF REQUEST

    Public Function deleteHRuser(ByVal id As String, admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = id


        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
        dbs.closecon()

    End Function

    Public Function updateHRUser(ByRef user As String, ByVal pass As String, ByVal name As String, ByVal email As String, ByVal title As String, ByVal dept As String, ByVal admin As String) As Boolean
        Dim command As New MySqlCommand(admin, dbs.getconn())
        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title
        command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept
        dbs.opencon()
        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If
    End Function
End Class