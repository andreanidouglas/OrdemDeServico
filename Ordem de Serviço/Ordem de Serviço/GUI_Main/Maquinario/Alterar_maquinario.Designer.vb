<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_maquinario
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
        Me.maq_alterar_alterar = New System.Windows.Forms.Button()
        Me.maq_alterar_salvar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maq_alterar_nome = New System.Windows.Forms.TextBox()
        Me.maq_alterar_excluir = New System.Windows.Forms.Button()
        Me.maq_alterar_cod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Código:"
        '
        'maq_alterar_alterar
        '
        Me.maq_alterar_alterar.Location = New System.Drawing.Point(42, 64)
        Me.maq_alterar_alterar.Name = "maq_alterar_alterar"
        Me.maq_alterar_alterar.Size = New System.Drawing.Size(75, 23)
        Me.maq_alterar_alterar.TabIndex = 17
        Me.maq_alterar_alterar.Text = "Alterar"
        Me.maq_alterar_alterar.UseVisualStyleBackColor = True
        '
        'maq_alterar_salvar
        '
        Me.maq_alterar_salvar.Enabled = False
        Me.maq_alterar_salvar.Location = New System.Drawing.Point(204, 64)
        Me.maq_alterar_salvar.Name = "maq_alterar_salvar"
        Me.maq_alterar_salvar.Size = New System.Drawing.Size(75, 23)
        Me.maq_alterar_salvar.TabIndex = 16
        Me.maq_alterar_salvar.Text = "Salvar"
        Me.maq_alterar_salvar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nome:"
        '
        'maq_alterar_nome
        '
        Me.maq_alterar_nome.Enabled = False
        Me.maq_alterar_nome.Location = New System.Drawing.Point(57, 38)
        Me.maq_alterar_nome.Name = "maq_alterar_nome"
        Me.maq_alterar_nome.Size = New System.Drawing.Size(222, 20)
        Me.maq_alterar_nome.TabIndex = 14
        '
        'maq_alterar_excluir
        '
        Me.maq_alterar_excluir.Enabled = False
        Me.maq_alterar_excluir.Location = New System.Drawing.Point(123, 64)
        Me.maq_alterar_excluir.Name = "maq_alterar_excluir"
        Me.maq_alterar_excluir.Size = New System.Drawing.Size(75, 23)
        Me.maq_alterar_excluir.TabIndex = 20
        Me.maq_alterar_excluir.Text = "Excluir"
        Me.maq_alterar_excluir.UseVisualStyleBackColor = True
        '
        'maq_alterar_cod
        '
        Me.maq_alterar_cod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.maq_alterar_cod.FormattingEnabled = True
        Me.maq_alterar_cod.Location = New System.Drawing.Point(57, 11)
        Me.maq_alterar_cod.Name = "maq_alterar_cod"
        Me.maq_alterar_cod.Size = New System.Drawing.Size(121, 21)
        Me.maq_alterar_cod.TabIndex = 21
        '
        'Alterar_maquinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 100)
        Me.Controls.Add(Me.maq_alterar_cod)
        Me.Controls.Add(Me.maq_alterar_excluir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maq_alterar_alterar)
        Me.Controls.Add(Me.maq_alterar_salvar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.maq_alterar_nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alterar_maquinario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Maquinário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maq_alterar_alterar As System.Windows.Forms.Button
    Friend WithEvents maq_alterar_salvar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maq_alterar_nome As System.Windows.Forms.TextBox
    Friend WithEvents maq_alterar_excluir As System.Windows.Forms.Button
    Friend WithEvents maq_alterar_cod As System.Windows.Forms.ComboBox
End Class
