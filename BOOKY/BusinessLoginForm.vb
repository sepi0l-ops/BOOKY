Imports System.Data.OleDb

Public Class BusinessLoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sam Sepiol\Desktop\Visual Basic\Project\BOOKY.accdb"
        Dim email As String = EmailAddressTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT * FROM User_Registration WHERE Email = '" & EmailAddressTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "'"
            Using command As New OleDbCommand(commandText, connection)
                command.Parameters.AddWithValue("EmailAddressTextBox.Text", email)
                command.Parameters.AddWithValue("PasswordTextBox.Text", password)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Login Successful")
                Else
                    MsgBox("Invalid login")
                End If
            End Using
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BusinessRegistrationForm.Show()
        Me.Hide()
    End Sub
End Class
