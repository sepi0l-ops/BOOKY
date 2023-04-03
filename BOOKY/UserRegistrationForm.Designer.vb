<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistrationForm))
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.ContactLabel = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(264, 46)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(307, 27)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(93, 49)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(75, 16)
        Me.FirstNameLabel.TabIndex = 3
        Me.FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(93, 110)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(75, 16)
        Me.LastNameLabel.TabIndex = 4
        Me.LastNameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(93, 178)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(44, 16)
        Me.EmailLabel.TabIndex = 5
        Me.EmailLabel.Text = "Email:"
        '
        'ContactLabel
        '
        Me.ContactLabel.AutoSize = True
        Me.ContactLabel.Location = New System.Drawing.Point(93, 289)
        Me.ContactLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContactLabel.Name = "ContactLabel"
        Me.ContactLabel.Size = New System.Drawing.Size(55, 16)
        Me.ContactLabel.TabIndex = 6
        Me.ContactLabel.Text = "Contact:"
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(264, 366)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(127, 39)
        Me.RegisterButton.TabIndex = 8
        Me.RegisterButton.Text = "Sign &Up"
        Me.ToolTip1.SetToolTip(Me.RegisterButton, "Your credentials will be updated on clicking")
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(445, 366)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(127, 39)
        Me.BackButton.TabIndex = 9
        Me.BackButton.Text = "B&ack"
        Me.ToolTip2.SetToolTip(Me.BackButton, "Thank you for registering you will be directed to the welcome form")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(264, 110)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(307, 27)
        Me.LastNameTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(264, 178)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(307, 27)
        Me.EmailTextBox.TabIndex = 11
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Location = New System.Drawing.Point(264, 286)
        Me.ContactTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactTextBox.Multiline = True
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(307, 27)
        Me.ContactTextBox.TabIndex = 12
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(93, 239)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(67, 16)
        Me.PasswordLabel.TabIndex = 13
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(264, 239)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(307, 22)
        Me.PasswordTextBox.TabIndex = 14
        '
        'UserRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 448)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.ContactLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserRegistrationForm"
        Me.Text = "User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents ContactLabel As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
End Class
