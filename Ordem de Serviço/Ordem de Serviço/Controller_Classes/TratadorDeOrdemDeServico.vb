Public Class TratadorDeOrdemDeServico
    Public Sub CriaOrdemDeServico(vCodigoMaquina As String, vDataDeCriacao As DateTime, Optional vComentarios As String = "")
        Dim novaOrdemDeServico As OrdemServico_Header
        Dim maquina As Maquinas
        novaOrdemDeServico = New OrdemServico_Header()

        maquina = Maquinas.BuscarMaquina(vCodigoMaquina)

        novaOrdemDeServico.Maquina = maquina
        novaOrdemDeServico.DataDeCriacao = vDataDeCriacao
        novaOrdemDeServico.Comentarios = vComentarios

    End Sub

    Public Sub IncluirLinhaNaOrdemDeServico(ordemDeServico As OrdemServico_Header, vCodigoDoItem As String, vValor As Double)
        Dim item As Items = Items.BuscarItem(vCodigoDoItem)
        ordemDeServico.IncluirLinhaNaOs(item, vValor)
    End Sub

    Public Sub RemoverLinhaNaOrdemDeServico(ordemDeServico As OrdemServico_Header, vCodigoItem As String)
        Dim item As Items = Items.BuscarItem(vCodigoItem)
        ordemDeServico.RemoverLinhaNaOS(item)
    End Sub
End Class
