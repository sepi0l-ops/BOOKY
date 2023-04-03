'Imports ADODB
Imports BOOKY.ADODB

Public Class UserRegistrationForm
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim conn As New Connection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sam Sepiol\Desktop\Visual Basic\Project\BOOKY.accdb;"
        conn.Open()
        Dim cmd As New Command With {
            .ActiveConnection = conn,
            .CommandText = "INSERT INTO User_Registration ([First Name:], [Last Name:], [Email Address:],[Password], [Contact:]) VALUES ('" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & EmailTextBox.Text & "','" & PasswordTextBox.Text & "','" & ContactTextBox.Text & "')"
        }
        Dim value = cmd.Execute

        conn.Close()
        MsgBox("Registered successfully")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub
End Class
