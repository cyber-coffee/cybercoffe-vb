Module session_variables
    Public ID_pedido As String
    Public atendente As ADODB.Recordset
    Public role As String
    Public today = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year

    Sub alterar_pedido_selecionado(pedido As String)
        ID_pedido = pedido
    End Sub

    Sub alterar_sessao_atendente(entidade_atendente As ADODB.Recordset)
        atendente = entidade_atendente
        role = "atendente"
    End Sub

    Sub alterar_sessao_cargo(cargo As String)
        role = cargo
    End Sub
End Module
