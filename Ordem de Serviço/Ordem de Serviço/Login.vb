Public Class Login

    Private Sub login_fechar_Click(sender As Object, e As EventArgs) Handles login_fechar.Click
        Close()
    End Sub

    Private Sub login_entrar_Click(sender As Object, e As EventArgs) Handles login_entrar.Click
        Principal.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
