Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Visible = False
    End Sub

    Private Sub IncluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncluirToolStripMenuItem.Click
        Incluir_OS.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Incluir_maquinario.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Alterar_maquinario.ShowDialog()

    End Sub
End Class