<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaquinarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdemDeServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizarOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancoDeDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReduntanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncluiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlteraExcluiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaquinarioToolStripMenuItem, Me.OrdemDeServiçoToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.AdministrativoToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MaquinarioToolStripMenuItem
        '
        Me.MaquinarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MaquinarioToolStripMenuItem.Name = "MaquinarioToolStripMenuItem"
        Me.MaquinarioToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MaquinarioToolStripMenuItem.Text = "&Maquinário"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "&Incluir"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "&Alterar/Excluir"
        '
        'OrdemDeServiçoToolStripMenuItem
        '
        Me.OrdemDeServiçoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluirToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.FinalizarOSToolStripMenuItem})
        Me.OrdemDeServiçoToolStripMenuItem.Name = "OrdemDeServiçoToolStripMenuItem"
        Me.OrdemDeServiçoToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.OrdemDeServiçoToolStripMenuItem.Text = "&Ordem de Serviço"
        '
        'IncluirToolStripMenuItem
        '
        Me.IncluirToolStripMenuItem.Name = "IncluirToolStripMenuItem"
        Me.IncluirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncluirToolStripMenuItem.Text = "&Incluir"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlterarToolStripMenuItem.Text = "&Alterar/Excluir"
        '
        'FinalizarOSToolStripMenuItem
        '
        Me.FinalizarOSToolStripMenuItem.Name = "FinalizarOSToolStripMenuItem"
        Me.FinalizarOSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FinalizarOSToolStripMenuItem.Text = "&Finalizar"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "&Relatórios"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuáriosToolStripMenuItem, Me.BancoDeDadosToolStripMenuItem})
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.AdministrativoToolStripMenuItem.Text = "&Administrativo"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluiToolStripMenuItem, Me.AlteraExcluiToolStripMenuItem})
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'BancoDeDadosToolStripMenuItem
        '
        Me.BancoDeDadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.ReduntanteToolStripMenuItem})
        Me.BancoDeDadosToolStripMenuItem.Name = "BancoDeDadosToolStripMenuItem"
        Me.BancoDeDadosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BancoDeDadosToolStripMenuItem.Text = "Banco de dados"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'ReduntanteToolStripMenuItem
        '
        Me.ReduntanteToolStripMenuItem.Name = "ReduntanteToolStripMenuItem"
        Me.ReduntanteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReduntanteToolStripMenuItem.Text = "Backup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre"
        '
        'IncluiToolStripMenuItem
        '
        Me.IncluiToolStripMenuItem.Name = "IncluiToolStripMenuItem"
        Me.IncluiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncluiToolStripMenuItem.Text = "Inclui"
        '
        'AlteraExcluiToolStripMenuItem
        '
        Me.AlteraExcluiToolStripMenuItem.Name = "AlteraExcluiToolStripMenuItem"
        Me.AlteraExcluiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlteraExcluiToolStripMenuItem.Text = "Altera/Exclui"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(660, 411)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gerenciamento de Ordem de Serviço | Beta 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OrdemDeServiçoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizarOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaquinarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancoDeDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReduntanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncluiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlteraExcluiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
