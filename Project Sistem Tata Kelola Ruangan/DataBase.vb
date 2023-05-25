Imports MySql.Data.MySqlClient

Module DataBase
    Dim dtConn As String = "server=localhost;uid=root;database=tatakelola_ruangvb"
    Dim objek As Object
    Public Conn As New MySqlConnection(dtConn)
    Public Cmd As New MySqlCommand
    Public Rd As MySqlDataReader
    Public Da As New MySqlDataAdapter
    Public Ds As New DataSet
    Public getData As String
    Public insData As String
    Public updData As String
    Public delData As String
    Public submit As Boolean
    Public datatable As New DataTable

    Function checklogin(ByVal tbusername As String, ByVal tbpassword As String) As Integer
        Try
            Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = "SELECT COUNT(username) AS getin " & _
                               "FROM users WHERE username = " & _
                               "'" & tbusername & "' AND " & "password = '" & tbpassword & "'"
            objek = Cmd.ExecuteScalar
            Conn.Close()

            If objek Is Nothing Then
                Return 0
            Else
                Return CInt(objek)
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
            Return 0
        Finally
            Conn.Dispose()

        End Try

    End Function
End Module
