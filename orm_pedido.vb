Module orm_pedido

    Function consultar_pedido_id(id_pedido As Integer)
        Return selecionar_campos("pedido", "ID_pedido", id_pedido.ToString)
    End Function

    Function selecionar_produtos_pedido(id_pedido As Integer)
        Return selecionar_campos_join("pedido_produto", "produto", "ID_pedido_produto", "ID_produto", id_pedido.ToString)
    End Function

    Function inserir_pedido(id_atendente As String, cpf_cliente As String)
        Try
            sql = "INSERT INTO pedido (ID_atendente, CPF_cliente) VALUES ('" & id_atendente & "','" & cpf_cliente & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function alterar_pedido(id_atendente As Integer, cpf_cliente As String, status As String, forma_pagto As String, id_pedido As Integer)
        Try
            sql = "UPDATE pedido SET ID_atendente = '" & id_atendente & "', CPF_cliente = '" & cpf_cliente & "', status = '" & status & "', Forma_pagto = '" & forma_pagto & "' WHERE ID_pedido = " & id_pedido
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function excluir_pedido(id_pedido As Integer)
        Return excluir_campo("pedido", "ID_pedido", id_pedido)
    End Function

    Function adicionar_produto_a_pedido(id_pedido As Integer, id_produto As Integer)
        Try
            sql = "INSERT INTO pedido_produto (ID_pedido, ID_produto) VALUES (" & id_pedido & "." & id_produto & ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function remover_produto_do_pedido(id_pedido As Integer, id_produto As Integer)
        Try
            sql = "DELETE FROM pedido_produto WHERE ID_pedido = " & id_pedido & " AND id_produto = '" & id_produto & "'"
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function
End Module
