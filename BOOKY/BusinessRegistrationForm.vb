﻿Imports BOOKY.ADODB
'Imports ADODB
Public Class BusinessRegistrationForm

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim conn As New Connection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sam Sepiol\Desktop\Visual Basic\Project\BOOKY.accdb"
        conn.Open()
        Dim cmd As New Command With {
            .ActiveConnection = conn,
            .CommandText = "INSERT INTO Business_Registration ([Business Name], [Business Owner], [Business Address], [Email Address], [Password], [Contact], [ID No], [Description], [Category]) VALUES ('" & BusinessNameTextBox.Text & "', '" & BusinessOwnerTextBox.Text & "', '" & BusinessAddressTextBox.Text & "', '" & EmailAddressTextBox.Text & "', '" & PasswordTextBox.Text & "', '" & ContactTextBox.Text & "', '" & IDNoTextBox.Text & "', '" & DescriptionTextBox.Text & "', '" & CategoryTextBox.Text & "')"
        }
        Dim value = cmd.Execute()
        conn.Close()
        MsgBox("Registered Successfully")


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub


End Class