<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incluir_maquinario
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
        Me.maq_fechar = New System.Windows.Forms.Button()
        Me.maq_inclui = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maq_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maq_codigo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'maq_fechar
        '
        Me.maq_fechar.Location = New System.Drawing.Point(120, 64)
        Me.maq_fechar.Name = "maq_fechar"
        Me.maq_fechar.Size = New System.Drawing.Size(75, 23)
        Me.maq_fechar.TabIndex = 11
        Me.maq_fechar.Text = "Fechar"
        Me.maq_fechar.UseVisualStyleBackColor = True
        '
        'maq_inclui
        '
        Me.maq_inclui.Location = New System.Drawing.Point(201, 64)
        Me.maq_inclui.Name = "maq_inclui"
        Me.maq_inclui.Size = New System.Drawing.Size(75, 23)
        Me.maq_inclui.TabIndex = 10
        Me.maq_inclui.Text = "Incluir"
        Me.maq_inclui.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome:"
        '
        'maq_nome
        '
        Me.maq_nome.Location = New System.Drawing.Point(54, 38)
        Me.maq_nome.Name = "maq_nome"
        Me.maq_nome.Size = New System.Drawing.Size(222, 20)
        Me.maq_nome.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código:"
        '
        'maq_codigo
        '
        Me.maq_codigo.Enabled = False
        Me.maq_codigo.Location = New System.Drawing.Point(54, 12)
        Me.maq_codigo.Name = "maq_codigo"
        Me.maq_codigo.Size = New System.Drawing.Size(97, 20)
        Me.maq_codigo.TabIndex = 12
        '
        'Incluir_maquinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 97)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maq_codigo)
        Me.Controls.Add(Me.maq_fechar)
        Me.Controls.Add(Me.maq_inclui)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maq_nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Incluir_maquinario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Maquinário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents maq_fechar As System.Windows.Forms.Button
    Friend WithEvents maq_inclui As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maq_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maq_codigo As System.Windows.Forms.TextBox
End Class
