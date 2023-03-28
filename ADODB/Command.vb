Namespace ADODB
    Public Class Command
        Friend ActiveConnection As Connection
        Friend CommandText As String

        Public Function Execute() As Object
            Dim result As Object = Nothing
            Using cmd As New OleDb.OleDbCommand(CommandText, ActiveConnection.conn)
                result = cmd.ExecuteNonQuery()
            End Using
            Return result
        End Function
    End Class
End Namespace
