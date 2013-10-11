<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.login_user = New System.Windows.Forms.TextBox()
        Me.login_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login_entrar = New System.Windows.Forms.Button()
        Me.login_fechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login_user
        '
        Me.login_user.Location = New System.Drawing.Point(64, 18)
        Me.login_user.Name = "login_user"
        Me.login_user.Size = New System.Drawing.Size(208, 20)
        Me.login_user.TabIndex = 0
        '
        'login_pass
        '
        Me.login_pass.Location = New System.Drawing.Point(64, 44)
        Me.login_pass.Name = "login_pass"
        Me.login_pass.Size = New System.Drawing.Size(208, 20)
        Me.login_pass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha:"
        '
        'login_entrar
        '
        Me.login_entrar.Location = New System.Drawing.Point(197, 70)
        Me.login_entrar.Name = "login_entrar"
        Me.login_entrar.Size = New System.Drawing.Size(75, 23)
        Me.login_entrar.TabIndex = 6
        Me.login_entrar.Text = "&Entrar"
        Me.login_entrar.UseVisualStyleBackColor = True
        '
        'login_fechar
        '
        Me.login_fechar.Location = New System.Drawing.Point(116, 70)
        Me.login_fechar.Name = "login_fechar"
        Me.login_fechar.Size = New System.Drawing.Size(75, 23)
        Me.login_fechar.TabIndex = 7
        Me.login_fechar.Text = "&Fechar"
        Me.login_fechar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 104)
        Me.Controls.Add(Me.login_fechar)
        Me.Controls.Add(Me.login_entrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login_pass)
        Me.Controls.Add(Me.login_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.G.O.S | BETA 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_user As System.Windows.Forms.TextBox
    Friend WithEvents login_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents login_entrar As System.Windows.Forms.Button
    Friend WithEvents login_fechar As System.Windows.Forms.Button

End Class
