Namespace ADODB
    Public Class Connection
        Public conn As New OleDb.OleDbConnection()

        Public Property ConnectionString As String
            Get
                Return conn.ConnectionString
            End Get
            Set(value As String)
                conn.ConnectionString = value
            End Set
        End Property

        Public Sub Open()
            conn.Open()
        End Sub

        Public Sub Close()
            conn.Close()
        End Sub

        Public Function Execute(sql As String) As Integer
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            Return cmd.ExecuteNonQuery()
        End Function

        Public Function Query(sql As String) As DataTable
            Dim dt As New DataTable()
            Dim da As New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            Return dt
        End Function
    End Class
End Namespace
