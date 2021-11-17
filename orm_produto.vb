Module orm_produto

    Function consultar_produto_id(id_produto As Integer)
        Return selecionar_campos("produto", "ID_produto", id_produto.ToString)
    End Function
    Function inserir_produto(nome_produto As String, valor As Double, id_categoria As Integer, qtde_estoque As Integer)
        Try
            sql = "INSERT INTO produto (Nome_produto, valor, id_categoria, Qtde_estoque) VALUES ('" & nome_produto & "','" & valor & "'," & id_categoria & ", " & qtde_estoque & ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function alterar_produto(nome_produto As String, valor As Double, id_categoria As Integer, qtde_estoque As Integer, id_produto As Integer)
        Try
            sql = "UPDATE produto SET Nome_produto = '" & nome_produto & "', " &
                " valor = '" & valor & "', " &
                " Qtde_estoque = " & qtde_estoque & ", " &
                " ID_categoria = " & id_categoria &
                " WHERE id_produto = " & id_produto
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function excluir_produto(id_produto As Integer)
        Return excluir_campo("produto", "ID_produto", id_produto)
    End Function

End Module
