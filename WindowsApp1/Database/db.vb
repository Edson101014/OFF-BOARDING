﻿Imports MySql.Data.MySqlClient
Public Class db
    Public con As New MySqlConnection("server=sql12.freemysqlhosting.net;port=3306;user id=sql12601944;password=QgulMDRHcM;database=sql12601944")

    ReadOnly Property getconn() As MySqlConnection
        Get
            Return con
        End Get
    End Property

    Sub opencon()
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
    End Sub
    Sub closecon()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
    End Sub
End Class
