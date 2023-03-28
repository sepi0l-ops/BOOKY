Public Class WelcomeForm
    Private Sub UserRegistrationButton_Click(sender As Object, e As EventArgs) Handles UserRegistrationButton.Click
        UserLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub BusinessRegistrationButton_Click(sender As Object, e As EventArgs) Handles BusinessRegistrationButton.Click
        BusinessLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class