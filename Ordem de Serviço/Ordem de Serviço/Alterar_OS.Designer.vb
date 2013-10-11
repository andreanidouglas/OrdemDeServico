<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_OS
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
        Me.os_alterar_mask_valor = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.os_alterar_excluir_peca = New System.Windows.Forms.Button()
        Me.os_alterar_editar_peca = New System.Windows.Forms.Button()
        Me.os_alterar_pecas = New System.Windows.Forms.ComboBox()
        Me.os_alterar_lista_pecas = New System.Windows.Forms.ListBox()
        Me.os_alterar_incluir_peca = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.os_alterar_maquina = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.os_alterar_data_fechamento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.os_alterar_estado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.os_alterar_codigo = New System.Windows.Forms.TextBox()
        Me.os_alterar_data_abertura = New System.Windows.Forms.DateTimePicker()
        Me.os_alterar_excluir = New System.Windows.Forms.Button()
        Me.os_alterar_alterar = New System.Windows.Forms.Button()
        Me.os_alterar_salvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'os_alterar_mask_valor
        '
        Me.os_alterar_mask_valor.Location = New System.Drawing.Point(52, 123)
        Me.os_alterar_mask_valor.Mask = "$999,999.00"
        Me.os_alterar_mask_valor.Name = "os_alterar_mask_valor"
        Me.os_alterar_mask_valor.Size = New System.Drawing.Size(120, 20)
        Me.os_alterar_mask_valor.TabIndex = 38
        Me.os_alterar_mask_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Valor:"
        '
        'os_alterar_excluir_peca
        '
        Me.os_alterar_excluir_peca.Location = New System.Drawing.Point(210, 121)
        Me.os_alterar_excluir_peca.Name = "os_alterar_excluir_peca"
        Me.os_alterar_excluir_peca.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_excluir_peca.TabIndex = 36
        Me.os_alterar_excluir_peca.Text = "Excluir"
        Me.os_alterar_excluir_peca.UseVisualStyleBackColor = True
        '
        'os_alterar_editar_peca
        '
        Me.os_alterar_editar_peca.Location = New System.Drawing.Point(291, 121)
        Me.os_alterar_editar_peca.Name = "os_alterar_editar_peca"
        Me.os_alterar_editar_peca.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_editar_peca.TabIndex = 35
        Me.os_alterar_editar_peca.Text = "Editar"
        Me.os_alterar_editar_peca.UseVisualStyleBackColor = True
        '
        'os_alterar_pecas
        '
        Me.os_alterar_pecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.os_alterar_pecas.FormattingEnabled = True
        Me.os_alterar_pecas.Location = New System.Drawing.Point(53, 94)
        Me.os_alterar_pecas.Name = "os_alterar_pecas"
        Me.os_alterar_pecas.Size = New System.Drawing.Size(394, 21)
        Me.os_alterar_pecas.TabIndex = 34
        '
        'os_alterar_lista_pecas
        '
        Me.os_alterar_lista_pecas.FormattingEnabled = True
        Me.os_alterar_lista_pecas.Location = New System.Drawing.Point(12, 150)
        Me.os_alterar_lista_pecas.Name = "os_alterar_lista_pecas"
        Me.os_alterar_lista_pecas.Size = New System.Drawing.Size(435, 95)
        Me.os_alterar_lista_pecas.TabIndex = 33
        '
        'os_alterar_incluir_peca
        '
        Me.os_alterar_incluir_peca.Location = New System.Drawing.Point(372, 121)
        Me.os_alterar_incluir_peca.Name = "os_alterar_incluir_peca"
        Me.os_alterar_incluir_peca.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_incluir_peca.TabIndex = 26
        Me.os_alterar_incluir_peca.Text = "Incluir"
        Me.os_alterar_incluir_peca.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Peça:"
        '
        'os_alterar_maquina
        '
        Me.os_alterar_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.os_alterar_maquina.FormattingEnabled = True
        Me.os_alterar_maquina.Location = New System.Drawing.Point(69, 67)
        Me.os_alterar_maquina.Name = "os_alterar_maquina"
        Me.os_alterar_maquina.Size = New System.Drawing.Size(378, 21)
        Me.os_alterar_maquina.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Maquina:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Data de Fechamento:"
        '
        'os_alterar_data_fechamento
        '
        Me.os_alterar_data_fechamento.Enabled = False
        Me.os_alterar_data_fechamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.os_alterar_data_fechamento.Location = New System.Drawing.Point(339, 41)
        Me.os_alterar_data_fechamento.Name = "os_alterar_data_fechamento"
        Me.os_alterar_data_fechamento.Size = New System.Drawing.Size(108, 20)
        Me.os_alterar_data_fechamento.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Data de Abertura:"
        '
        'os_alterar_estado
        '
        Me.os_alterar_estado.Enabled = False
        Me.os_alterar_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.os_alterar_estado.Location = New System.Drawing.Point(260, 15)
        Me.os_alterar_estado.Name = "os_alterar_estado"
        Me.os_alterar_estado.Size = New System.Drawing.Size(187, 20)
        Me.os_alterar_estado.TabIndex = 27
        Me.os_alterar_estado.Text = "ABERTURA"
        Me.os_alterar_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Estado da OS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Código:"
        '
        'os_alterar_codigo
        '
        Me.os_alterar_codigo.Enabled = False
        Me.os_alterar_codigo.Location = New System.Drawing.Point(61, 15)
        Me.os_alterar_codigo.Name = "os_alterar_codigo"
        Me.os_alterar_codigo.Size = New System.Drawing.Size(111, 20)
        Me.os_alterar_codigo.TabIndex = 22
        '
        'os_alterar_data_abertura
        '
        Me.os_alterar_data_abertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.os_alterar_data_abertura.Location = New System.Drawing.Point(109, 41)
        Me.os_alterar_data_abertura.Name = "os_alterar_data_abertura"
        Me.os_alterar_data_abertura.Size = New System.Drawing.Size(108, 20)
        Me.os_alterar_data_abertura.TabIndex = 21
        '
        'os_alterar_excluir
        '
        Me.os_alterar_excluir.Enabled = False
        Me.os_alterar_excluir.Location = New System.Drawing.Point(291, 251)
        Me.os_alterar_excluir.Name = "os_alterar_excluir"
        Me.os_alterar_excluir.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_excluir.TabIndex = 43
        Me.os_alterar_excluir.Text = "Excluir"
        Me.os_alterar_excluir.UseVisualStyleBackColor = True
        '
        'os_alterar_alterar
        '
        Me.os_alterar_alterar.Location = New System.Drawing.Point(210, 251)
        Me.os_alterar_alterar.Name = "os_alterar_alterar"
        Me.os_alterar_alterar.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_alterar.TabIndex = 42
        Me.os_alterar_alterar.Text = "Alterar"
        Me.os_alterar_alterar.UseVisualStyleBackColor = True
        '
        'os_alterar_salvar
        '
        Me.os_alterar_salvar.Enabled = False
        Me.os_alterar_salvar.Location = New System.Drawing.Point(371, 251)
        Me.os_alterar_salvar.Name = "os_alterar_salvar"
        Me.os_alterar_salvar.Size = New System.Drawing.Size(75, 23)
        Me.os_alterar_salvar.TabIndex = 41
        Me.os_alterar_salvar.Text = "Salvar"
        Me.os_alterar_salvar.UseVisualStyleBackColor = True
        '
        'Alterar_OS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 283)
        Me.Controls.Add(Me.os_alterar_excluir)
        Me.Controls.Add(Me.os_alterar_alterar)
        Me.Controls.Add(Me.os_alterar_salvar)
        Me.Controls.Add(Me.os_alterar_mask_valor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.os_alterar_excluir_peca)
        Me.Controls.Add(Me.os_alterar_editar_peca)
        Me.Controls.Add(Me.os_alterar_pecas)
        Me.Controls.Add(Me.os_alterar_lista_pecas)
        Me.Controls.Add(Me.os_alterar_incluir_peca)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.os_alterar_maquina)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.os_alterar_data_fechamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.os_alterar_estado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.os_alterar_codigo)
        Me.Controls.Add(Me.os_alterar_data_abertura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alterar_OS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Ordem de Serviço"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents os_alterar_mask_valor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents os_alterar_excluir_peca As System.Windows.Forms.Button
    Friend WithEvents os_alterar_editar_peca As System.Windows.Forms.Button
    Friend WithEvents os_alterar_pecas As System.Windows.Forms.ComboBox
    Friend WithEvents os_alterar_lista_pecas As System.Windows.Forms.ListBox
    Friend WithEvents os_alterar_incluir_peca As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents os_alterar_maquina As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents os_alterar_data_fechamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents os_alterar_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents os_alterar_codigo As System.Windows.Forms.TextBox
    Friend WithEvents os_alterar_data_abertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents os_alterar_excluir As System.Windows.Forms.Button
    Friend WithEvents os_alterar_alterar As System.Windows.Forms.Button
    Friend WithEvents os_alterar_salvar As System.Windows.Forms.Button
End Class
