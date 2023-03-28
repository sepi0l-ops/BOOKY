<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserRegistrationButton = New System.Windows.Forms.Button()
        Me.BusinessRegistrationButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserRegistrationButton
        '
        Me.UserRegistrationButton.Location = New System.Drawing.Point(60, 120)
        Me.UserRegistrationButton.Name = "UserRegistrationButton"
        Me.UserRegistrationButton.Size = New System.Drawing.Size(103, 23)
        Me.UserRegistrationButton.TabIndex = 0
        Me.UserRegistrationButton.Text = "Customer"
        Me.UserRegistrationButton.UseVisualStyleBackColor = True
        '
        'BusinessRegistrationButton
        '
        Me.BusinessRegistrationButton.Location = New System.Drawing.Point(271, 120)
        Me.BusinessRegistrationButton.Name = "BusinessRegistrationButton"
        Me.BusinessRegistrationButton.Size = New System.Drawing.Size(120, 23)
        Me.BusinessRegistrationButton.TabIndex = 1
        Me.BusinessRegistrationButton.Text = "Business "
        Me.BusinessRegistrationButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.ForeColor = System.Drawing.Color.Red
        Me.ExitButton.Location = New System.Drawing.Point(181, 198)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 282)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BusinessRegistrationButton)
        Me.Controls.Add(Me.UserRegistrationButton)
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome To Booky"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserRegistrationButton As Button
    Friend WithEvents BusinessRegistrationButton As Button
    Friend WithEvents ExitButton As Button
End Class
