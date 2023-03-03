Imports MySql.Data.MySqlClient
Public Class db
    Public ReadOnly connectionString As String = "server=sql12.freemysqlhosting.net;port=3306;user id=sql12601944;password=QgulMDRHcM;database=sql12601944;Pooling=True;Min Pool Size=0;Max Pool Size=100;"
    Public ReadOnly connectionPool As New Queue(Of MySqlConnection)
    Public ReadOnly poolLock As New Object()

    Public Function getConn() As MySqlConnection
        SyncLock poolLock
            If connectionPool.Count > 0 Then
                Dim connection = connectionPool.Dequeue()
                If connection.State <> ConnectionState.Open Then
                    connection.Open()
                End If
                Return connection
            End If
        End SyncLock

        Return New MySqlConnection(connectionString)
    End Function

    Public Sub returnConnection(ByRef connection As MySqlConnection)
        SyncLock poolLock
            If connection.State = ConnectionState.Open Then
                connectionPool.Enqueue(connection)
            End If
        End SyncLock
    End Sub
End Class
