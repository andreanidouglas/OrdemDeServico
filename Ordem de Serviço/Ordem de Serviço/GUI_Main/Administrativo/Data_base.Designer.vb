<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_base
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.data_base_endereco_server = New System.Windows.Forms.TextBox()
        Me.data_base_porta = New System.Windows.Forms.TextBox()
        Me.data_base_login = New System.Windows.Forms.TextBox()
        Me.data_base_senha = New System.Windows.Forms.TextBox()
        Me.data_base_nome_do_bando = New System.Windows.Forms.TextBox()
        Me.data_base_cadastrar = New System.Windows.Forms.Button()
        Me.data_base_fechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Endereço do servidor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Porta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Senha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nome de banco:"
        '
        'data_base_endereco_server
        '
        Me.data_base_endereco_server.Location = New System.Drawing.Point(129, 16)
        Me.data_base_endereco_server.Name = "data_base_endereco_server"
        Me.data_base_endereco_server.Size = New System.Drawing.Size(143, 20)
        Me.data_base_endereco_server.TabIndex = 5
        '
        'data_base_porta
        '
        Me.data_base_porta.Location = New System.Drawing.Point(50, 42)
        Me.data_base_porta.Name = "data_base_porta"
        Me.data_base_porta.Size = New System.Drawing.Size(222, 20)
        Me.data_base_porta.TabIndex = 6
        '
        'data_base_login
        '
        Me.data_base_login.Location = New System.Drawing.Point(50, 68)
        Me.data_base_login.Name = "data_base_login"
        Me.data_base_login.Size = New System.Drawing.Size(222, 20)
        Me.data_base_login.TabIndex = 7
        '
        'data_base_senha
        '
        Me.data_base_senha.Location = New System.Drawing.Point(50, 94)
        Me.data_base_senha.Name = "data_base_senha"
        Me.data_base_senha.Size = New System.Drawing.Size(222, 20)
        Me.data_base_senha.TabIndex = 8
        '
        'data_base_nome_do_bando
        '
        Me.data_base_nome_do_bando.Location = New System.Drawing.Point(104, 120)
        Me.data_base_nome_do_bando.Name = "data_base_nome_do_bando"
        Me.data_base_nome_do_bando.Size = New System.Drawing.Size(168, 20)
        Me.data_base_nome_do_bando.TabIndex = 9
        '
        'data_base_cadastrar
        '
        Me.data_base_cadastrar.Location = New System.Drawing.Point(197, 151)
        Me.data_base_cadastrar.Name = "data_base_cadastrar"
        Me.data_base_cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.data_base_cadastrar.TabIndex = 10
        Me.data_base_cadastrar.Text = "Cadastrar"
        Me.data_base_cadastrar.UseVisualStyleBackColor = True
        '
        'data_base_fechar
        '
        Me.data_base_fechar.Location = New System.Drawing.Point(116, 151)
        Me.data_base_fechar.Name = "data_base_fechar"
        Me.data_base_fechar.Size = New System.Drawing.Size(75, 23)
        Me.data_base_fechar.TabIndex = 11
        Me.data_base_fechar.Text = "Fechar"
        Me.data_base_fechar.UseVisualStyleBackColor = True
        '
        'Data_base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.data_base_fechar
        Me.ClientSize = New System.Drawing.Size(284, 186)
        Me.Controls.Add(Me.data_base_fechar)
        Me.Controls.Add(Me.data_base_cadastrar)
        Me.Controls.Add(Me.data_base_nome_do_bando)
        Me.Controls.Add(Me.data_base_senha)
        Me.Controls.Add(Me.data_base_login)
        Me.Controls.Add(Me.data_base_porta)
        Me.Controls.Add(Me.data_base_endereco_server)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Data_base"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Base "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents data_base_endereco_server As System.Windows.Forms.TextBox
    Friend WithEvents data_base_porta As System.Windows.Forms.TextBox
    Friend WithEvents data_base_login As System.Windows.Forms.TextBox
    Friend WithEvents data_base_senha As System.Windows.Forms.TextBox
    Friend WithEvents data_base_nome_do_bando As System.Windows.Forms.TextBox
    Friend WithEvents data_base_cadastrar As System.Windows.Forms.Button
    Friend WithEvents data_base_fechar As System.Windows.Forms.Button
End Class
