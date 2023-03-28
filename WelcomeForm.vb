Public Class WelcomeForm
    Private Sub UserRegistrationButton_Click(sender As Object, e As EventArgs) Handles UserRegistrationButton.Click
        UserRegistrationForm.Show()
    End Sub

    Private Sub BusinessRegistrationButton_Click(sender As Object, e As EventArgs) Handles BusinessRegistrationButton.Click
        BusinessRegistrationForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class