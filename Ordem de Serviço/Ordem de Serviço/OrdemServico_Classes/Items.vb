
Public Class Items
    Private vDescricao As String
    Public Property Descricao() As String
        Get
            Return vDescricao
        End Get
        Set(ByVal value As String)
            vDescricao = value
        End Set
    End Property

    Private vMarca As String
    Public Property Marca() As String
        Get
            Return vMarca
        End Get
        Set(ByVal value As String)
            vMarca = value
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

    Private vUltimoPreco As String
    Public Property UltimoPreco() As String
        Get
            Return vUltimoPreco
        End Get
        Set(ByVal value As String)
            vUltimoPreco = value
        End Set
    End Property

    Private vCriadoPor As String
    Public Property CriadoPor() As String
        Get
            Return vCriadoPor
        End Get
        Set(ByVal value As String)
            vCriadoPor = value
        End Set
    End Property

    Public Sub AlterarItem(vDescricao, vMarca)
        Me.vDescricao = vDescricao
        Me.vMarca = vMarca
    End Sub

    Public Shared Function BuscarItem(vCodigoItem As String) As Items
        ''Not Yet Implemented
        BuscarItem = New Items()
    End Function
End Class
