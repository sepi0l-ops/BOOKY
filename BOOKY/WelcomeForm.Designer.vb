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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        Me.UserRegistrationButton = New System.Windows.Forms.Button()
        Me.BusinessRegistrationButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserRegistrationButton
        '
        Me.UserRegistrationButton.Location = New System.Drawing.Point(44, 102)
        Me.UserRegistrationButton.Name = "UserRegistrationButton"
        Me.UserRegistrationButton.Size = New System.Drawing.Size(127, 39)
        Me.UserRegistrationButton.TabIndex = 0
        Me.UserRegistrationButton.Text = "Customer"
        Me.ToolTip1.SetToolTip(Me.UserRegistrationButton, "It will Direct you to the regular user form ")
        Me.UserRegistrationButton.UseVisualStyleBackColor = True
        '
        'BusinessRegistrationButton
        '
        Me.BusinessRegistrationButton.Location = New System.Drawing.Point(222, 102)
        Me.BusinessRegistrationButton.Name = "BusinessRegistrationButton"
        Me.BusinessRegistrationButton.Size = New System.Drawing.Size(129, 39)
        Me.BusinessRegistrationButton.TabIndex = 1
        Me.BusinessRegistrationButton.Text = "Business "
        Me.ToolTip2.SetToolTip(Me.BusinessRegistrationButton, "It will direct you to the business  owner  registration form")
        Me.BusinessRegistrationButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.ForeColor = System.Drawing.Color.Red
        Me.ExitButton.Location = New System.Drawing.Point(136, 172)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(110, 32)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip3.SetToolTip(Me.ExitButton, "It was nice of you visiting our system")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.Tag = "It will Direct you to the regular user form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How would you like to proceed as?"
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BusinessRegistrationButton)
        Me.Controls.Add(Me.UserRegistrationButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome To Booky"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserRegistrationButton As Button
    Friend WithEvents BusinessRegistrationButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents Label1 As Label
End Class
