Imports MySql.Data.MySqlClient
Public Class connection
    Public conn As New MySqlConnection
    Public connStr As New MySqlConnectionStringBuilder

    'Assigns the Proper Value to the Connection String
    Public Sub New()
        connStr.Server = "localhost"
        connStr.UserID = My.Settings.CurrentSession_DBUsername
        connStr.Password = My.Settings.CurrentSession_Password
        connStr.Database = My.Settings.CurrentSession_DBName
        connStr.Port = "3306"
        conn.ConnectionString = connStr.ConnectionString
    End Sub

    'Connects to the Database
    Public Sub connect()
        Try
            conn.Close()
            conn.Open()
        Catch ex As MySqlException
            MsgBox("Error Connecting to Database")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Disconnects
    Public Sub disconnect()
        conn.Close()
    End Sub
End Class
