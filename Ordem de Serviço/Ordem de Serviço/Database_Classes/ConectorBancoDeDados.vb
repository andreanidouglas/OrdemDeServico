Imports MySql.Data.MySqlClient
Public Class ConectorBancoDeDados
    Private Con_S As String
    Private conn As MySqlConnection


    Public Sub New(servidor As String, login As String, senha As String, database As String)
        Try
            Me.Con_S = "server=" + servidor + ";user id=" + login + ";password=" + senha + ";database=" + database
            conn = New MySqlConnection
            conn.ConnectionString = Con_S
        Catch ex As Exception
            Throw New Exception("Conexao com o servidor invalida")
        End Try
      
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Sub NoReturnQuery(query As String)
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Erro na Leitura da Query")
        End Try
    End Sub

    Public Function SelectQuery(query As String) As MySqlDataReader
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            Dim drArmazena As MySqlDataReader
            drArmazena = cmd.ExecuteReader()
            If Not drArmazena.HasRows Then
                Throw New Exception("No Rows Returned")
                Exit Function
            Else
                SelectQuery = drArmazena
            End If
        Catch ex As Exception
            Throw New Exception("Erro na Leitura da Query")
        End Try
    End Function
End Class
