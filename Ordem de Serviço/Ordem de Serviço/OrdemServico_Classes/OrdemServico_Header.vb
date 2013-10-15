
Public Class OrdemServico_Header

    Private vCodigo As String
    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal value As String)
            vCodigo = value
        End Set
    End Property

    Private vDataDeCriacao As DateTime
    Public Property DataDeCriacao() As DateTime
        Get
            Return vDataDeCriacao
        End Get
        Set(ByVal value As DateTime)
            vDataDeCriacao = value
        End Set
    End Property

    Private vCriadoPor As Usuarios
    Public Property CriadoPo() As Usuarios
        Get
            Return vCriadoPor
        End Get
        Set(ByVal value As Usuarios)
            vCriadoPor = value
        End Set
    End Property

    Private vDataDaUltimaAtualizacao As DateTime
    Public Property DataDaUltimaAtulizacao() As DateTime
        Get
            Return vDataDaUltimaAtualizacao
        End Get
        Set(ByVal value As DateTime)
            vDataDaUltimaAtualizacao = value
        End Set
    End Property

    Private vUsuarioDaUltimaAtualizacao As Usuarios
    Public Property UsuarioDaUltimaAtualizacao() As Usuarios
        Get
            Return vUsuarioDaUltimaAtualizacao
        End Get
        Set(ByVal value As Usuarios)
            vUsuarioDaUltimaAtualizacao = value
        End Set
    End Property

    Private vStatus As String
    Public Property Status() As String
        Get
            Return vStatus
        End Get
        Set(ByVal value As String)
            vStatus = value
        End Set
    End Property

    Private vMaquina As Maquinas
    Public Property Maquina() As Maquinas
        Get
            Return vMaquina
        End Get
        Set(ByVal value As Maquinas)
            vMaquina = value
        End Set
    End Property

    Private vComentarios As String
    Public Property Comentarios() As String
        Get
            Return vComentarios
        End Get
        Set(ByVal value As String)
            vComentarios = value
        End Set
    End Property

    Private LinhasDaOS As List(Of OrdemServico_Lines)

    Public Sub IncluirLinhaNaOs(vItem As Items, valor As Double)
        Dim OS_line As OrdemServico_Lines
        OS_line = New OrdemServico_Lines
        OS_line.Valor = valor
        OS_line.Item = vItem
        LinhasDaOS.Add(OS_line)
    End Sub

    Public Sub RemoverLinhaNaOS(vItem As Items)
        For i = 0 To LinhasDaOS.Count
            If LinhasDaOS(i).Item.Equals(vItem) Then
                LinhasDaOS.RemoveAt(i)
            End If
        Next
    End Sub

    Public Sub AlterarValorLinhaNaOs(vItem As Items, valor As Double)
        For i = 0 To LinhasDaOS.Count
            If LinhasDaOS(i).Item.Equals(vItem) Then
                LinhasDaOS(i).Valor = valor
            End If
        Next
    End Sub

    Public Sub GravarOS_DB()
        Dim cdb As ConectorBancoDeDados
        cdb = New ConectorBancoDeDados()
        cdb.NoReturnQuery("Insert into `so_header` (`codigo_os`, `creation_date`, `last_update_date`, `last_update_by`, `status`, `maquina_id`, `comments`)" + _
                                           "values ('" + Me.Codigo + "'" + _
                                                   "'" + Me.DataDeCriacao + "' " + _
                                                   "'" + Me.DataDaUltimaAtulizacao + "' " + _
                                                   "'" + Me.UsuarioDaUltimaAtualizacao.username + "' " + _
                                                   "'" + Me.Status + "' " + _
                                                   "'" + Me.Maquina.codigo + "' " + _
                                                   "'" + Me.Comentarios + "')")

        ''tratar entrada de datas e criar novos objetos


    End Sub

    Public Sub AlterarOS_DB()
        Dim cdb As ConectorBancoDeDados
        cdb = New ConectorBancoDeDados()
        cdb.NoReturnQuery("Update set `last_update_date` = '" + Me.DataDaUltimaAtulizacao + "', " + _
                                      "`last_update_by` = '" + Me.UsuarioDaUltimaAtualizacao.username + "', " + _
                                      "`status` = '" + Me.Status + "', " + _
                                      "`comments` = '" + Me.Comentarios)
    End Sub
End Class
