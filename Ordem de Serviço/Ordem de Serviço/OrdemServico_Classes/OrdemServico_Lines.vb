Public Class OrdemServico_Lines
    Private vItem As Items
    Public Property Item() As Items
        Get
            Return vItem
        End Get
        Set(ByVal value As Items)
            vItem = value
        End Set
    End Property

    Private vValor As Double
    Public Property Valor() As Double
        Get
            Return vValor
        End Get
        Set(ByVal value As Double)
            vValor = value
        End Set
    End Property

End Class
